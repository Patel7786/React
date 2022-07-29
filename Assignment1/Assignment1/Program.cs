using System;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {  //Convert.ToInt 
            Console.WriteLine("enter integer value ");
            var Input1 = Console.ReadLine();
            try
            {
                int Changed1 = Convert.ToInt32(Input1);
                Console.WriteLine("Converted to int using Convert.ToInt " + Changed1);
            }
            catch
            {
                Console.WriteLine("Can't Convert to int");
            }
            //int.parse
            Console.WriteLine("enter integer value ");
            var Input2 = Console.ReadLine();
            try
            {
                int Changed2 = int.Parse(Input2);
                Console.WriteLine("converted to int using int.Parse " + Changed2);
            }
            catch
            {
                Console.WriteLine("can't convert to int");
            }
            //int.TryParse
            Console.WriteLine("enter integer value ");
            var Input3 = Console.ReadLine();
            if (int.TryParse(Input3, out int Changed3))
            { Console.WriteLine("Coverted to int using int.TryParse" + Changed3); }
            else
                Console.WriteLine("failed to convert");
            //Convert.ToDouble
            Console.WriteLine("eenter Floating point value ");
            var Input4 = Console.ReadLine();
            try
            {
                double Changed4 = Convert.ToDouble(Input4);
                Console.WriteLine("Converted to float using Convert.ToDouble " + Changed4);
            }
            catch
            {
                Console.WriteLine("Can't Convert to Float");
            }
            //Float.Parse
            Console.WriteLine("enter Floating point value ");
            var Input5 = Console.ReadLine();
            try
            {
                var Changed5 = float.Parse(Input5);
                Console.WriteLine("Converted to float using float.parse" + Changed5);
            }
            catch
            {
                Console.WriteLine("Can't Convert to float");
            }

            //Float.Tryparse
            Console.WriteLine("enter Floating point value ");
            var Input6 = Console.ReadLine();
            if (float.TryParse(Input6, out float Changed6))
            { Console.WriteLine("Coverted to float using float.TryParse" + Changed6); }
            else
                Console.WriteLine("failed to convert");
            Console.WriteLine("enter Boolean value ");
            //Boolean.TryParse
            var Input7 = Console.ReadLine();
            if (Boolean.TryParse(Input7, out bool Changed7))
            { Console.WriteLine("Coverted to int using Boolean.TryParse" + Changed7); }
            else
                Console.WriteLine("failed to convert");
            //Convert.ToBoolean
            Console.WriteLine("enter Boolean value ");
            var Input8 = Console.ReadLine();
            try
            {
                var Changed8 = Convert.ToBoolean(Input8);
                Console.WriteLine("Converted to Boolean using Convert.ToBoolean : " + Changed8);
            }
            catch
            {
                Console.WriteLine("Can't Convert");
            }
            Console.WriteLine("enter Boolean value ");
            var Input9 = Console.ReadLine();
            try
            {
                var Changed9 = Boolean.Parse(Input9);
                Console.WriteLine("Converted to Boolean using Boolean.Parse : " + Changed9);
            }
            catch
            {
                Console.WriteLine("Can't Convert");
            }





        }
    }
}
