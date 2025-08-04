using TimeTableScheduling.Enums;

namespace TimeTableScheduling.Entities
{
    public class TimeTable
    {
        public int TimeTableId { get; set; }
        public OwnerType OwnerType { get; set; }
        public Guid ownerId { get; set; }
        public List<TimeTableEntry> Entries { get; set; } = new();
    }
}
