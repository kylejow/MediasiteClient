using System;

namespace MediasiteUtil.Models
{
    public class Recurrences
    {
        public Int32 Id { get; set; }
        public string MediasiteId { get; set; }
        public Int32 RecordDuration { get; set; }
        public DateTime StartRecordDateTime { get; set; }
        public DateTime EndRecordDateTime { get; set; }
        public string RecurrencePattern { get; set; }
        public DateTime NextScheduleTime { get; set; }
        public Int32 RecurrencePatternType { get; set; }
        public Int32 RecurrenceFrequency { get; set; }
        public bool WeekDayOnly { get; set; }
        public string DaysOfTheWeek { get; set; }
        public string WeekOfTheMonth { get; set; }
        public Int32 DayOfTheMonth { get; set; }
        public string MonthOfTheYear { get; set; }
    }
}