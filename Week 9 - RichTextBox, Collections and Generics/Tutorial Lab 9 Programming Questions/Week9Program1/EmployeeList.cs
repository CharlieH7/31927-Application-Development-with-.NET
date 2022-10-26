using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Program1
{
    class EmployeeList
    {
        // Write code for to Create a List to store the information from emp.txt file
        List<Employee> employees;

        // EmployeeList constructor
        public EmployeeList()
        {
            // Create an instance of List<>
            employees = new List<Employee>();
        }

        // Method to process a string which contain a single line for the emp.txt
        // The lfile name is passed as a parameter to the Method
        public void LoadEmployees(string filename)
        {
            // Read the file content using the StreamReader
            StreamReader fileContent = new StreamReader(filename);
            // Create an object of Employee class
            Employee tempEmployee;

            // Read the StremReader till the last line
            while (!fileContent.EndOfStream)
            {
                // At this point there are still employees to be loaded
                tempEmployee = new Employee();
                // Write code to Read each line and from the StreamReader
                string line = fileContent.ReadLine();
                // Write code to Load the employee detail from file to respective fields
                tempEmployee.LoadEmployee(line);
                // Write code to Add the details to the list collection
                employees.Add(tempEmployee);
            }
            // Write code to Close the StreamReader
            fileContent.Close();
        }

        // Method to display the details for all the Employee
        public void PrintEmployees()
        {
            // prints each employee details in the employees list on a seperate line
            foreach (Employee e in employees)
            {
                Console.WriteLine("Employee Details: " + e.ToString());
            }

        }
        //  Write code to Sort the employee details based on the Employee ID
        public void SortEmployees()
        {
            employees.Sort();
        }
    }
}
