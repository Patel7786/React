using System;


namespace Assignment11
{
    public static class IntExtensions
    {
        public static bool IsOdd(this int i)
        {
            if (i % 2 == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsEven(this int i)
        {
            if ((i % 2 == 0))
                return true;
            return false;
        }
        public static bool IsPrime(this int i)
        {
            if (i == 1) return false;
            if (i == 2) return true;

            double boundry = Math.Floor(Math.Sqrt(i));

            for (int j = 2; j <= boundry; ++j)
            {
                if ((i % j) == 0) return false;
            }

            return true;
        }
        public static bool IsDivisibleBy(this int i)
        {
            return (i % 2 == 0);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
                {
                    1, 3, 5, 6, 8, 9, 10
                };
            foreach (int i in numbers)
            {
                Console.Write("Testing #" + i.ToString() + ":\n");

                if (i.IsEven())
                {
                    Console.Write("Even \n");
                }
                if (i.IsOdd())
                {
                    Console.Write("Odd\n");
                }
                if (i.IsPrime())
                {
                    Console.WriteLine("prime \n");
                }
                if (i.IsDivisibleBy())
                {
                    Console.WriteLine("is divisible by 2");
                }
                Console.WriteLine();
            }
        }
    }
}

