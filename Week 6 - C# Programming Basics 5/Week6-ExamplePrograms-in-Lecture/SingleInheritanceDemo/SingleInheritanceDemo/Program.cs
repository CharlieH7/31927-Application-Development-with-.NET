using System;
// Program to demonstrate Single inheritance in C#
// Base Class: Person --> Customer: derived class

namespace Week6ClassProgram
{
    class Person // Base Class
    {
        // Private data member
        private string name;
        // Constructor
        public Person(string name)
        {
            this.name = name;
        }
        // Accessors
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    // Class Customer: Derived from Person
    class Customer : Person // Derived class
    {
        // Private data member
        private int customerID;

        // Constructor to initlize the base class property 
        // use base keyword to call base class constructor
        // It also initializes the derived class property
        public Customer(string name, int customerID) : base(name)
        {
            this.customerID = customerID;
        }
        // Accessor
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
    }
    // Class with main()
    class SingleInheritanceDemo
    {
        static void Main(string[] args)
        {
            //Create an object of Customer class
            Customer C1 = new Customer("Nabin", 1005);
            C1.CustomerID = 1001;

            // Display the name and id of the customer
            Console.WriteLine("The customer name is {0}, Customer ID {1}", C1.Name, C1.CustomerID);

            Console.ReadKey();

        }
    }
}
