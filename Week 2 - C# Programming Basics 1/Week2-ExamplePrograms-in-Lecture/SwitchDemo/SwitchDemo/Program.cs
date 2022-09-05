using System;
/*
Program to find final result based on grade obtained 
by a student, based on the following criteria

    Grade = A or B : High Distinction
    Grade = C : Distinction
    Grade = D : Pass
    Grade = F : Fail
 
*/
namespace Week2Programs
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            char grade = 'C';

            //Find the grade based on the GPA
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Grade: High Distinction");
                    break;
                case 'B':
                    Console.WriteLine("Grade: High Distinction");
                    break;
                case 'C':
                    Console.WriteLine("Grade: Distinction");
                    break;
                case 'D':
                    Console.WriteLine("Grade: Pass");
                    break;
                default:
                    Console.WriteLine("Grade: Fail");
                    break;
            }
            Console.Read();
        }
    }
}


