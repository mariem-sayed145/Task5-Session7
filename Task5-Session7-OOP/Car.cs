using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Car : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Car moves forward on the ground.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car moves backward on the ground.");
        }
    }
}
