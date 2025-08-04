namespace TimeTableScheduling.Entities
{
    public class Period
    {
        public int PeriodId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
