using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Session7_OOP
{
    public class Program
    {


        public static void ProcessPerson(Person person)
        {
            person.Greet();

            person.Display();

        }
        static void Main(string[] args)
        {
            // 1 - Shape class 
            Shape shape = new Shape(3, 5);
            Console.WriteLine(shape.Area());
            Console.WriteLine(shape.ToString());
            Console.WriteLine("--------------------------------------------------------------------------------");

            // 2 - Cube 
            Cube cube = new Cube(5, 7, 9);
            Console.WriteLine(cube.Area());
            cube.Print(); 
            Console.WriteLine("--------------------------------------------------------------------------------");

            // 3 - Q3

            // shape2 is a Shape reference pointing to a Shape object.
            // So Shape.Area() is called and calculates Width * Height = 2 * 3 = 6.
            Shape shape2 = new Shape(2, 3);
            Console.WriteLine(shape.Area());

            // cube is a Cube reference pointing to a Cube object.
            // Cube has its own Area() method using 'new', so Cube.Area() is called.
            // It calculates Width * Height * Depth = 2 * 3 * 4 = 24.
            Cube cube2 = new Cube(2, 3, 4);
            Console.WriteLine(cube.Area());


            // shapeRef is a Shape reference, but it points to a Cube object.
            // Because Cube.Area() uses 'new' (method hiding), the method is selected
            // based on the reference type (Shape), not the actual object type (Cube).
            // Therefore, Shape.Area() is called = 2 * 3 = 6.
            // This is called Early/Static Binding.
            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine(shapeRef.Area());

            Console.WriteLine("--------------------------------------------------------------------------------");


            // 4 - Q4

            object obj = new Cube(1, 2, 3);
            // The reference type is object, but the actual object is Cube.

            Console.WriteLine(obj.ToString());
            // ToString() is virtual in the object class.
            // Shape overrides ToString(), so the overridden Shape.ToString() runs at runtime.
            // This demonstrates late/dynamic binding.
            // Output: (Width = 1, Height = 2) 

            Console.WriteLine("--------------------------------------------------------------------------------");

            // 5 - Person 

            Person person = new Person() ;
            person.ID = 122;
            person.Name = "Ahmed";
            person.Age = 23;

            person.Greet();
            person.Display();

            Console.WriteLine("--------------------------------------------------------------------------------");


            // 6 - Doctor and Engineer 

            Doctor doctor = new Doctor();
            doctor.ID = 99;
            doctor.Name = "Marwa";
            doctor.Age = 34;
            doctor.Specialty = "vet";
            doctor.Greet();
            doctor.Display();


            Engineer engineer = new Engineer();
            engineer.ID = 145;
            engineer.Name = "Mariam";
            engineer.Age = 20;
            engineer.Field = "Computer Scince";
            engineer.YearsOfExperience = 3; 
            engineer.Greet();
            engineer.Display();

            Console.WriteLine("--------------------------------------------------------------------------------");


            // 7 - processPerson 
            Person doctor2 = new Doctor
            {
                ID = 1,
                Name = "Mariam",
                Age = 20,
                Specialty = "Cardiology"
            };

            ProcessPerson(doctor2);

            Person engineer2 = new Engineer
            {
                ID = 2,
                Name = "Ahmed",
                Age = 25,
                Field = "Software Engineering",
                YearsOfExperience = 3
            };

            ProcessPerson(engineer);

            // Greet() → Compile-time binding because it is non-virtual and hidden using new.
            // The reference type is Person, so Person.Greet() is called.

            // Display() → Runtime binding because it is virtual and overridden.
            // The actual object type is used, so the derived Display() is called.

            Console.WriteLine("--------------------------------------------------------------------------------");

            // 8 -  Q8 

            // If we remove virtual from Person.Display(),
            // Doctor.Display() and Engineer.Display() cannot use override.
            // The compiler gives an error because Display() in the base class
            // is not virtual, abstract, or override.
            // This means the derived classes cannot override this method
            // and polymorphism through Display() will not work.


            //  Part 2 --> Interface
            Car car = new Car();
            car.MoveForward();
            car.MoveBackward();

            Console.WriteLine("--------------------------------------------------------------------------------");

            Ship ship = new Ship();

            ship.MoveForward();
            ship.MoveBackward();

            Console.WriteLine("--------------------------------------------------------------------------------");

            Airplane airplane = new Airplane();

            airplane.MoveForward();
            airplane.MoveBackward();
            airplane.MoveUp();
            airplane.MoveDown();

            Console.WriteLine("--------------------------------------------------------------------------------");

            IMoveable carRef = new Car();

            carRef.MoveForward();
            carRef.MoveBackward();

            Console.WriteLine("--------------------------------------------------------------------------------");

            IMoveable planeRef = new Airplane();

            planeRef.MoveForward();
            planeRef.MoveBackward();

            Console.WriteLine("--------------------------------------------------------------------------------");

            // 12 -  Can you call MoveUp() on planeRef? Why or why not? What reference type would you need? 

            // planeRef.MoveUp();
            // Cannot call MoveUp() because the reference type is IMoveable.
            // IMoveable only contains MoveForward() and MoveBackward().
            // To call MoveUp(), we need an IFlyable reference or an Airplane reference.

            // 13 - What is the benefit of an interface inheriting other interfaces

            // It allows one interface to combine the contracts of multiple interfaces,
            // so implementing IVehicle requires implementing all inherited members.

            // 14 -

            // MoveForward() is not accessible directly through a Ship object.
            // It can only be called through an IMoveable reference. 
            // Explicit interface implementation can only be accessed
            // through an interface reference.

            IMoveable shipRef = new Ship();
            shipRef.MoveForward();


            // Q15. Comparison between Static Binding and Dynamic Binding:

            // Feature                         Static Binding (new)       Dynamic Binding (override)

            // Keyword in base                None                       virtual
            // Keyword in derived             new                        override
            // Resolved at                    Compile time               Runtime
            // Behavior via base reference    Calls base method          Calls derived method 


            // 16 - 
            // override replaces the base method, so the base method must be virtual.
            // new only hides the base method, so it does not require virtual.


        }
    }
}
