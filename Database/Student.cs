using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Student()
        {
            
        }

        public override string ToString()
        {
            return $"{Id} / {Name} / {Email} / {Address}";
        }
    }
}
