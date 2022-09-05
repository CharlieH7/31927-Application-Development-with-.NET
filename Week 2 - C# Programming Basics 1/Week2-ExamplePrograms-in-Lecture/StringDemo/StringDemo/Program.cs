using System;
// Program illustrate String creation and operations

namespace Week2Programs
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            // Create Strings
            string firstName = "Hello";
            string lastName = "World";

            // Demonstration of basic String operations
            //1. Find the lenght of a string
            Console.WriteLine("The lenght of {0} is {1}", firstName, firstName.Length);

            // 2. Compare two Strings
            if (string.Compare(firstName, lastName) == 0)
            {
                Console.WriteLine("{0} and {1} are equal", firstName, lastName);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", firstName, lastName);
            }

            // 3. Concat two string
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine("The string after concatenation is {0}", fullName);

            // 4. Printing full name in upper case
            Console.WriteLine("The upper case version is {0}", fullName.ToUpper());

            // 5. Check if a string is present in another string
            if (fullName.Contains("World"))
            {
                Console.WriteLine("World is present in {0}", fullName);
            }
            Console.Read();
        }
    }
}

