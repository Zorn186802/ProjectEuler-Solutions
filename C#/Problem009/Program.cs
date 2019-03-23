using System;

namespace Problem009
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1000;
            int cpowed = 0;

            for (int a = 1; ; a++)
            {
                for (int b = (a + 1); (a + b + (int)Math.Sqrt(cpowed)) <= result; b++)
                {
                    cpowed = (int)(Math.Pow(a, 2) + Math.Pow(b, 2));
                    if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == cpowed)
                    {
                        if ((a + b + Math.Sqrt(cpowed)) == result)
                        {
                            Console.WriteLine("a=" + a + " b=" + b + " c=" + Math.Sqrt(cpowed));
                            Console.WriteLine("a+b+c=" + (a + b + Math.Sqrt(cpowed)));
                            Console.WriteLine("a*b*c=" + (a * b * Math.Sqrt(cpowed)));
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}