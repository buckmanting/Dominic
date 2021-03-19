using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominic.Exceptions
{
    public class TooManyElementsFoundException : Exception
    {
        public TooManyElementsFoundException()
        {
        }

        public TooManyElementsFoundException(string message) : base(message)
        {
        }

        public TooManyElementsFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManyElementsFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
