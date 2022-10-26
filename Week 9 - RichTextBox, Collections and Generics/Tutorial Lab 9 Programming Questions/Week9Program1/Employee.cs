using System;
using Week9Program1;

namespace Week9Program1
{
    class Employee : IComparable<Employee>
    {
        // Write code for the Properties of an Employee
        // Name (First and last name), ID#, hourly rate and total working hours per week
        string employeeFirstName { get; set; }
        string employeeLastName { get; set; }
        double hourlyRate { get; set; }
        double workHours { get; set; }
        int employeeID { get; set; }

        // Write code for the Empolyee Constructor
        public Employee()
        {
            employeeFirstName = "";
            employeeLastName = "";
            hourlyRate = 0.0;
            workHours = 0.0;
            employeeID = 0;
        }

        // Write code for the Method to recieve a single line from the emp.txt file as string
        // and extract individual fields from the line by spltting the line using ','
        public void LoadEmployee(string fileLine)
        {
            // Split the comma seperated string into fields 
            string[] fields = fileLine.Split(',');
                       
            // Assign values to respective properties/ members
            employeeLastName = fields[0];
            employeeFirstName = fields[1];
            hourlyRate = Convert.ToDouble(fields[2]);
            employeeID = Convert.ToInt32(fields[3]);
            workHours = Convert.ToDouble(fields[4]);
        }

        // Method to calculate the weekly salary of an Employee
        public double GetWeeklySal()
        {
            return (workHours * hourlyRate);
        }

        // Overide the ToString() method to display the employee details
        public override string ToString()
        {
            return employeeFirstName + " " + employeeLastName + " ID#:" + employeeID + " Weekly Income:" + GetWeeklySal();
        }

        // Write code for the Implemention of the CompareTo method 
        public int CompareTo(Employee other)
        {
            if (employeeID < other.employeeID)
            {
                return -1;
            }
            else if (employeeID == other.employeeID)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }
}
