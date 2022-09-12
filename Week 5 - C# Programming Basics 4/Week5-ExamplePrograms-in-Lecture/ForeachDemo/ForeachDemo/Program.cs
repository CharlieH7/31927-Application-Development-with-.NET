using System;
using System.Collections;

//Foreach demo

namespace Week5ClassProgram
{
    class ForeachDemo
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList myArraylist = new ArrayList();

            // Add data into the arrayList
            for (int loopVar = 10; loopVar<15; loopVar++)
            {
                myArraylist.Add(loopVar);
            }

            // Display the elements in the ArrayList
            Console.WriteLine("Elements in the arrayList are:");
            foreach (int element in myArraylist)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }
    }
}
