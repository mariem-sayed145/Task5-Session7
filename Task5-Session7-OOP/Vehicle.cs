using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Vehicle : IVehicle
    {
        public virtual void MoveForward()
        {
            Console.WriteLine("Vehicle moves forward.");
        }

        public virtual void MoveBackward()
        {
            Console.WriteLine("Vehicle moves backward.");
        }

        public virtual void MoveUp()
        {
            Console.WriteLine("Vehicle moves up.");
        }

        public virtual void MoveDown()
        {
            Console.WriteLine("Vehicle moves down.");
        }
    }
}
