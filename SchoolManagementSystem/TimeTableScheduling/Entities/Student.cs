namespace TimeTableScheduling.Entities
{
    public class Student : User
    {
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
