using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(string message): base(message) 
        {
            Console.WriteLine(message);
        }

        public InvalidRadiusException(string message, Circle circle) : base(message)
        {
            Console.WriteLine($"{message} circle : {circle}");
        }
    }
}
