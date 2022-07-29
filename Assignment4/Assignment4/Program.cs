using System;

namespace Assignment4
{
    public class Equipment
    {
        private string name;
        private string description;
        private int distance_move_till_date = 0;
        private double maintenancecost = 0;

        public enum typeofequipment { mobile, immobile }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public int Distance_move_till_moved
        {
            set { distance_move_till_date = value; }
            get { return distance_move_till_date; }
        }
        public double Maintenancecost
        {
            get { return maintenancecost; }
            set { maintenancecost = value; }
        }
    }
    





    class mobile : Equipment
    {

        public mobile(string name, string description,int distance_move_till_date, Equipment e)
        {
            Console.Write("please enter the number of wheels :");
            int wheels;
            try
            {
                wheels = Convert.ToInt32(Console.ReadLine());
                int cost = wheels * distance_move_till_date;
                e.Distance_move_till_moved = distance_move_till_date;
                e.Maintenancecost += cost;

            }
            catch
            {
                Console.WriteLine("please enter the Integer ");
            }
        }
    }

    class immobile : Equipment
    {

        public immobile(string name, string description, int distance_move_till_date,Equipment e)
        {
            Console.Write("please enter the number of weight:");
            int weight;
            try
            {
                weight = Convert.ToInt32(Console.ReadLine());
                int cost = weight * distance_move_till_date;
                e.Distance_move_till_moved = distance_move_till_date;
                e.Maintenancecost += cost;

            }
            catch
            {
                Console.WriteLine("please enter the Integer ");
            }
        }
    }


    class Program
    {
        public static Equipment CreateEquipment()
        {
            string name;
            string description;
            int distance_move_till_date;
            int a;
            Console.WriteLine("1.create mobile equipment :");
            Console.WriteLine("2. create immobile equipment :");

            if (!int.TryParse(Console.ReadLine(), out a) || a < 1 || a > 2)
            {
                Console.WriteLine("please enter the correct integer :");
                return new Equipment();
            }
            else
            {
                Console.Write("please enter the name: ");
                name = Console.ReadLine();
                
                Console.Write("please enter the description: ");
                description = Console.ReadLine();
                Console.Write("please enter the distance till move date ");
                distance_move_till_date=Convert.ToInt32(Console.ReadLine());
                Equipment e = new Equipment();
                e.Name = name;
                e.Description = description;
                e.Distance_move_till_moved+=distance_move_till_date;

                if (a == 1)
                {
                    new mobile(name, description, distance_move_till_date,e);
                }
                if (a == 2)
                {
                    new immobile(name, description, distance_move_till_date,e);
                }
                return e;
            }
        }



        public static void movetoEquipment(Equipment s)
        {
            Console.WriteLine("1.enter into mobile");
            Console.WriteLine("2. enter into immobile");
            try
            {
                int c = Convert.ToInt32(Console.ReadLine());
                if(c==1)
                {
                    try
                    {
                        Console.Write("please enter the Integer ");
                        int distance = Convert.ToInt32(Console.ReadLine());
                        distance += s.Distance_move_till_moved;
                        
                        new mobile(s.Name, s.Description, distance, s);
                    }
                    catch
                    {
                        Console.WriteLine("please enter the Integer ");

                    }
                }
                if(c==2)
                {
                    try
                    {
                        Console.Write("please enter the updated distance till move date ");
                        int distance = Convert.ToInt32(Console.ReadLine());
                        distance += s.Distance_move_till_moved;
                        new immobile(s.Name, s.Description, distance,s);
                    }
                    catch
                    {
                        Console.WriteLine("please enter the Ineteger ");
                        

                    }
                }

            }
            catch
            {
                Console.WriteLine("please enter the Integer ");
            }
            
        }

        public static void showEquipment(Equipment e)
        {
            
            Console.WriteLine("Equipment name :" + e.Name);
            Console.WriteLine("Equipment description :" + e.Description);
            Console.WriteLine("Equipment maintenace cost :" + e.Maintenancecost);
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("0. for stop ");
            Console.WriteLine("1. create an Equipment :");
            Console.WriteLine("2. Move an Equipment :");
            Console.WriteLine("3. for showdetails of Equipment :");
            Console.WriteLine("please enter the number where you want to go :");
            int x;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                Equipment s = new Equipment();
                while (x != 0)
                {
                    switch (x)
                    {
                        case 1:
                            s = CreateEquipment();
                            break;
                        case 2:
                            movetoEquipment(s);
                            break;
                        case 3:
                            showEquipment(s);
                            break;
                        default:
                            break;


                    }
                    Console.WriteLine("0. for stop ");
                    Console.WriteLine("1. create an Equipment :");
                    Console.WriteLine("2. Move an Equipment :");
                    Console.WriteLine("3. for showdetails of Equipment :");

                    Console.WriteLine("please enter the number where you want to go :");
                    try
                    {
                        x = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("please enter the Integer");
                    }
                }
            }
            catch
            {
                Console.WriteLine("please enter the Integer");
            }

        }  
    }
}

