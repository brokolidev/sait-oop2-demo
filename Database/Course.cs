using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }


        // basic constroctor
        public Course()
        {
        }

        public override string ToString()
        {
            return $"Coures ID : {CourseId}\n" +
                $"Name : {Name}\n" +
                $"Credits : {Credits}\n";
        }


    }
}
