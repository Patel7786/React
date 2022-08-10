using System;

namespace stack
{
    class Stack
    {
        static readonly int Max = 1000;
        int top;
        int[] stk = new int[Max];
        public Stack()
        {
            top = -1;
        }
        public void push(int data)
        {
            if (top > Max)
            {
                Console.WriteLine("Stack is OverFlow ");
            }
            else
            {
                stk[++top] = data;
            }
            Console.WriteLine("                              {0} is Pushed", data);
        }

        public int pop()
        {
            int p = -1;
            if (top < 0)
            {
                return p;

            }
            else
            {
                p = stk[top--];
            }
            return p;
        }

        public int Peek()
        {
            if (top == -1)
                return top;
            else
            {
                return stk[top];
            }
        }

        public bool Contains(int data)
        {
            bool flag = false;
            int k = top;
            while (k >= 0)
            {
                if (stk[k--] == data)
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
            return stk[len / 2];
        }

        public int stackSize()
        {
            return top+1;
        }

        public void Sort()
        {
            for(int i=top;i>0;i--)
            {
                for(int j=i-1;j>=0; j--)
                {
                    if(stk[j]<stk[i])
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
            int[] st = new int[Max];
            int k = top;
            int index = 0;
            while(k>=0)
            {
                st[index++] = stk[k--];
            }
            k++;
            while(k<=index)
            {
                stk[k] = st[k];
                k++;
            }
        }

        public void iterate()
        {
            Console.WriteLine("Iterator values are : ");
            int k = top;
            while (k >= 0)
            {
                Console.WriteLine(stk[k--]);

            }
        }
        public void print()
        {
            if (top == -1)
            {
                Console.WriteLine("stack is Empty ");
            }
            else
            {
                int k = top;
                while (k >= 0)
                {
                    Console.Write(stk[k--]);
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
            Stack mystack = new Stack();
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
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
                                mystack.push(data);
                            }
                            Console.WriteLine();
                            break;

                        case 2://pop
                            int p = mystack.pop();
                            if (p == -1)
                            {
                                Console.WriteLine("                    Stack is Under Flow                    ");
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
                                Console.WriteLine("                         Stack is Empty                           ");
                            }
                            else
                            {
                                Console.WriteLine("                         {0} is Peek Element", k);
                            }
                            Console.WriteLine();
                            break;

                        case 4://Contains
                            Console.WriteLine("Please enter the number will be find in stack");
                            int d;
                            if (!int.TryParse(Console.ReadLine(), out d))
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                            else if (mystack.Contains(d) == true)
                                Console.WriteLine("Stack contains {0}", d);
                            else
                                Console.WriteLine(" Stack does not Contains {0}", d);
                            Console.WriteLine();
                            break;

                        case 5://size
                            int si=mystack.stackSize();
                            Console.WriteLine("Length is : " + si);
                            Console.WriteLine();
                            break;

                        case 6://Center
                            int mid=mystack.Center();
                            Console.WriteLine("mid element is :" + mid);
                            Console.WriteLine();
                            break;

                        case 7://sort
                            Console.WriteLine("--------------------------------->Value in stack before Sorting-----------------------------> ");
                            mystack.print();
                            mystack.Sort();
                            Console.WriteLine("--------------------------------->Value in stack After Reverse-----------------------------> ");
                            mystack.print();
                            break;


                        case 8://Reverse
                            Console.WriteLine("--------------------------------->Value in stack before Reverse-----------------------------> ");
                            mystack.print();
                            mystack.reverse();
                            Console.WriteLine("--------------------------------->Value in stack before Reverse-----------------------------> ");
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
