using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment12
{
    class Program
    {
        public delegate bool prop(int x);
        public delegate bool great(int x);
        public delegate bool less(int x);
        public delegate bool threeK(int x);
        public delegate bool threeK1(int x);
        public static void Main(string[] args)
        {
            // Create a list of integers
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // call where method on it and pass delegate to it in the following ways:

            // Find odd - Lambda Expression – without curly brackets
            IEnumerable<int> odd = list.Where(x => x % 2 == 1);
            Print("Odd", odd);

            // Find Even - Lambda Expression – with curly brackets
            IEnumerable<int> even = list.Where(x => { return x % 2 == 0; });
            Print("Even", even);

            // Find Prime – Anonymous Method
            prop prims = (x) => {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            };
            IEnumerable<int> primes = list.Where(x=>prims(x)) ;
                
            Print("Primes", primes);

            // Find Prime Another – Lambda Expression
            IEnumerable<int> primesAnother = list.Where(x => {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            Print("Primes Another", primesAnother);

            // Elements Greater Than Five – Method Group Conversion Syntax
            // use method group conversion (assigns a method to a delegate)
            great ConditionMore = new great(GreaterThanFive);   // Func<T,TResult> is a delegate
            IEnumerable<int> greaterThanFive = list.Where(x=>ConditionMore(x));
            Print("Greater Than Five", greaterThanFive);

            // Less than Five – Delegate Object in Where – Method Group Conversion Syntax in Constructor of Object
            less ConditionLess = new less(LessThanFive);
            IEnumerable<int> lessThanFive = list.Where(x=>ConditionLess(x));
            Print("Less Than Five", lessThanFive);

            // Find 3k – Delegate Object in Where – Lambda Expression in Constructor of Object
            threeK Condition3k = new threeK(x => x % 3 == 0);
            IEnumerable<int> list3k = list.Where(x=>Condition3k(x));
            Print("3k", list3k);

            // Find 3k + 1 - Delegate Object in Where – Anonymous Method in Constructor of Object
            Func<int, bool> Condition3kplus1 = new Func<int, bool>(delegate (int x)
            {
                return x % 3 == 1;
            });
            IEnumerable<int> list3kplus1 = list.Where(Condition3kplus1);
            Print("3k + 1", list3kplus1);

            // Find 3k + 2 - Delegate Object in Where – Lambda Expression Assignment
            Func<int, bool> Condition3kplus2 = x => x % 3 == 2;
            IEnumerable<int> list3kplus2 = list.Where(Condition3kplus2);
            Print("3k + 2", list3kplus2);

            // Find anything - Delegate Object in Where – Anonymous Method Assignment
            Func<int, bool> Anything = delegate (int x) {
                return x != 0;
            };
            IEnumerable<int> anything = list.Where(Anything);
            Print("Anything", anything);

            // Find anything - Delegate Object in Where – Method Group Conversion Assignment
            Func<int, bool> AnythingAnother = AnythingMethod;
            IEnumerable<int> anythingAnother = list.Where(AnythingAnother);
            Print("Anything", anythingAnother);
        }

        public static bool GreaterThanFive(int x)
        {
            return x > 5;
        }

        public static bool LessThanFive(int x)
        {
            return x < 5;
        }
        public static bool AnythingMethod(int x)
        {
            return x != 0;
        }
        public static void Print(string message, IEnumerable<int> list)
        {
            Console.Write(message + " :   ");
            foreach (int num in list)
                Console.Write(num + "  ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
