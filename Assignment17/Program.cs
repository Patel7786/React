using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class CustomExeception: Exception
    {
        public CustomExeception(string message)
           :base(message){ }
        
    }
    class Program
    {
       static bool UserInput(string inputString, int min, int max)
        {
            
            if(!int.TryParse(inputString,out int number))
            {
                throw new CustomExeception($" enter any integer number from {min}-{max}");
            }
            else
            {
                if(number<min||number>max)
                {
                    throw new CustomExeception($"enter number in given range ({min}-{max})");
                }
                return true;
            }

        }
        static bool EnteredInput(string inputString , int option)
        {
            int number = -1;
            int.TryParse(inputString, out number);
            if (option == 1)
            {
                if (number % 2 == 0)
                {
                    return true;
                }

                else
                {
                    throw new CustomExeception("\n It is not an even number . Try again .\n");

                }
            }
            if(option==2)
            {
               if(number %2 ==1)
                {
                    return true;
                }
               else
                {
                    throw new CustomExeception("\n It is not an odd number . TRY again \n");

                }
            }
            if (option==3)
            {
                if(IsPrime(number))
                {
                    return true;
                }
                else
                {
                    throw new CustomExeception("\n It is not a prime number .Try again \n");

                }
            }
            if(option ==4)
            {
                if (number<0)
                {
                    return true;
                }
                else
                {
                    throw new CustomExeception("\n It is not a negative number . Try again \n");

                }
            }
            if (option == 5)
            {
                if (number == 0)
                {
                    return true;
                }
                else
                {
                    throw new CustomExeception("\n It is not zero ,Try again\n");
                }
            }

            return false;

        }

     static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2 )return true;
            for(int i=2;i<=Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0)
                    return false;
                return true;
            }
            return true;
        }
        static void GetResult(string message, int option)
        {
            Console.Write(message);
            string inputString = Console.ReadLine();
            if (EnteredInput(inputString, option))
            {
                Console.WriteLine("Ya you got it right");
            }
        }
        
        static void Main(string[] args)
        {
            int number;
            int timesPlayed = 0;
            while(timesPlayed<5)
            {
                try
                {
                    Console.Write("Enter any number From 1-5:");
                    var inputString = Console.ReadLine();
                    //checking user input is between 1-5 or not 
                    if(!UserInput(inputString,1,5))
                    {
                        number = -1;
                    }
                    else
                    {
                        int.TryParse(inputString, out number);
                        timesPlayed++;
                        if(number==1)
                        {
                            GetResult("Enter even number:", number);
                        }
                        else if(number ==2)
                        {
                            GetResult("Enter Odd Number:", number);

                        }
                        else if(number==3)
                        {
                            GetResult("Enter A Prime Number:", number);

                        }
                        else if(number==4)
                        {
                            GetResult("Enter A Negative Number:", number);

                        }
                        else if(number==5)
                        {
                            GetResult("Enter zero :", number);
                        }
                    }
                }
                catch(CustomExeception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
            Console.WriteLine("\n You have played this game for 5 times \n");
        }
    }
}
