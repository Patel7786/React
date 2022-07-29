using System;

namespace Excercise_4
{
    class Equipment
    {
        private string name;
        private string description;
        public int DistanceMovedTillDate = 0;
        public double MaintenanceCost = 0;

        

        enum Typeofequipment { mobile,immobile}

        public string getName()
        {
            return name;
        }
        public void setName(string va)
        {
             name = va; 
        }

        public void setDescription(string va)
        {
            description = va;
           
        }

        public string getDescription()
        {
            return description;

        }

        public virtual void MoveBy(int Distance)
        {
            DistanceMovedTillDate += Distance;
        }

        public virtual void Showdetails()
        {
            Console.WriteLine("Name :" + getName());
            Console.WriteLine("Discription :" + getDescription());
            Console.WriteLine("Distance move till date :" + DistanceMovedTillDate);
            Console.WriteLine("Maintenance Cost :" + MaintenanceCost);
        }
    }
    
    class mobile:Equipment
    {
        private int wheels;
        public int getWheels()
        {
            
            return wheels;
        }
        public void setWheels(int va)
        {

            wheels=va;
        }
        public override void MoveBy(int Distance)
        {
            base.MoveBy(Distance);
            MaintenanceCost += DistanceMovedTillDate * getWheels();   
        }
        public override void Showdetails()
        {
            base.Showdetails();
            Console.WriteLine("No. of Wheels :" + getWheels());
        }

    }

    class immobile : Equipment
    {
        private int weight;
        public int getWeight()
        {
           
            return weight; 
        }

        public void setWeight(int va)
        {

            weight=va;
        }
        public override void MoveBy(int Distance)
        {
            base.MoveBy(Distance);
            MaintenanceCost += DistanceMovedTillDate * getWeight();
        }
        public override void Showdetails()
        {
            base.Showdetails();
            Console.WriteLine("weight  :" + getWeight());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mobile Mobile = new mobile();
            immobile Immobile = new immobile();
            int choice = -1;
            while (choice != 4)
            {
                Console.WriteLine("Enter choice :");
                Console.WriteLine("1. Create an equipment:");
                Console.WriteLine("2. Move an equipment: ");
                Console.WriteLine("3. Show details of an Equipment :");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice: ");
                
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("1. Enter into Mobile");
                            Console.WriteLine("2. Enter Into immobile");
                            int c;
                            try
                            {
                                string name;
                                string description;
                                c = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("please enter the name of the Eqipment :");
                                name = Console.ReadLine();
                                
                                Console.WriteLine("please enter the description ");
                                description = Console.ReadLine();
                                
                                if (c == 1)
                                {
                                    Mobile.setName(name);
                                    Mobile.setDescription(description);
                                    Console.WriteLine("please enter the no. of wheels :");
                                    try
                                    {
                                        int va = Convert.ToInt32(Console.ReadLine());
                                        Mobile.setWheels(va);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please enter the Integer value ");
                                    }
                                }
                                if(c==2)
                                {
                                    Immobile.setName(name);
                                    Immobile.setDescription(description);
                                    Console.Write("please enter the weight :");
                                    try
                                    {
                                        int we = Convert.ToInt32(Console.ReadLine());
                                        Immobile.setWeight(we);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please enter the Integer value ");
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("please enter the Integer");
                            }
                            break;

                        case 2:
                            Console.WriteLine("1. MOVE into Mobile");
                            Console.WriteLine("2. MOVE into Immobile ");
                            int c2;
                            try
                            {
                                
                                c2 = Convert.ToInt32(Console.ReadLine());
                                
                               
                                if (c2== 1)
                                {
                                    Console.WriteLine("please enter the distance to move :");
                                    try
                                    {
                                        int d = Convert.ToInt32(Console.ReadLine());
                                        Mobile.MoveBy(d);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please enter the Integer value ");
                                    }
                                }
                                if (c2 == 2)
                                {
                                    Console.WriteLine("please enter the distance to move :");
                                    try
                                    {
                                        int d = Convert.ToInt32(Console.ReadLine());
                                        Immobile.MoveBy(d);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please enter the Integer value ");
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("please enter the Integer");
                            }
                            break;

                        case 3:
                            Console.WriteLine("1. show the detalis of Mobile");
                            Console.WriteLine("2. show the details of Immobile");
                            try
                            {
                                int c3 = Convert.ToInt32(Console.ReadLine());
                                if(c3 == 1)
                                {
                                    Mobile.Showdetails();
                                }
                                if (c3 == 2)
                                {
                                    Immobile.Showdetails();
                                }
                            }
                            catch
                            {
                                Console.WriteLine("please enter the Intiger ");
                            }
                            break;
                        case 4:
                            //exit
                            break;
                        default:
                            break;
                    }

                    
                }
                catch
                {
                    Console.WriteLine("please Enter the Integer ");
                }
            }
        }
    }
}
