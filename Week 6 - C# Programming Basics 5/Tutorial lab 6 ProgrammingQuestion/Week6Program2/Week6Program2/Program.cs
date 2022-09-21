using System;
/*
Write a program to create a Shape Class and derive two child class, Rectangle and Circle, based 
the specification given in the Tutorial instructions.
 The Base class implementation is provided.
 */
namespace Week6LabProgram
{
    // Base Class Shape
    public class Shape
    {
        // Data members/properties
        public int NumberOfSides { get; set; }

        // Constructor
        public Shape(int NoSides)
        {
            NumberOfSides = NoSides;
        }

        // Virtual method Area() to be overidden by Child class
        public virtual void Area()
        {
            Console.WriteLine("I am from Shape Class");
        }
        // Virtual method Display() to be overidden by Child class
        public virtual void Display()
        {
            Console.WriteLine("The Number of Sides are: {0}", NumberOfSides);
        }
    }

    // Create the Child class Circle derived from Shape
    public class Circle : Shape
    {
        // Write the code for Data member/properties
        private double radius;
        private double areaVal;
        private const double PI = Math.PI;

        // Write the code for Constructor
        public Circle(int noSides, double radius): base(noSides)
        {
           this.radius = radius;
        }

        // Write the code to override the base class Area() method
        public override void Area()
        {
            areaVal = this.radius * this.radius * PI;
        }
        // Write the code to override the base class Display() method
        public override void Display()
        {
            Console.WriteLine("\nThe Number of sides of a Circle is : {0}", base.NumberOfSides);
            Console.WriteLine("The Radius of the Circle is: {0}", this.radius);
            Console.WriteLine("The Area of Circle is : {0}", this.areaVal);
        }
    }

    // Create the child class Rectangle derived from Shape
    public class Rectangle : Shape
    {
        // Write the code for Data member/properties
        private double height;
        private double width;
        private double areaVal;
        
        // Write the code for Constructor
        public Rectangle(int noSides, double height, double width) : base(noSides)
        {
            this.height = height;
            this.width = width;
        }
        // Write the code to override the base class Area() method
        public override void Area()
        {
            areaVal = height * width;
        }
        // Write the code to override the base class Display() method
        public override void Display()
        {
            //  hint: Check the Display method of the Circle class to complete the code.
            Console.WriteLine("\nThe Number of sides of a Rectangle is : {0}", base.NumberOfSides);
            Console.WriteLine("The Height and Width of the Rectangle is: {0}, {1}", this.height, this.width);
            Console.WriteLine("The Area of Rectangle is : {0}", this.areaVal);

        }
    }
    class Week6Program2
    {
        static void Main(string[] args)
        {
            // Create Circle and Rectangle Objects
            Circle C1 = new Circle(1, 4);
            Rectangle R1 = new Rectangle(4, 5, 4);

            // Calculate the area
            C1.Area();
            R1.Area();

            // Display the dimensions and area of Circle and Rectangle
            C1.Display();
            R1.Display();

            Console.ReadKey();
            
        }
    }
}

/*
  Test Case:
    The Number of sides of a Circle is : 1
    The Radius of the Circle is: 4
    The Area of Circle is : 50.272

    The Number of sides of a Rectangle is : 4
    The Length and Breadth of the Rectangle is: 5, 4
    The Area of Rectangle is : 20
  
 */
