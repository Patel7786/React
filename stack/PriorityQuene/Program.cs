using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace priority
{
    public class node
    {
        public int val;
        public int priority;

    }

    class PriorityQuene
    {
        node[] pq;
        public static int rear = -1;
        public static int front = 0;
        public readonly int Max = 1000;
        PriorityQuene()
        {
            pq = new node[Max];
        }

        public void Enquene(int value, int priority)
        {
            if (rear == Max - 1)
                Console.WriteLine("Priority Quene is full ");
            else
            {
                rear++;
                pq[rear] = new node();
                pq[rear].val = value;
                pq[rear].priority = priority;
            }
        }
        public int Peek()
        {
            int higestPriority = int.MinValue;
            int ind = -1;
            for (int i = 0; i < rear; i++)
            {
                if (higestPriority == pq[i].priority && ind > -1 && pq[ind].val < pq[i].val)
                {
                    higestPriority = pq[i].priority;
                    ind = i;
                }
                else if (higestPriority < pq[i].priority)
                {
                    higestPriority = pq[i].priority;
                    ind = i;
                }
            }
            return ind;
        }

        public int Dequene()
        {
            int element = -1;
            if (front == rear - 1)
            {
                Console.WriteLine("Priority Quene is Empty ");
            }
            else
            {
                int highPriorityIndex = Peek();
                element = pq[highPriorityIndex].val;
                for (int i = highPriorityIndex; i < rear; i++)
                {
                    pq[i] = pq[i + 1];
                }
                rear--;
            }
            return element;
        }

        public bool Contains(int d)
        {
            for (int i = 0; i <= rear; i++)
            {
                if (pq[i].val == d)
                {
                    return true;
                }
            }
            return false;
        }

        public int PriorityQueneSize()
        {
            return rear - front + 1;
        }

        public int Center()
        {
            int len = PriorityQueneSize();
            return pq[len / 2].val;
        }
        public void reverse()
        {
            for (int i = rear; i >= front; i--)
            {
                Console.Write(pq[i].val);
                Console.Write(" ");
            }
        }

        public void iterate()
        {
            for (int i = front; i < rear; i++)
            {
                Console.WriteLine(pq[i].val);
            }
        }
        public void print()
        {
            for (int i = front; i <=rear; i++)
            {
                Console.Write(pq[i].val);
                Console.Write(" ");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                PriorityQuene Priority_quene = new PriorityQuene();
                int choice = -1;
                while (choice != 0)
                {
                    Console.WriteLine("1. Enquene");
                    Console.WriteLine("2. Dequene");
                    Console.WriteLine("3. Peek");
                    Console.WriteLine("4. Contains");
                    Console.WriteLine("5. Size");
                    Console.WriteLine("6. Center");
                    Console.WriteLine("7. Reverse");
                    Console.WriteLine("8. Iteror");
                    Console.WriteLine("9. Print");
                    Console.WriteLine("Please Enter your choice :");
                    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 10)
                    {
                        Console.WriteLine("Incorrect input");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1://Push
                                Console.WriteLine("please enter your number :");
                                int data;
                                int priority;
                                if (!int.TryParse(Console.ReadLine(), out data))
                                {
                                    Console.WriteLine("Incorrect input");
                                }
                                else
                                {
                                    Console.WriteLine("Please enter the priority :");
                                    if (!int.TryParse(Console.ReadLine(), out priority))
                                        Console.WriteLine("Incorrect Input");
                                    else
                                        Priority_quene.Enquene(data, priority);
                                }
                                Console.WriteLine();
                                break;

                            case 2://pop
                                int p = Priority_quene.Dequene();
                                if (p == -1)
                                {
                                    Console.WriteLine("                    Priority Quene is Under Flow                    ");
                                }
                                else
                                {
                                    Console.WriteLine("                         {0} is Dequene ", p); ;
                                }
                                Console.WriteLine();
                                break;

                            case 3://peek
                                int k = Priority_quene.Peek();
                                if (k == -1)
                                {
                                    Console.WriteLine("                         Priority Quene is Empty                           ");
                                }
                                else
                                {
                                    Console.WriteLine("                         {0} is Peek Element", k);
                                }
                                Console.WriteLine();
                                break;

                            case 4://Contains
                                Console.WriteLine("Please enter the number will be find in priority Quene");
                                int d;
                                if (!int.TryParse(Console.ReadLine(), out d))
                                {
                                    Console.WriteLine("Incorrect Input");
                                }
                                else if (Priority_quene.Contains(d) == true)
                                    Console.WriteLine("Priority Quene contains {0}", d);
                                else
                                    Console.WriteLine(" Priority Quene does not Contains {0}", d);
                                Console.WriteLine();
                                break;

                            case 5://size
                                int si = Priority_quene.PriorityQueneSize();
                                Console.WriteLine("Length is : " + si);
                                Console.WriteLine();
                                break;

                            case 6://Center
                                int mid = Priority_quene.Center();
                                Console.WriteLine("mid element is :" + mid);
                                Console.WriteLine();
                                break;



                            case 7://Reverse
                                Console.WriteLine("--------------------------------->Value in Priority Quene before Reverse-----------------------------> ");
                                Priority_quene.print();
                                Console.WriteLine("--------------------------------->Value in Priority Quene After Reverse-----------------------------> ");
                                Priority_quene.reverse();
                                

                                break;

                            case 8://Iterate
                                Priority_quene.iterate();
                                break;

                            case 9://print
                                Console.WriteLine("--------------------------------------------------------------------------");
                                Console.WriteLine("---------------------------Printing Start----------------------------------");
                                Console.WriteLine("--------------------------------------------------------------------------");
                                Priority_quene.print();
                                Console.WriteLine();
                                Console.WriteLine();
                                break;
                        }
                    }

                }
            }
        }
    }
}
