using System;

namespace Problem010
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 0;
            for (long i = 1; i < 2000000; i++)
            {
                if (IsPrime(i))
                {
                    result += i;
                }
            }

            Console.WriteLine("Result=" + result);
        }

        static bool IsPrime(long number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            for (long i = 3; i <= (long)Math.Floor(Math.Sqrt(number)); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
