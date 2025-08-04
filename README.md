# 📘 School Management System – TimeTable Scheduling

## 🧑‍💻 Author
**Adetogun Samuel Abidemi**

---

## 📌 Task Description

**Task 4 – Stage 4 (Beginner Level)**  
**Date Assigned:** July 19  
**Status:** ✅ Completed  
**Points:** 100  

Design and implement a simple **School Management System** using C# and .NET. The core requirements include:

- Designing an **ERD** to represent system entities and relationships.
- Creating C# **classes** based on the ERD.
- Using a **console application** to simulate real-time data interaction (admins, teachers, students).
- Testing the system through meaningful **data input/output**.
- Storing both the **ERD diagram** and **codebase** in a single Google Drive folder.

---

## 🧠 Features Implemented

### ✅ Functional Requirements
1. **Admins** can assign subjects to teachers and classes for timetable generation.
2. **Teachers** can view their personalized class timetables.
3. **Students** can view their class timetables to identify when and where classes hold.

---

## 📦 Project Structure

The system models the following core entities:

| Entity           | Description                                               |
|------------------|-----------------------------------------------------------|
| `Admin`          | Manages timetable setup and subject assignments           |
| `Teacher`        | Assigned to teach specific subjects in designated classes |
| `Student`        | Linked to a specific classroom and views timetable        |
| `Subject`        | Represents the topic of study                             |
| `ClassRoom`      | Represents student learning groups                        |
| `Department`     | Academic departments (Science, Arts, Commerce)            |
| `Period`         | Defines class durations/times                             |
| `TimeTableEntry` | Binds all the above for scheduling purposes               |

### 📂 Namespaces
- `TimeTableScheduling.Entities` – Houses entity classes.
- `TimeTableScheduling.Enums` – Contains enum types like `DaysOfTheWeek`, `Role`, etc.

---

## 🛠️ Technologies Used

- **Language**: C#  
- **Platform**: .NET Console Application  
- **Diagram Tool**: [draw.io](https://draw.io) (for ERD creation)

---

## 🧪 Sample Timetable Output

### Teacher Timetable (Gideon)
Day: Monday, Period: (08:00:00-09:00:00), Subject: Mathematics, Class: SS1A, Teacher: Gideon Edoghotu
Day: Tuesday, Period: (09:00:00-10:00:00), Subject: Physics, Class: SS1B, Teacher: Gideon Edoghotu


### Student Timetable (Samuel)

---

## 🗂️ Folder Contents

- `/SchoolManagementSystem/`  
  ├── `Entities/` – C# classes (e.g., Teacher.cs, Subject.cs, etc.)  
  ├── `Enums/` – Enum definitions  
  ├── `Program.cs` – Console testing logic  
  └── `ERD.drawio` – Visual representation of entity relationships

> **Note:** All files (code + diagram) are stored in a **single Google Drive folder** as instructed.

---

## 👨‍🎓 Learning Outcomes

- Practiced **object-oriented programming** (OOP) in C#.
- Gained experience with **entity modeling** via ERD.
- Improved understanding of **class relationships**, data mapping, and role-based access.
- Simulated **real-world scenarios** in a console environment.

---

## ✅ How to Run

1. Open the solution in Visual Studio or any compatible IDE.
2. Build and run the project.
3. The console will display timetables for teachers and students based on hardcoded input data.

---

## 📸 ERD Preview

*(Make sure the ERD is clearly shown in your draw.io file and saved as `ERD.drawio` or exported as `ERD.png`)*

---

## 🙌 Acknowledgements

Special thanks to **Gideon Edoghotu** for task creation and grading guidelines.
