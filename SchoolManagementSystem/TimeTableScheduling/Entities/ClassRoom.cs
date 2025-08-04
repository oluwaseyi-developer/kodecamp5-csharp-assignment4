namespace TimeTableScheduling.Entities
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Teacher ClassTeacher { get; set; } 
    }
}
