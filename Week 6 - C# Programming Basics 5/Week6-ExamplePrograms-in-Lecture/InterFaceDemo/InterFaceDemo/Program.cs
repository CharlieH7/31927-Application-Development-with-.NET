using System;

namespace Week5ClassProgram
{

    public interface IShape // Declare Interface
    {
        double Area();
        double Perimeter();
        
    }
    // Implement the Interface Shapes
    public class Rectangle : IShape 
    {
        double lenght, breadth;
        // rectangle Constructor
        public Rectangle(double lenght, double breadth)
        {
            this.lenght = lenght;
            this.breadth = breadth;
        }
        //Implement the Area()
        public double Area()
        {
            return (lenght*breadth);
        }
        //Implement the Perimeter()
        public double Perimeter()
        {
            return (2 * (lenght + breadth));
        }
        // Display method of shown the rectangle dimension
        public void Display()
        {
            Console.WriteLine("Lenght: {0}, Breadth: {1}", lenght, breadth);
        }
    }   

    class InterFaceDemo
    {
       static void Main(string[] args)
        {
            // Create a Rectangle object
            Rectangle r1 = new Rectangle(10, 20);
            r1.Display(); // Display the dimension
            Console.WriteLine("Area: {0}", r1.Area()); // Display the Area
            Console.WriteLine("Perimeter: {0}", r1.Perimeter()); // Display the Perimenter

            Console.ReadKey();
        }
    }
}


