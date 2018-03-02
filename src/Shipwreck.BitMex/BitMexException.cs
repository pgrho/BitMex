using System;
using System.Net.Http;

namespace Shipwreck.BitMex
{
    public class BitMexException : Exception
    {
        public BitMexException(ErrorResponse error)
            : base(error.Message)
        {
            Name = error.Name;
        }

        public BitMexException(HttpResponseMessage response)
            : base("An exception thrown while request.")
        {
            Response = response;
        }

        public BitMexException(string message, Exception innerException)
            : this(message, innerException, null)
        {
        }

        public BitMexException(string message, Exception innerException, HttpResponseMessage response)
            : base(message, innerException)
        {
            Response = response;
        }

        public string Name { get; }

        public HttpResponseMessage Response { get; }
    }
}