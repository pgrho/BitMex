using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.BitMex
{
    [DataContract]
    public class Announcement
    {
        [DataMember, DefaultValue(0)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [DataMember, DefaultValue(null)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        [DataMember, DefaultValue(null)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [DataMember, DefaultValue(null)]
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [DataMember, DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00.000Z")]
        [JsonProperty(PropertyName = "date")]
        public DateTimeOffset Date { get; set; }
    }
}