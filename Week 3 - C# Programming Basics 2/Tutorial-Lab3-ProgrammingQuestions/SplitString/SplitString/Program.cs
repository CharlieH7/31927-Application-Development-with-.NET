namespace SplitString
{
    class Program
    {

        static void Main(string[] args)
        {
            //Define lists for numbers, letters & operators
            //Because we don't know the size of the array, use a LinkedList instead
            LinkedList<char> numberList = new LinkedList<char>();
            LinkedList<char> letterList = new LinkedList<char>();
            LinkedList<char> operatorList = new LinkedList<char>();

            //Read string input from user
            Console.Write("Please enter a string: ");
            string userInput = Console.ReadLine();

            //Split string and store as array of chars
            //Hint: all strings contain a method that will do this in 1 go
            char[] splitArray = userInput.ToCharArray();

            //Write code to add chars to seperate arrays
            for (int i = 0; i < splitArray.Length; i++)
            {
                //Check if char is a number, letter or symbol/operator
                //Hint: the Char class contains useful methods for this
                //Hint: use splitArray[i] to refer to the current element
                if (Char.IsNumber(splitArray[i]))
                {
                    //Add char to appropriate list, Hint: used AddLast() method
                    numberList.AddLast(splitArray[i]);
                }
                else if (Char.IsLetter(splitArray[i]))
                {
                    //Add char to appropriate list, Hint: used AddLast() method
                    letterList.AddLast(splitArray[i]);
                }
                else
                {
                    //Add char to appropriate list, Hint: used AddLast() method
                    operatorList.AddLast(splitArray[i]);
                }
            }

            //Print appropriate message for numbers
            Console.Write("\nNumbers in the string: ");
            for (int i = 0; i < numberList.Count; i++)
            {
                //ElementAt() method returns element at a given index
                Console.Write(numberList.ElementAt(i) + ", ");
            }

            //Print appropriate message for letters
            Console.Write("\nLetters in the string: ");
            for (int i = 0; i < letterList.Count; i++)
            {
                Console.Write(letterList.ElementAt(i) + ", ");
            }

            //Print appropriate message for operators/symbols
            Console.Write("\nOperators/Symbols in the string: ");
            for (int i = 0; i < operatorList.Count; i++)
            {
                Console.Write(operatorList.ElementAt(i)+ ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

/*
    Test Case:
    Please enter a string: hi! 2 plus 3 equals 5. Or, 2 + 3 = 5
    Numbers in the string: 2, 3, 5, 2, 3, 5
    Letters in the string: h, i, p, l, u, s, e, q, u, a, l, s, O, r
    Operators/Symbols in the string: !, ., ,, +, =
*/