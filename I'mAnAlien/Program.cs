using System;

namespace I_mAnAlien
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Multiply(3, 7);
            Console.WriteLine($"The result is {result}");

            if (result % 2 == 0)
            {
                Console.WriteLine($"The result is an even number!");
            } else
            {
                Console.WriteLine($"The result is an odd number!");
            }

        }
        static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }
    }
}
