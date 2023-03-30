using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewRecorderLogin
    {
        [JsonPropertyName("Username")]
        public string Username { get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
}
