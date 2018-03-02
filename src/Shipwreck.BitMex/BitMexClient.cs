using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Shipwreck.BitMex
{
    public partial class BitMexClient
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

        #region SendAsync

        protected Task<T> GetAsync<T>(string path, bool shouldAuthorize = true)
            => SendAsync<T>(HttpMethod.Get, path, shouldAuthorize: shouldAuthorize);

        protected Task<T> SendAsync<T>(HttpMethod method, string path, bool shouldAuthorize = true)
        {
            var u = new Uri(BaseUrl, path);

            var m = new HttpRequestMessage(method, u);
            m.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (shouldAuthorize)
            {
                var nonce = Interlocked.Increment(ref _Nonce).ToString();

                m.Headers.Add("api-nonce", nonce);
                m.Headers.Add("api-key", ApiKey);
                m.Headers.Add("api-signature", GetSignature(m.Method.Method + u.AbsolutePath + nonce));
            }

            return SendAsyncCore<T>(m);
        }

        protected Task<T> SendAsync<T>(HttpMethod method, string path, string payload, bool shouldAuthorize = true, bool isJson = false)
        {
            var u = new Uri(BaseUrl, path);

            var m = new HttpRequestMessage(method, u);

            if (shouldAuthorize)
            {
                var nonce = Interlocked.Increment(ref _Nonce).ToString();

                m.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                m.Headers.Add("api-nonce", nonce);
                m.Headers.Add("api-key", ApiKey);
                m.Headers.Add("api-signature", GetSignature(m.Method.Method + u.AbsolutePath + nonce + payload));
            }
            m.Content = new StringContent(payload, Encoding.UTF8, isJson ? "application/json" : "application/x-www-form-urlencoded");

            return SendAsyncCore<T>(m);
        }

        private async Task<T> SendAsyncCore<T>(HttpRequestMessage message)
        {
            HttpResponseMessage res = null;
            try
            {
                using (var hc = new HttpClient())
                {
                    res = await hc.SendAsync(message).ConfigureAwait(false);

                    if (res.Content.Headers.ContentType?.MediaType == "application/json")
                    {
                        using (var s = await res.Content.ReadAsStreamAsync().ConfigureAwait(false))
                        using (var sr = new StreamReader(s, Encoding.UTF8))
                        using (var jr = new JsonTextReader(sr))
                        {
                            if (res.IsSuccessStatusCode)
                            {
                                return new JsonSerializer().Deserialize<T>(jr);
                            }
                            else
                            {
                                ErrorResponse e;
                                try
                                {
                                    e = new JsonSerializer().Deserialize<ErrorResponse>(jr);
                                }
                                catch
                                {
                                    e = null;
                                }

                                if (e != null)
                                {
                                    throw new BitMexException(e);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new BitMexException("An exception thrown while request.", ex);
            }
            throw new BitMexException(res);
        }

        #endregion SendAsync

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