using System;

namespace I_mAnAlien
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Multiply(3, 7);
            Console.WriteLine($"The result is {result}");

            // using the modules operator % its possible to check what the remainder is when deviding by 2. If its 0, then it will be an even number.
            if (result % 2 == 0)
            {
                Console.WriteLine($"The result is an even number!");
            } else
            {
                Console.WriteLine($"The result is an odd number!");
            }

        }
        //Using an int type called Multiply, I have created a method which will multiply two numbers, and then it will return the result.
        static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }
    }
}
