using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment13
{
    public static class ExtClass
    {

        public delegate bool Condition<T>(T n);

        public static bool CustomAll<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.All(condition);
        }
        public static bool CustomAny<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.Any(condition);
        }

        public static TResult CustomMax<T, TResult>(this IEnumerable<T> list, Func<T, TResult> function)
        {
            return list.Max(function);
        }

        public static TResult CustomMin<T, TResult>(this IEnumerable<T> list, Func<T, TResult> function)
        {
            return list.Min(function);
        }

        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.Where(condition);
        }

        public static IEnumerable<TResult> CustomSelect<T, TResult>(this IEnumerable<T> list, Func<T, TResult> function)
        {
            return list.Select(function);
        }
    }

    class program
    {
        public static void Print<T>(IEnumerable<T> list)
        {
            foreach (T Elm in list)
                Console.Write(Elm + "  ");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 3, 2, 1, 2, 3, 4, 5, 4, 3 };

            Console.WriteLine(list.CustomAll(n => n > 0));
            Console.WriteLine(list.CustomAny(n => n == 3));
            Console.WriteLine(list.CustomMax(n => 2 * n));
            Console.WriteLine(list.CustomMin(n => 2 * n));

            IEnumerable<int> whereEnum = list.CustomWhere(n => n % 2 == 1);
            Print(whereEnum);
            IEnumerable<double> selectEnum = list.CustomSelect(n => 0.5 * n);
            Print(selectEnum);
        }
    }
}