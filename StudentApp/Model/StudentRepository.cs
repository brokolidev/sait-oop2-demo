using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    public static class StudentRepository
    {
        public static List<Student> students = new List<Student>() {
            new Student(1, "Matt", "1234", "matt@gmail.com", "1234-1234-1243"),
            new Student(2, "Josh", "1234", "josh@gmail.com", "1234-1234-1243"),
            new Student(3, "Joe", "1234", "joe@gmail.com", "1234-1234-1243"),
            new Student(4, "Ted", "1234", "ted@gmail.com", "1234-1234-1243"),
            new Student(5, "Jason", "1234", "jason@gmail.com", "1234-1234-1243"),
            new Student(6, "Blanco", "1234", "blanco@gmail.com", "1234-1234-1243"),
        };

        public static List<Student> GetAllStudents()
        {
            return students;
        }

        public static Student? GetStudentById(int studentId)
        {
            var student = students.FirstOrDefault(x => x.StudentId == studentId);

            if(student != null)
            {
                return new Student(student.StudentId, student.Name, student.Address, student.Email, student.Phone);
            }

            return null;
        }

        public static void UpdateStudentDetails(int studentId, Student student)
        {
            if(studentId != student.StudentId)
            {
                return;
            }

            var studentUpdate = students.FirstOrDefault(
               x => x.StudentId == studentId);
            if (studentUpdate != null)
            {
                studentUpdate.Name = student.Name;
                studentUpdate.Address = student.Address;
                studentUpdate.Email = student.Email;
                studentUpdate.Phone = student.Phone;
            }
        }

        public static List<Student> SearchforStudents(string filterText)
        {
            // create function for searching students
            var studentsFound = students.Where(x => !string.IsNullOrWhiteSpace(x.Name) && 
                x.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)).ToList();

            if(studentsFound== null || studentsFound.Count == 0)
            {
                studentsFound = students.Where(x => !string.IsNullOrWhiteSpace(x.Email) &&
                x.Email.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (studentsFound == null || studentsFound.Count == 0)
            {
                studentsFound = students.Where(x => !string.IsNullOrWhiteSpace(x.Address) &&
                x.Address.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return studentsFound;
        }
    }
}
