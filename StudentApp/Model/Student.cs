using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    public class Student
    {

        public Student(int studentId, string name, string address, string email, string phone)
        {
            StudentId = studentId;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
