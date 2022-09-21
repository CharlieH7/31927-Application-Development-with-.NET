using System;


namespace Week6ClassProgram
{
    class Shape // Base Class
    {
        // Base class method defined
        public void Area()
        {
            Console.WriteLine("I am from Shape, I am not doing anything!");
        }
    }
    // Drived class Circle from Shapes
    class Circle : Shape // Derived class
    {
        double radius;
        const double pi = 3.124;
        // Circle Constructor
        public Circle(double rad)
        {
            radius = rad;
        }
        //Hiding area() method from the base class
        public new double Area()
        {
            return (pi * radius * radius);
        }
    }

    class MethodHidingDemo
    {
        static void Main(string[] args)
        {
            // Create an object of the Shape (base) class and call area method
            Shape s1 = new Shape();
            s1.Area();

            // Base class object can refer to derived class objects as well
            Shape s2 = new Circle(10);
            s1.Area();

            // Create an object of the Circle (base) class and call area method
            Circle c1 = new Circle(4.0);
            Console.WriteLine("Area of the Circle is: {0}", c1.Area());

            Console.ReadKey();
        }
    }
}
