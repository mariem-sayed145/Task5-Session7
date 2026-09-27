using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("I am a Person.");
        }
        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");
        }
    }
}
