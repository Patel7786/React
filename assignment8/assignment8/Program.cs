using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace assignment8
{
    class PriorityQuene<T> where T:IComparable<T>
    {
        private List<T> data;
       // private IDictionary<int, IList<T>> elements;

        public PriorityQuene()
        {
            data = new List<T>();
        }

        

        public int Count() => data.Count;
        

        public bool Contains(T item)
        {
            return data.Contains(item);
        }

        public T Dequeue()
        {
            var li = data.Count - 1; // last index (before removal)
            var frontItem = data[li];
            data.RemoveAt(li);
            return frontItem;
            
        }

        public void Enqueue(T item)
        {
            if(Count()==0)
                data.Add(item);
            else
            {
                var f = 0;
                for(int i=0;i<Count();i++)
                {
                    if(item.CompareTo(data[i])<0)
                    {
                        f++;
                        data.Insert(i, item);
                        break;
                    }
                }
                if(f==0)
                {
                    data.Insert(Count(), item);
                }
            }
            
        }

        public T Peek() => data[data.Count-1];
        

       
    }
    public class Student : IComparable<Student>
    {
        private string lastname;
        private double priority;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public double Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        
        public Student(string ln, double p)
        {
            LastName = ln;
            Priority = p;
        }


       public override string ToString() => "(" + LastName + ", " + Priority.ToString("F1") + ")";

        public int CompareTo(Student other)
        {
            if (Priority < other.Priority) return -1;
            if (Priority > other.Priority) return 1;
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating priority queue of students");
            var pq = new PriorityQuene<Student>();
            int choice = -1;
            while(choice!=0)
            {
                Console.WriteLine(" 0. Stop. ");
                Console.WriteLine(" 1. Enqueue the element from quene.");
                Console.WriteLine(" 2. Dequeue the element from quene.");
                Console.WriteLine(" 3. Show the peek element in Priority Queue. ");
                Console.WriteLine(" 4. Priority queue size are: ");
                if(!int.TryParse(Console.ReadLine(),out choice) || choice<0 || choice>5)
                {
                    Console.WriteLine("please enter the Integer value in between 0 to 5");
                }
                else
                {
                    switch(choice)
                    {
                        case 0://for stop
                            break;
                        case 1:
                            Console.WriteLine("               enque start                 ");
                            String name;
                            int Priority;
                            Console.WriteLine("please enter the Name: ");
                            try
                            {
                                name = Console.ReadLine();
                                Console.WriteLine("please enter the Priority: ");
                                Priority = Convert.ToInt32(Console.ReadLine());
                                var s = new Student(name, Priority);
                                pq.Enqueue(s);
                            }
                            catch
                            {
                                Console.WriteLine(" input is incorrect ");
                            }
                            break;
                        case 2:
                            Console.WriteLine("               deque start                 ");
                            Console.WriteLine("Deque element is : "+ pq.Dequeue());
                            break;
                       
                        case 3:
                            Console.WriteLine("Peek element of the Priority Queue :" + pq.Peek());
                            break;

                        case 4:
                            Console.WriteLine(" Priority queue size are :"+pq.Count());
                            break;
                    }
                }
            }
        }
    }
}
