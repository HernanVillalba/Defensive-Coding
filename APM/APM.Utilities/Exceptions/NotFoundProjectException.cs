using System;
using System.Runtime.Serialization;

namespace APM.Utilities.Exceptions
{
    public class NotFoundProjectException : Exception
    {
        public NotFoundProjectException() : base()
        {
        }

        public NotFoundProjectException(string message) : base(message)
        {
        }

        public NotFoundProjectException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public NotFoundProjectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}