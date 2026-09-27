using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Ship : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Ship moves forward on the sea.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Ship moves backward on the sea.");
        }
    }
}
