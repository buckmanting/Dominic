namespace Dominic
{
    using System;

    public class DominicConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ViewFolderLocation;

        /// <summary>
        /// 
        /// </summary>
        public Func<Type, object> Resolver;
    }
}