using System;

namespace Quene
{
    class quene
    {
        static readonly int Max = 1000;
        int rear;//rear
        int front;
        int[] stk = new int[Max];
        public quene()
        {
            rear = -1;
            front = 0;
        }
        public void Enquene(int data)
        {
            if (rear == Max-1)
            {
                Console.WriteLine("Stack is OverFlow ");
            }
            else
            {
                stk[++rear] = data;
            }
            Console.WriteLine("                              {0} is Pushed", data);
        }

        public int Dequene()
        {
            if(front==rear+1)
            {
                //Console.WriteLine("  Stack is Empty ");
                return -1;
            } 
            else
            {
                int k = stk[front++];
                return k;
            }
        }

        public int Peek()
        {
            if (rear == -1)
                return rear;
            else
            {
                return stk[rear];
            }
        }

        public bool Contains(int data)
        {
            bool flag = false;
            int k = front;
            while (k <=rear)
            {
                if (stk[k++] == data)
                {
                    flag = true;

                    break;
                }
            }
            return flag;
        }

        public int Center()
        {
            int len = stackSize();
            Console.WriteLine(len);
            return stk[front+ len / 2];
        }

        public int stackSize()
        {
            return rear +1-front;
        }

        public void Sort()
        {
            for (int i = front; i <rear; i++)
            {
                for (int j = i +1; j < rear+1; j++)
                {
                    if (stk[j] < stk[i])
                    {
                        int temp = stk[j];
                        stk[j] = stk[i];
                        stk[i] = temp;
                    }
                }
            }
        }

        public void reverse()
        {
            if (rear == -1)
                Console.WriteLine("No element are present for reverse ");
            else
            {
                int[] st = new int[Max];

                int index = 0;
                for (int i = front; i <= rear; i++)
                {
                    st[index++] = stk[i];
                }
                int k = 0;
                for (int i = rear; i >= front; i--)
                {
                    stk[k++] = st[i];
                }
            }
        }

        public void iterate()
        {
            Console.WriteLine("Iterator values are : ");
            for(int i=front;i<rear+1;i++)
            {
                Console.WriteLine(stk[i]);
            }
        }
        public void print()
        {
            if (front==rear+1)
            {
                Console.WriteLine("Quene is Empty ");
            }
            else
            {
                int k = front;
                while (k <=rear)
                {
                    Console.Write(stk[k++]);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            quene mystack = new quene();
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1. Enquene");
                Console.WriteLine("2. Dequene");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Size");
                Console.WriteLine("6. Center");
                Console.WriteLine("7. Sort");
                Console.WriteLine("8. Reverse");
                Console.WriteLine("9. Iteror");
                Console.WriteLine("10. Print");
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
                            if (!int.TryParse(Console.ReadLine(), out data))
                            {
                                Console.WriteLine("Incorrect input");
                            }
                            else
                            {
                                mystack.Enquene(data);
                            }
                            Console.WriteLine();
                            break;

                        case 2://pop
                            int p = mystack.Dequene();
                            if (p == -1)
                            {
                                Console.WriteLine("                    Quene is Under Flow                    ");
                            }
                            else
                            {
                                Console.WriteLine("                         {0} is Poped ", p); ;
                            }
                            Console.WriteLine();
                            break;

                        case 3://peek
                            int k = mystack.Peek();
                            if (k == -1)
                            {
                                Console.WriteLine("                         Quene is Empty                           ");
                            }
                            else
                            {
                                Console.WriteLine("                         {0} is Peek Element", k);
                            }
                            Console.WriteLine();
                            break;

                        case 4://Contains
                            Console.WriteLine("Please enter the number will be find in Quene");
                            int d;
                            if (!int.TryParse(Console.ReadLine(), out d))
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                            else if (mystack.Contains(d) == true)
                                Console.WriteLine("Yes, Quene contains {0}", d);
                            else
                                Console.WriteLine(" Quene does not Contains {0}", d);
                            Console.WriteLine();
                            break;

                        case 5://size
                            int si = mystack.stackSize();
                            Console.WriteLine("Length is : " + si);
                            Console.WriteLine();
                            break;

                        case 6://Center
                            int mid = mystack.Center();
                            Console.WriteLine("mid element is :" + mid);
                            Console.WriteLine();
                            break;

                        case 7://sort
                            Console.WriteLine("--------------------------------->Value in Quene before Sorting-----------------------------> ");
                            mystack.print();
                            mystack.Sort();
                            Console.WriteLine("--------------------------------->Value in Quene After Sorting-----------------------------> ");
                            mystack.print();
                            break;


                        case 8://Reverse
                            Console.WriteLine("--------------------------------->Value in Quene before Reverse-----------------------------> ");
                            mystack.print();
                            mystack.reverse();
                            Console.WriteLine("--------------------------------->Value in Quene After Reverse-----------------------------> ");
                            mystack.print();

                            break;

                        case 9://Iterate
                            mystack.iterate();
                            break;

                        case 10://print
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine("---------------------------Printing Start----------------------------------");
                            Console.WriteLine("--------------------------------------------------------------------------");
                            mystack.print();
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                    }
                }

            }
        }
    }
}

