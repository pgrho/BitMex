using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.BitMex
{
    [DataContract]
    public class ErrorResponse
    {
        [DataMember, DefaultValue(null)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [DataMember, DefaultValue(null)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}