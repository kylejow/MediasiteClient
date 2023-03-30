using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewAuthorizationTicket
    {
		[JsonPropertyName("Username")]
        public string Username { get; set; }
        [JsonPropertyName("ResourceId")]
        public string ResourceId { get; set; }
        [JsonPropertyName("MinutesToLive")]
        public int MinutesToLive { get; set; }
    }
}
