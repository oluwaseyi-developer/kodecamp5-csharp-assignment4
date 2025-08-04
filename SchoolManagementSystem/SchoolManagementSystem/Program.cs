using TimeTableScheduling.Entities;
using TimeTableScheduling.Enums;


/*
 *****************School Management System (TimeTable Scheduling)*****************
 
 1. Admin can assign subjects to teachers and classes so that they can generate timetables.
 2. Teachers Can view their class timetable so that they can prepare for lessons.
 3. Student Can	View their timetable so that they can know when and where their classes take place.

 */


// Creation of Departments
Department adminDepartment = new Department
{
    DepartmentId = 1,
    Name = "Administrative",
    Description = "Handles administrative tasks and operations."
};

Department scienceDepartment = new Department
{
    DepartmentId = 2,
    Name = "Science",
    Description = "Responsible for science subjects and related activities."
};

Department artsDepartment = new Department
{
    DepartmentId = 3,
    Name = "Arts",
    Description = "Responsible for arts subjects and related activities."
};

Department commerceDepartment = new Department
{
    DepartmentId = 4,
    Name = "Commerce",
    Description = "Responsible for commerce subjects and related activities."
};



// Creation of Admin
Admin admin = new Admin
{
    Id = Guid.NewGuid(),
    FirstName = "ImoleAyo",
    LastName = "Bisiolu",
    Email = "I'mBisi@gmail.com",
    PhoneNumber = "123-456-7890",
    Role = Role.Admin,
    Department = adminDepartment,
};



// Creation of Subjects
Subject math = new Subject { SubjectId = 1, Name = "Mathematics", Description = "Basic Math", Department = scienceDepartment };
Subject physics = new Subject { SubjectId = 2, Name = "Physics", Description = "Basic Physics", Department = scienceDepartment };

Subject history = new Subject { SubjectId = 3, Name = "History", Description = "World History", Department = artsDepartment };
Subject literature = new Subject { SubjectId = 4, Name = "Literature", Description = "English Literature", Department = artsDepartment };

Subject accounting = new Subject { SubjectId = 5, Name = "Accounting", Description = "Basic Accounting", Department = commerceDepartment };
Subject economics = new Subject { SubjectId = 6, Name = "Economics", Description = "Basic Economics", Department = commerceDepartment };



// Creation of ClassRooms
ClassRoom ss1a = new ClassRoom { ClassRoomId = 1, Name = "SS1A", Level = "Senior Secondary 1", Department = scienceDepartment };
ClassRoom ss1b = new ClassRoom { ClassRoomId = 2, Name = "SS1B", Level = "Senior Secondary 1", Department = scienceDepartment };
ClassRoom ss2a = new ClassRoom { ClassRoomId = 3, Name = "SS2A", Level = "Senior Secondary 2", Department = artsDepartment };
ClassRoom ss2b = new ClassRoom { ClassRoomId = 4, Name = "SS2B", Level = "Senior Secondary 2", Department = commerceDepartment };



// Creation of Periods
Period period1 = new Period { PeriodId = 1, StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(9, 0, 0) };
Period period2 = new Period { PeriodId = 2, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(10, 0, 0) };
Period period3 = new Period { PeriodId = 3, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(11, 0, 0) };
Period period4 = new Period { PeriodId = 4, StartTime = new TimeSpan(11, 0, 0), EndTime = new TimeSpan(12, 0, 0) };
Period period5 = new Period { PeriodId = 5, StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(13, 0, 0) };
Period period6 = new Period { PeriodId = 6, StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(14, 0, 0) };



// Creation of Teachers
Teacher gideon = new Teacher
{
    Id = Guid.NewGuid(),
    FirstName = "Gideon",
    LastName = "Edoghotu",
    Email = "GideonEdo@gmail.com",
    PhoneNumber = "08123456789",
    Role = Role.Teacher,
    Department = scienceDepartment,
};

Teacher grace = new Teacher
{
    Id = Guid.NewGuid(),
    FirstName = "Grace",
    LastName = "Ogunleye",
    Email = "oguns@gmail.com",
    PhoneNumber = "08123456780",
    Role = Role.Teacher,
    Department = artsDepartment,
};

Teacher chuka = new Teacher
{
    Id = Guid.NewGuid(),
    FirstName = "Chuka",
    LastName = "Okeke",
    Email = "chukaokeke@yahoomail.com",
    PhoneNumber = "08123456781",
    Role = Role.Teacher,
    Department = commerceDepartment,
};



