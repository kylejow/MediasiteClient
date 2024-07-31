using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewSchedule
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("TitleType")]
        public string TitleType { get; set; }
        [JsonPropertyName("FolderId")]
        public string FolderId { get; set; }
        [JsonPropertyName("ScheduleTemplateId")]
        public string ScheduleTemplateId { get; set; }
        [JsonPropertyName("IsUploadAutomatic")]
        public bool IsUploadAutomatic { get; set; }
        [JsonPropertyName("RecorderId")]
        public string RecorderId { get; set; }
        [JsonPropertyName("AdvanceCreationTime")]
        public Int32 AdvanceCreationTime { get; set; }
        [JsonPropertyName("AdvanceLoadTimeInSeconds")]
        public Int32 AdvanceLoadTimeInSeconds { get; set; }
        [JsonPropertyName("CreatePresentation")]
        public bool CreatePresentation { get; set; }
        [JsonPropertyName("LoadPresentation")]
        public bool LoadPresentation { get; set; }
        [JsonPropertyName("AutoStart")]
        public bool AutoStart { get; set; }
        [JsonPropertyName("AutoStop")]
        public bool AutoStop { get; set; }
        [JsonPropertyName("DeleteInactive")]
        public bool DeleteInactive { get; set; }
    }
}