using System;
using System.Runtime.Serialization;

namespace CodeAnalysis
{
    // Not flagged in .net core
    [Serializable]
    public class Ca1722Exception : Exception
    {
        public Ca1722Exception() { }

        public Ca1722Exception(string message) : base(message) { }

        public Ca1722Exception(string message, Exception innerException) : base(message, innerException) { }

        protected Ca1722Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}