using System;
using System.Runtime.Serialization;

namespace Seguro.Aplication.Service
{
    [Serializable]
    internal class VuelingException : Exception
    {
        public VuelingException()
        {
        }

        public VuelingException(string message) : base(message)
        {
        }

        public VuelingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VuelingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}