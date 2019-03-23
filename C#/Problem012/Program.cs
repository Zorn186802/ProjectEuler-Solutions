using System;

namespace Problem012
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong index = 0;
            ulong maxCpt = 0;
            ulong cpt = 0;
            ulong indexSqrt = 0;

            for (ulong i = 1; i < ulong.MaxValue; i++)
            {
                cpt = 0;
                index += i;
                indexSqrt = (ulong)Math.Sqrt(index);

                for (ulong j = 1; j <= indexSqrt; j++)
                {
                    if (index % j == 0)
                    {
                        cpt += 2;
                    }
                }
                // Perfect square
                if (indexSqrt * indexSqrt == index)
                {
                    cpt--;
                }

                if (cpt > maxCpt)
                {
                    maxCpt = cpt;
                    if (maxCpt >= 500)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Result = " + index);
        }
    }
}