using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewFolder
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("ParentFolderId")]
        public string ParentFolderId { get; set; }
    }
}
