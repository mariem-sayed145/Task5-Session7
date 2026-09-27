using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Cube : Shape
    {
        public double Depth { get; set; }

        public Cube(double width, double height, double depth)
            : base(width, height)
        {
            Depth = depth;
        }

        public new double Area()
        {
            return base.Area() * Depth;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Width = {Width}, Height = {Height}, Depth = {Depth}"
            );
        }
    } 
}
