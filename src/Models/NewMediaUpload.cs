using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewMediaUpload
    {
		[JsonPropertyName("FileName")]
        public string FileName { get; set; }
    }
}
