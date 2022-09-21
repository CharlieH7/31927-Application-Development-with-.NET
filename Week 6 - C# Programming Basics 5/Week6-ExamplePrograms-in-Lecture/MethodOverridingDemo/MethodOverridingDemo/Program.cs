using System;

namespace Week6ClassProgram
{
    class Shape // Base Class
    {
        // Virtual method defined
         public virtual double Area()
        {
            Console.WriteLine("I am from Shape, I am not doing anything!");
            return 0.0;
        }
    }
    // Drived class Circle from Shapes
    class Circle : Shape
    {
        double radius;
        const double pi = 3.124;
        // Circle Constructor
        public Circle(double rad)
        {
            radius = rad;
        }
        //overriding the area() method from the base class
        public override double Area()
        {
            return (pi * radius * radius);
        }
    } // Derived Class

    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            // Create an object of the Shape (base) class and call area method
            Shape s1 = new Shape();
            s1.Area();

            // Create an object of the Circle (base) class and call area method
            Circle c1 = new Circle(4.0);
            Console.WriteLine("Area of the Circle is: {0}", c1.Area());
            
            Console.ReadKey();
        }
    }
}
