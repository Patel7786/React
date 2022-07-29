using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment7
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
        

        public int Wings
        {
            set { wings = value; }
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
        public enum typeOfDuck { Rubber_ducks = 0, Mallard_ducks = 1, Redhead_ducks = 2 };
        static void Main(string[] args)
        {

            List<Duck> d = new List<Duck>();

            int choice = -1;
            while (choice != 0)
            {
                Duck duck = new Duck();
                Console.WriteLine("/n 0. stop showind the details ");
                Console.WriteLine("/n 1. Create a duck");
                Console.WriteLine("/n 2. Show Details of the duck ");
                Console.WriteLine("/n 3. remove a duck");
                Console.WriteLine("/n 4. delete all the duck");
                Console.WriteLine("/n 5. Sort Ducks in increasing order of their weights");
                Console.WriteLine("/n 6.Sort Ducks in increasing order of number of wings");
                Console.WriteLine("/n 7. exit");

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
                                int type_of_duck=-1;
                                if(!int.TryParse(Console.ReadLine(),out type_of_duck) || type_of_duck<0 || type_of_duck>2)
                                {

                                    Console.WriteLine("please enter the correct input ");
                                }
                                else
                                {
                                    //type_of_duck = Convert.ToInt32(Console.ReadLine());
                                    duck.DType = type_of_duck;
                                    d.Add(duck);
                                }

                            }
                            catch
                            {
                                Console.WriteLine("can't convert into the Integer ");
                            }
                            break;

                        

                        
                        case 2:
                            foreach(Duck p in d )
                            {
                                p.showDetails();
                                if (p.DType.Equals((int)typeOfDuck.Rubber_ducks)) 
                                {
                                    Rubber_ducks rd = new Rubber_ducks();

                                    rd.fly();
                                    rd.quack();
                                    Console.WriteLine("--------this is Rubber ducks-----------");
                                }
                                if (p.DType.Equals((int)typeOfDuck.Mallard_ducks))
                                {
                                    Mallard_ducks md = new Mallard_ducks();
                                    md.fly();
                                    md.quack();
                                    Console.WriteLine("--------this is Mallard ducks-----------");
                                }
                                if (p.DType.Equals((int)typeOfDuck.Redhead_ducks))
                                {
                                    Redhead_ducks r = new Redhead_ducks();
                                    r.fly();
                                    r.quack();
                                    Console.WriteLine("--------this is Readhead ducks-----------");
                                }
                                Console.WriteLine("                   showing the details           ");
                                Console.WriteLine("-----------------------------------------------------");
                                
                            }
                            break;
                        case 3://remove the duck
                            int selectedDuck = -1;
                            Console.Write(" Select the Duck you want to delete: ");
                            if (!int.TryParse(Console.ReadLine(), out selectedDuck) || selectedDuck < 0 || selectedDuck > d.Count)
                            {
                                Console.WriteLine("\n Invalid Input! try agian... \n");
                            }
                            else
                            {
                                d.RemoveAt(selectedDuck - 1);
                                Console.WriteLine("\n The Duck has been deleted.\n");
                            }
                            Console.WriteLine();

                            break;

                        case 4://deltion of duck
                            d.Clear();
                            Console.WriteLine("-------------All the ducks are deleted------------------ ");
                            break;
                        case 5: // sort the duck on the basic of weight
                            //List<Duck> duckList = d.GetRange(0, d.Count);
                            Duck minDuck = d[0];
                            for (int i = 0; i < d.Count - 1; i++)
                            {
                                for (int j = i + 1; j < d.Count; j++)
                                {
                                    if (d[i].Weight > d[j].Weight)
                                    {
                                        minDuck = d[i];
                                        d[i] = d[j];
                                        d[j] = minDuck;
                                    }
                                }
                            }
                            Console.WriteLine("             sorting on the basic of weight          ");
                            Console.WriteLine("-----------------------------------------------------");
                                break;
                        case 6:// sort on the basic of wings
                            Duck minduck = d[0];
                            for (int i = 0; i < d.Count - 1; i++)
                            {
                                for (int j = i + 1; j < d.Count; j++)
                                {
                                    if (d[i].Weight > d[j].Weight)
                                    {
                                        minduck = d[i];
                                        d[i] = d[j];
                                        d[j] = minduck;
                                    }
                                }
                            }
                            Console.WriteLine("           sorting on the basic of wings              ");
                            Console.WriteLine("-----------------------------------------------------");
                            break;

                        case 7:// for exit
                            break;

                        default:
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
