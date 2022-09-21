using System;


namespace Week6ClassProgram
{
    class Person // Base Class
    {
        // private data member
        private string name;

        // protected member method
        protected void ChangeName(string newName)
        {
            name = newName;
        }
        // public accessor
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Customer: Person // Derived Class
    {
        // Cannot access base.name
        public Customer()
        {
            this.Name = "Hello World";
        }
        public void ChangeCustomerName(string newName)
        {
            base.ChangeName(newName);
        }
        // Can access base.ChangeName
        // Can access base.name
    }
    class VisibilityDemo
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            // Cannot access c1.name
            // Cannot access c1.ChangeName
            // Can access c1.Name
            Console.WriteLine("The name of the Customer is: {0} ", c1.Name);
            c1.ChangeCustomerName("Nabin");
            Console.WriteLine("Customer Name updated to : {0} ", c1.Name);

            Console.ReadKey();
        }
    }
}



