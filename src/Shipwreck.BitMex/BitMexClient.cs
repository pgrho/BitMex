using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Shipwreck.BitMex
{
    public class BitMexClient
    {
        public Uri BaseUrl = new Uri("https://www.bitmex.com/api/v1/");

        protected long _Nonce = DateTime.Now.Ticks & 0xFFFFFFFFFFFF;

        public string ApiKey { get; set; }

        #region ApiSecret

        private string _ApiSecret;

        public string ApiSecret
        {
            get => _ApiSecret;
            set
            {
                if (value != _ApiSecret)
                {
                    _ApiSecret = value;
                    _ApiSecretBytes = null;
                }
            }
        }

        private byte[] _ApiSecretBytes;

        private byte[] ApiSecretBytes
            => _ApiSecretBytes
                ?? (_ApiSecretBytes = _ApiSecret == null ? null : Encoding.UTF8.GetBytes(_ApiSecret));

        #endregion ApiSecret

        protected void Send(HttpMethod method, string path)
        {
            var u = new Uri(BaseUrl, path);

            var m = new HttpRequestMessage(method, u);
            var nonce = Interlocked.Increment(ref _Nonce).ToString();

            m.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            m.Headers.Add("api-nonce", nonce);
            m.Headers.Add("api-key", ApiKey);
            m.Headers.Add("api-signature", GetSignature(m.Method.Method + u.AbsolutePath + nonce));
        }

        protected void Send(HttpMethod method, string path, string payload, bool isJson = false)
        {
            var u = new Uri(BaseUrl, path);

            var m = new HttpRequestMessage(method, u);
            var nonce = Interlocked.Increment(ref _Nonce).ToString();

            m.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            m.Headers.Add("api-nonce", nonce);
            m.Headers.Add("api-key", ApiKey);
            m.Headers.Add("api-signature", GetSignature(m.Method.Method + u.AbsolutePath + nonce + payload));

            m.Content = new StringContent(payload, Encoding.UTF8, isJson ? "application/json" : "application/x-www-form-urlencoded");
        }

        private string GetSignature(string message)
        {
            using (var h = new HMACSHA256(ApiSecretBytes))
            {
                var ba = h.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(ba.Length * 2);
                foreach (var b in ba)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}