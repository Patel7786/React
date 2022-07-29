using System;
//this program is for demonstate the "==", objectequal and ObjectEqullreference
namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            object ob1 = "my content";
            object o = "my content";
            object ob2 = new String("my content");

            String ob3 = new string("my content");
            String ob4 = new string("my content");


            //"=="in object, compare only reference of the objects
            Console.WriteLine(ob1 == ob2);  //false beacuse ob1 and ob2 both refer differnet position
            Console.WriteLine(ob1 == o);    //true because both at the same location



            //"Equals() in object compare content;
            Console.WriteLine(ob1.Equals(ob2));  //true because content of the both object are same


            //in string , == or Equals() both method are same and only compare the content;
            Console.WriteLine(ob4 == ob3);    
            Console.WriteLine(ob4.Equals(ob3));
            Console.ReadLine();
        }
    }
}
