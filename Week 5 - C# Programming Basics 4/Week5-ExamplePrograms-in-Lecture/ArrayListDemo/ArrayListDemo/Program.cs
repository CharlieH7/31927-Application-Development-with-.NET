using System;
using System.Collections;
// ArrayList demo
namespace Week5ClassProgram
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            //Create an ArrayList
            ArrayList myArrayList = new ArrayList();
            // Add data into the arraylist
            for(int loopVar =0; loopVar<4; loopVar++)
            {
                myArrayList.Add(loopVar);
            }
            // Display the contents of the arraylist
            Console.Write("Arraylist Contents:");
            for (int loopVar = 0; loopVar < 4; loopVar++)
            {
                Console.Write(myArrayList[loopVar] + " ");
            }
            Console.WriteLine("");
            // Count the number of elements.
            Console.WriteLine("Number of Elements: {0}", myArrayList.Count);
            // Find the capacity.
            Console.WriteLine("Capacity : {0}", myArrayList.Capacity);
            // Reverse the order of elements
            myArrayList.Reverse();
            // Display the contents of the arraylist
            Console.Write("Arraylist Contents after reverse:");
            for (int loopVar = 0; loopVar < 4; loopVar++)
            {
                Console.Write(myArrayList[loopVar] + " ");
            }
            Console.ReadKey();
        }
    }
}
