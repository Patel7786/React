using System;

namespace Practice
{
    delegate int add(int a, int b);
    delegate int square(int a);
    public class Program
    {
        
        static void Main(string[] args)
        {
            //console.writeline 
            add i = (int a, int b) => a + b;
            Console.WriteLine("this is " + i(2,3));
            square x = (int z) => z * z;
            Console.WriteLine("this is square :" + x(2));

        }
    }
}
