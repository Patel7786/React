using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the two number for finding prime number between them: ");
            int first;
            int second;
            while (true)
            {
                try
                {
                    first = Convert.ToInt32(Console.ReadLine());
                    second = Convert.ToInt32(Console.ReadLine());
                    if (first < second && second<=2000 && first>=2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please give the input in correct formate first number is smaller and greater than 1 and second number is greater");
                        Console.WriteLine("please re-enter the numbers");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" please enter the integer");
                }
            }
            for (int i = first; i <= second; i++)
            {
                int j;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j >= Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
