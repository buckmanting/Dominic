using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RazorLight.Razor;

namespace Dominic
{
    using System;
    using Exceptions;

    public class LayoutLocator : RazorLightProject
    {
        private readonly string _layoutFolder;

        public LayoutLocator(string layoutFolder)
        {
            _layoutFolder = layoutFolder;
        }

        public override async Task<RazorLightProjectItem> GetItemAsync(string templateKey)
        {
            if (File.Exists(templateKey))
            {
                return new FileSystemRazorProjectItem(templateKey, new FileInfo(templateKey));
            }

            var path = $"{_layoutFolder}/{templateKey}";
            if (File.Exists(path))
            {
                return new FileSystemRazorProjectItem(templateKey, new FileInfo(path));
            }
            
            throw new ItemNotFoundException("couldn't find the layout or template");
        }

        public override Task<IEnumerable<RazorLightProjectItem>> GetImportsAsync(string templateKey)
        {
            return Task.FromResult(Enumerable.Empty<RazorLightProjectItem>());
        }
    }
}