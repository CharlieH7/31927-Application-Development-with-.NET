using System;
using System.Linq;
using System.Runtime.CompilerServices;

/*
Write a program to Create Student a Result management System with the following specifications:
1. There are two classes, Person (Abstract base class), Student(derived class from person)
2. There is one Interface for Generating the Results

Please refer to the instructions document for the class diagrams and Instructions.

    */

namespace Week6LabProgram
{
    // Create an Abstract class person
    public abstract class Person
    {
        //Write code to Declare data members/properties here
        public string personName { get; set; }
        public string personAddress { get; set; }
        // Write code for Constructor
        public Person(string personName, string personAddress)
        {
            this.personName = personName;
            this.personAddress = personAddress;
        }
    }

    // Write code toCreate an Interface IResults for creating marksheet
    public interface IResults
    {
        // Declare the methods to be inplemented in the class

        // Write code for Method to get the marks for 5 subjects
        void GetMarks();
        // Write code for Method to calculate the final grade (Pass/Fail)
        string CalculateResult();
        //Write code for Method to Display the MarkSheet
        void DisplayResult();
    }

    // Write code to Create the Student class by inheriting the Person Class and implementing the IResults interface
    public class Student : Person, IResults
    {
        // Write code for Data members specific to a Student
        private string standard;
        private string roll;
        private double[] marks;

        // Write code for Student Constructor, which also initializes the base class properties
        public Student(string name, string address, string standard, string roll) : base(name, address)
        {
            // Write code here
            this.standard = standard;
            this.roll = roll;
            this.marks = new double[5];
        }

        // Implement the GetMarks() method
        public void GetMarks()
        {
            // Accept the marks for 5 subjects and store it in an array
            for (int loopVar = 0; loopVar < 5; loopVar++)
            {
                // Write code to to accept marks for 5 subjects
                Console.Write("Enter Marks for Subject-{0}: ", loopVar + 1);
                string userInput = Console.ReadLine();
                this.marks[loopVar] = Convert.ToDouble(userInput);
            }
        }
        // Implement the CalculateResult() method
        public string CalculateResult()
        {
            // Calculate the sum of the marks obtained// Hint: mark.Sum()
            double totalMarksObtained = this.marks.Sum();
            // Find the grade and return it
            // Averge <40, grade = Fail
            // Else Pass
            if ((totalMarksObtained / 5) < 40)
                return "Fail";
            else
                return "Pass";
        }

        // Implement the DisplayResult() method to generate the Marksheet
        public void DisplayResult()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\t\tMark Sheet");
            Console.WriteLine("---------------------------------------------");
            // Write code to to display the marksheet as per format given in test case
            Console.WriteLine("Name:{0}", this.personName);
            Console.WriteLine("Class:{0}", this.standard);
            Console.WriteLine("Roll:{0}", this.roll);
            Console.WriteLine("Address:{0}", this.personAddress);
            Console.WriteLine("\nMarks Obtained:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject-{0}: {1}", i + 1, this.marks[i]);
            }
            Console.WriteLine("\nAverage Marks: {0}", this.marks.Average());
            Console.WriteLine("Final Grade: {0}", this.CalculateResult());
            Console.WriteLine("---------------------------------------------");

        }
        class Week6Program1
        {
            static void Main(string[] args)
            {
                // Write code to Create a Student object
                Student s1 = new Student("Charlie Huang", "30 Ivory Street", "X", "1004"); ;
                // Write code to Get the student's marks
                s1.GetMarks();
                // Write code to Generate the Marks Sheet
                s1.DisplayResult();
                // Accept a key press from user.
                Console.ReadKey();
            }
        }
    }
}

/* Test Case:

Enter Marks for Subject-1:56
Enter Marks for Subject-2:42
Enter Marks for Subject-3:89
Enter Marks for Subject-4:69
Enter Marks for Subject-5:95

---------------------------------------------
                Mark Sheet
---------------------------------------------
Name: George Woolsworth
Class: V
Roll: 1004
Address: Ultimo, Sydney 2007, Australia

Marks Obtained:
Subject-0: 57
Subject-1: 43
Subject-2: 90
Subject-3: 70
Subject-4: 96

Average Marks: 70.2
Final Grade: Pass
---------------------------------------------

    
    */
