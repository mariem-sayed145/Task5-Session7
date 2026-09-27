using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Engineer : Person
    {
        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        public override void Display()
        {
            Console.WriteLine(
                $"ID: {ID}, Name: {Name}, Age: {Age}, " +
                $"Field: {Field}, Years of Experience: {YearsOfExperience}"
            );
        }
    } 
}
