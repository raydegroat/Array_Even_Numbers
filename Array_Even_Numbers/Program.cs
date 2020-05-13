using System;

namespace Array_Even_Numbers
{
    class Program
    {
        static int getInt()    // A method to get user input and convert it to a number
        {
            int result = 0;
            string answer = Console.ReadLine();

            Int32.TryParse(answer, out result);  // Convert string to 32 bit int

            return result;
        }

        static void Main(string[] args)
        {

            int[] a = new int[10]; // Create an array of int and initialize it

            for (int i = 0; i < a.Length; i++)  // Get 10 numbers from the user
            {
                Console.Write("Enter integer " + (i + 1) + " of " + a.Length + ": ");
                a[i] = getInt();
            }

            for (int i = 0; i < a.Length; i++)  
            {
                if(a[i] % 2 == 0)  // If the numebr is even, print it
                    Console.WriteLine(a[i]);
            }

        }
    }
}
