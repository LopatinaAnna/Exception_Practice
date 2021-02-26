using System;

namespace Exception_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divide(10, 5));
            }
            catch (DivideException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine(Divide(10, 3));
            }
            catch (DivideException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Divide(int a, int b)
        {
            if (a % b == 0)
                return a / b;
            else
                throw new DivideException("The result of divide is not an integer.");
        }
    }
}
