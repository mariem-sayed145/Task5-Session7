using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Airplane : IMoveable, IFlyable
    {
        public void MoveForward()
        {
            Console.WriteLine("Airplane moves forward in the air.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Airplane moves backward in the air.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplane moves up in the air.");
        }

        public void MoveDown()
        {
            Console.WriteLine("Airplane moves down in the air.");
        }
    }
}
