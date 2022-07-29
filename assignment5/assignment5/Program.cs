using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment5
{
    class Duck
    {
        private int weight;
        private int wings;
        private int duck_type;
        public int DType
        {
            set { duck_type = value; }
            get { return duck_type; }
        }
        public int Weight
        {
            set { weight = value; }
            get { return weight; }
        }
        public enum typeOfDuck { Rubber_ducks , Mallard_ducks , Redhead_ducks };

        public int Wings
        {
            set {  wings = value; }
            get { return wings; }
        }
        public virtual void showDetails()
        {
            Console.WriteLine("---------------------THE DETAILS OF THE DUCK -------------------");
            Console.WriteLine("the weight of the duck is: " + Weight);
            Console.WriteLine("The Wings of the duck is :" + Wings);
        }
        public interface fly
        {
            void fly();
        }
        public interface quck
        {
            void quack();

        }
    }

    class Rubber_ducks : Duck
    {
        public void fly()
        {
            Console.WriteLine("Rubber duck  don't fly");
        }
        public void quack()
        {
            Console.WriteLine("Rubber duck Squeak");
        }
    }

    class Mallard_ducks : Duck
    {
        public void fly()
        {
            Console.WriteLine("Mallard ducks fly fast");
        }
        public void quack()
        {
            Console.WriteLine("Mallard ducks quack loud");
        }
    }

    class Redhead_ducks : Duck
    {
        public void fly()
        {
            Console.WriteLine("Redhead ducks fly slow");
        }
        public void quack()
        {
            Console.WriteLine("Redhead ducks quack mild");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> d = new List<Duck>();
            Duck duck = new Duck();
            
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("0. stop showind the details ");
                Console.WriteLine("1. Create a duck");
                Console.WriteLine("2. Show Details of the duck ");
                Console.WriteLine("Please Enter the choice : ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("-----------duck creation start ------------");
                            Console.WriteLine("please Enter the Weight of the Duck :");
                            try
                            {
                                duck.Weight = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("please Enter number of  Wings of the Duck :");
                                duck.Wings = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("please Enter the type of Duck ");
                                Console.WriteLine("0. Rubber ducks ");
                                Console.WriteLine("1. Mallard ducks ");
                                Console.WriteLine("2. Redhead duck ");
                                int type_of_duck;
                                try
                                {
                                    type_of_duck = Convert.ToInt32(Console.ReadLine());
                                    duck.DType = type_of_duck;

                                }
                                catch
                                {
                                    Console.WriteLine("can't convert into the Integer ");
                                }

                            }
                            catch
                            {
                                Console.WriteLine("can't convert into the Integer ");
                            }
                            break;

                        case 2:
                            duck.showDetails();
                            if (duck.DType == 0)
                            {
                                Rubber_ducks rd = new Rubber_ducks();

                                rd.fly();
                                rd.quack();
                                Console.WriteLine("------this is Rubber ducks-----------");
                            }
                            if (duck.DType == 1)
                            {
                                Mallard_ducks md = new Mallard_ducks();
                                md.fly();
                                md.quack();
                                Console.WriteLine("------this is Mallard ducks-----------");
                            }
                            if (duck.DType == 2)
                            {
                                Redhead_ducks r = new Redhead_ducks();
                                r.fly();
                                r.quack();
                                Console.WriteLine("------this is Readhead ducks-----------");
                            }
                            Console.WriteLine();
                            break;

                        default:// for exit
                            break;
                    }
                   
                    
                    
                   

                }
                catch
                {
                    Console.WriteLine("can't convert into the Integer ");
                }
            }
        }
    }
}
