using System;
/*
Write a program to create a Generic Stack data structure
which can handle multiple data types. 

Use the class diagram given in the tutorial instruction document as reference.
*/


namespace Week8Program1
{
    // Create the MyGenericStack class
    public class MyGenericStack<T>
    {
        // Write the code for the Properties
        // 1. To Keep track of the number of elements added to the Stack in LIFO (Last In First Out) order
        public int Top { get; set; }
        // 2. an array to store the element in the stack
        public T[] StackElements { get; set; }
        // Write code for the constructor which initializes the stack based on the value of myGenericStackSize, 
        // which should be greater than zero
        public MyGenericStack(int myGenericsStackSize)
        {
            // Write code to Check if the stack size is >0
            if (myGenericsStackSize > 0)
            {
               StackElements = new T[myGenericsStackSize];
            }
            // Write code to Throw an exception 
            else
            {
                throw new ArgumentException("Stack size my be greater than zero");
            }    
        }

        //Write code for the Puch() method to add an element in the stack
        public void Push(T value)
        {
            // Check if the value of top<Size of stack: Stack empty
            if (Top > Length)
            {
                throw new StackOverflowException("Stack is full, cannot push the value");
            }
            // Increment top
            Top++;
            // Add the value into the stack
            StackElements[Top] = value;
        }

        //Write code for the Pop() method which returns the current value at the location indicated by top
        public T Pop()
        {
            // Check if the value of top<0: Stack empty
            if (Top < 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty, cannot pop");
            }
            // Decrement top
            Top--;
            // return the value of top +1: the element being deleted
            T temp = StackElements[Top + 1];
            StackElements[Top + 1] = default(T);
            return temp;
        }

        // Write code for Accessor: returns the size of stack
        public int Length
        {
            get
            {
                return StackElements.Length;
            }
        }

        // Write code for Accessor: returns the actual number of elements in the stack
        public int NoElements
        {
            get
            {
                return Top;
            }
        }
    }


    // Don't modify the code below:
    class Program
    {
        // Initial static double and string arrays with potential values to be inserted into the stacks
        // The values can be user inputs as well
        private static double[] doubleValues = new double[] { 1.2, 3.4, 5.6, 9.2, 4.5 };

        private static string[] stringValues = new string[] { "Paul", "George", "Alan", "Alex", "Martin"};

        // Create a stack of double and string value using the MyGenericStack class
        private static MyGenericStack<double> myDoubleStack;
        private static MyGenericStack<string> myStringStack;

        static void Main(string[] args)
        {
            // Initialize the stacks
            myDoubleStack = new MyGenericStack<double>(6);
            myStringStack = new MyGenericStack<string>(6);

            // Insert values into the respective stacks and 
            // check for exceptions which may occur
            try {
                foreach (double doubleVal in doubleValues)
                {
                    myDoubleStack.Push(doubleVal);
                }
                foreach (string stringVal in stringValues)
                {
                    myStringStack.Push(stringVal);
                }
            }
            catch(StackOverflowException e)
            {
                Console.WriteLine(e.ToString());
            }

            // Display the stack contents by poping the values from each stacks seperately
            try
            {
                int numberOfElement = myDoubleStack.NoElements;
                Console.WriteLine("The Double Stack had the following values:");
                for (int loopVar = 0; loopVar < myDoubleStack.Length; loopVar++)
                {
                    Console.Write("{0} --> ", myDoubleStack.Pop());
                }

                numberOfElement = myStringStack.NoElements;
                Console.WriteLine("\n\nThe String Stack had the following values:");
                for (int loopVar = 0; loopVar < numberOfElement; loopVar++)
                {
                    Console.Write("{0} --> ", myStringStack.Pop());
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }            
            
            Console.ReadKey();
        }
    }
}

/*
Expected Output:

The Double Stack had the following values:
4.5 --> 9.2 --> 5.6 --> 3.4 --> 1.2 --> 0 -->

The String Stack had the following values:
Martin --> Alex --> Alan --> George --> Paul -->
 


    */
