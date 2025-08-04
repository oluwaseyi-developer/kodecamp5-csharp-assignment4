using TimeTableScheduling.Enums;

namespace TimeTableScheduling.Entities
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
