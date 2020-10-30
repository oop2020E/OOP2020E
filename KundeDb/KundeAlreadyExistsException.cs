using System;
using System.Runtime.Serialization;

namespace KundeDb
{
    [Serializable]
    internal class KundeAlreadyExistsException : Exception
    {
        public KundeAlreadyExistsException()
        {
        }

        public KundeAlreadyExistsException(string message) : base(message)
        {
        }

        public KundeAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected KundeAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}