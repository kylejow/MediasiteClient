using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewPresentation
    {
		[JsonPropertyName("Title")]
        public string Title { get; set; }
		[JsonPropertyName("Duration")]
        public int Duration { get; set; }
		[JsonPropertyName("FolderId")]
        public string FolderId { get; set; }
		[JsonPropertyName("PlayerId")]
        public string PlayerId { get; set; }
		[JsonPropertyName("RecordDateTime")]
        public DateTime RecordDateTime { get; set; }
    }
}