// Assigning Subjects to Teachers
gideon.SubjectAssignments.Add(
    new SubjectAssignment
    {
        SubjectAssignmentId = 1,
        Subject = math,
        TeacherId = gideon.Id,
        Teacher = gideon
    });

gideon.SubjectAssignments.Add(
    new SubjectAssignment
    {
        SubjectAssignmentId = 2,
        Subject = physics,
        TeacherId = gideon.Id,
        Teacher = gideon
    });

grace.SubjectAssignments.Add(
    new SubjectAssignment
    {
        SubjectAssignmentId = 3,
        Subject = history,
        TeacherId = grace.Id,
        Teacher = grace
    });

grace.SubjectAssignments.Add(
    new SubjectAssignment
    {
        SubjectAssignmentId = 4,
        Subject = history,
        TeacherId = grace.Id,
        Teacher = grace
    });

chuka.SubjectAssignments.Add(
    new SubjectAssignment
    {
        SubjectAssignmentId = 5,
        Subject = accounting,
        TeacherId = chuka.Id,
        Teacher = chuka
    });

chuka.SubjectAssignments.Add(
    new SubjectAssignment
    {
        SubjectAssignmentId = 6,
        Subject = economics,
        TeacherId= chuka.Id,
        Teacher = chuka
    });



// Time Table Entry
TimeTableEntry entry1 = new TimeTableEntry
{
    TimeTableEntryId = 1,
    Day = DaysOfTheWeek.Monday,
    Period = period1,
    Subject = math,
    Teacher = gideon,
    ClassRoom =ss1a,
};

TimeTableEntry entry2 = new TimeTableEntry
{
    TimeTableEntryId = 2,
    Day = DaysOfTheWeek.Tuesday,
    Period = period2,
    Subject = physics,
    Teacher = gideon,
    ClassRoom = ss1b,
};

TimeTableEntry entry3 = new TimeTableEntry
{
    TimeTableEntryId = 3,
    Day = DaysOfTheWeek.Wednesday,
    Period = period3,
    Subject = literature,
    Teacher = grace,
    ClassRoom = ss2a,
};

TimeTableEntry entry4 = new TimeTableEntry
{
    TimeTableEntryId = 4,
    Day = DaysOfTheWeek.Thursday,
    Period = period4,
    Subject = history,
    Teacher = grace,
    ClassRoom = ss2a,
};

TimeTableEntry entry5 = new TimeTableEntry
{
    TimeTableEntryId = 5,
    Day = DaysOfTheWeek.Friday,
    Period = period5,
    Subject = accounting,
    Teacher = chuka,
    ClassRoom = ss2b,
};

TimeTableEntry entry6 = new TimeTableEntry
{
    TimeTableEntryId = 6,
    Day = DaysOfTheWeek.Monday,
    Period = period6,
    Subject = economics,
    Teacher = chuka,
    ClassRoom = ss2b,
};



// Creation of Student
Student sam = new Student { Id = Guid.NewGuid(), FirstName = "Samuel", LastName = "Adetogun", Email = "Olu@gmail.com", Role = Role.Student, ClassRoom = ss1a};
Student gift = new Student { Id = Guid.NewGuid(), FirstName = "Gift", LastName = "Edeh", Email = "Gift@gmail.com", Role = Role.Student, ClassRoom = ss1b };
Student Mary = new Student { Id = Guid.NewGuid(), FirstName = "Marian", LastName = "Adatai", Email = "Marian@yahoomail.com", Role = Role.Student, ClassRoom = ss2a};
Student biola = new Student { Id = Guid.NewGuid(), FirstName = "Abiola", LastName = "Abdulsalam", Email = "AbdulSalamAbiola@gmail.com", Role = Role.Student, ClassRoom = ss2b};



Console.WriteLine("TEACHER TIMETABLE FOR GIDEON:");
List<TimeTableEntry> allEntries = new List<TimeTableEntry> { entry1, entry2, entry3, entry4, entry5, entry6 };

foreach (var entry in allEntries.Where(e => e.Teacher.Id == gideon.Id))
{
    Console.WriteLine(entry);
}


Console.WriteLine("\nSTUDENT TIMETABLE FOR SAMUEL:");
foreach (var entry in allEntries.Where(e => e.ClassRoom.ClassRoomId == sam.ClassRoom.ClassRoomId))
{
    Console.WriteLine(entry);
}
