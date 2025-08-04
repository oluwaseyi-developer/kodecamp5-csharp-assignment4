namespace TimeTableScheduling.Entities
{
    public class SubjectAssignment
    {
        public int SubjectAssignmentId { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
