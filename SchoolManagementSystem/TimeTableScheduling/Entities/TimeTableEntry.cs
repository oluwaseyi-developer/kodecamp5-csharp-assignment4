using TimeTableScheduling.Enums;

namespace TimeTableScheduling.Entities
{
    public class TimeTableEntry
    {
        public int TimeTableEntryId { get; set; }
        public DaysOfTheWeek Day { get; set; }

        public int PeriodId { get; set; }
        public Period Period { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public override string ToString()
        {
            return $"Day: {Day}, Period: ({Period.StartTime}-{Period.EndTime}), Subject: {Subject.Name}, Class: {ClassRoom.Name}, Teacher: {Teacher.FirstName} {Teacher.LastName}";
        }

    }
}
