using System;
using System.Runtime.Serialization;

namespace CodeAnalysis
{
    // Not flagged in .net core
    public class CA2237Exception : Exception
    {
        public CA2237Exception() { }

        public CA2237Exception(string message) : base(message) { }

        public CA2237Exception(string message, Exception innerException) : base(message, innerException) { }

        protected CA2237Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}