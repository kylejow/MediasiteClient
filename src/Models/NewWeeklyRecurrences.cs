using System;
using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    public class NewWeeklyRecurrences
    {
        [JsonPropertyName("RecordDuration")]
        public Int32 RecordDuration { get; set; }
        [JsonPropertyName("StartRecordDateTime")]
        public DateTime StartRecordDateTime { get; set; }
        [JsonPropertyName("EndRecordDateTime")]
        public DateTime EndRecordDateTime { get; set; }
        [JsonPropertyName("RecurrencePattern")]
        public string RecurrencePattern { get; set; }
        [JsonPropertyName("RecurrenceFrequency")]
        public Int32 RecurrenceFrequency { get; set; }
        [JsonPropertyName("WeekDayOnly")]
        public bool WeekDayOnly { get; set; }
        [JsonPropertyName("DaysOfTheWeek")]
        public string DaysOfTheWeek { get; set; }
    }
}