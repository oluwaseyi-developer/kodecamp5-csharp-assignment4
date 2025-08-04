using System.Collections.ObjectModel;

namespace TimeTableScheduling.Entities
{
    public class Teacher : User
    {
        public List<SubjectAssignment> SubjectAssignments { get; set; } = new();
    }
}
