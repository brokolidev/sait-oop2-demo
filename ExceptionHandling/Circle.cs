using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Circle
    {
        private double _radius;
        public double Radius
        {
            get => _radius;

            set
            {
                if (value > 0)
                {
                    this._radius = value;
                }
                else if (value == 0)
                {
                    throw new InvalidRadiusException("Radius cannot be zero.", this);
                }
                else
                {
                    throw new InvalidRadiusException("Radius cannot be negative.");
                }
            }
        }
        
        public Circle()
        {
        }

        public override string ToString()
        {
            return $"Radius of this circle : {_radius}";
        }
    }
}
