using System;

namespace LinkList
{
    class ll
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }

        }
        public Node head;
        public void insert(int n)
        {
            Node newnode = new Node(n);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} is inserted ", n);
                return;
            }
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} is inserted ", n);
        }

        public void InsertAtIndex(int data, int index)
        {

            int size = LinkListSize();
            if (size + 1 < index)
            {
                Console.WriteLine("please insert  the correct index");
                return;
            }
            else if (index < 2)
            {
                if (index == 1)
                {
                    insert(data);
                }

            }
            else
            {
                int counter = 0;
                Node temp = head;
                while (counter < index - 2)
                {
                    counter++;
                    temp = temp.next;
                }
                Node n = new Node(data);
                n.next = temp.next;
                temp.next = n;
            }
        }

        public int LinkListSize()
        {

            if (head == null)
            {
                return 0;
            }
            else
            {
                Node temp = head;
                int counter = 0;
                while (temp.next != null)
                {

                    counter++;
                    temp = temp.next;

                }
                counter++;
                //Console.WriteLine(counter);
                return counter;
            }

        }
        public int delete()
        {
            if (head == null)
            {
                Console.WriteLine("All the element are deleted ");
                return head.data;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Node del = temp.next;
                temp.next = null;
                return del.data;
            }
        }

        public int DeleteAtIndex(int index)
        {
            int del = -1;
            int size = LinkListSize();
            if (size + 1 < index)
            {
                Console.WriteLine("please insert  the correct index");
                return del;
            }
            else if (index < 2)
            {
                if (index == 1)
                {
                    del = delete();
                    return del;
                }

            }
            else
            {
                int counter = 0;
                Node temp = head;
                while (counter < index - 2)
                {
                    counter++;
                    temp = temp.next;
                }
                del = temp.next.data;
                temp.next = temp.next.next;
                return del;
            }
            return del;
        }
        public void print()
        {
            Node temp = head;
            while (temp.next != null)
            {

                Console.Write(temp.data);
                Console.Write(" ");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
            Console.WriteLine();
        }

        public int Center()
        {
            int l = LinkListSize();
            Node fast;
            Node slow=head;
            if (l == 0)
            {
                Console.WriteLine("Linked List is Empty ");
                return -1;

            }
            else
            {
                fast = head;
                slow = head;
                while(fast!=null && fast.next!=null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
            }
            return slow.data;


        }


        Node sortedMerge(Node a, Node b)
        {
            Node result = null;
            /* Base cases */
            if (a == null)
                return b;
            if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.data <= b.data)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }
            return result;
        }

        public Node mergeSort(Node h)
        {
            // Base case : if head is null
            if (h == null || h.next == null)
            {
                return h;
            }

            // get the middle of the list
            Node middle = getMiddle(h);
            Node nextofmiddle = middle.next;

            // set the next of middle node to null
            middle.next = null;

            // Apply mergeSort on left list
            Node left = mergeSort(h);

            // Apply mergeSort on right list
            Node right = mergeSort(nextofmiddle);

            // Merge the left and right lists
            Node sortedlist = sortedMerge(left, right);
            return sortedlist;
        }

        // Utility function to get the
        // middle of the linked list
        Node getMiddle(Node h)
        {
            // Base case
            if (h == null)
                return h;
            Node fastptr = h.next;
            Node slowptr = h;

            // Move fastptr by two and slow ptr by one
            // Finally slowptr will point to middle node
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }

        public void reverse()
        {
            if (head == null || head.next == null)
                return;
            else
            {
                Node current = null;
                Node Next = head.next;
                while(Next.next!=null)
                {
                    
                    head.next = current;
                    current = head;
                    head = Next;

                    Next = head.next;

                }
                head.next = current;
                current = head;
                head = Next;
                head.next = current;
            }
        }
        public void iterator()
        {
            if (head == null)
            {
                Console.WriteLine("No element in Linked List");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }

            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ll l = new ll();
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("0. stop ");
                Console.WriteLine("1. Insert the element");
                Console.WriteLine("2. Insert at index   ");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Delete at Position");
                Console.WriteLine("5. Center");
                Console.WriteLine("6. Sort");
                Console.WriteLine("7. Reverse");
                Console.WriteLine("8. Size");
                Console.WriteLine("9. Itertor");
                Console.WriteLine("10. print the Linklist element");
                Console.WriteLine("Please Enter your Choice ");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 10)
                {
                    Console.WriteLine("incorrect Input-----");
                }
                else
                {
                    switch (choice)
                    {
                        case 1://insert element
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->      Insertion  start   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("Please Enter the Input :");
                            try
                            {
                                int input = Convert.ToInt32(Console.ReadLine());
                                l.insert(input);
                            }
                            catch
                            {
                                Console.WriteLine("Incorrect input ");
                            }
                            break;

                        case 2://insert at Index

                            Console.WriteLine("please Enter the index :");
                            try
                            {
                                int index = Convert.ToInt32(Console.ReadLine());
                                if (index < 1)
                                {
                                    throw new Exception("index out of bound ");
                                }
                                Console.WriteLine("please Enter the data :");
                                int data = Convert.ToInt32(Console.ReadLine());
                                l.InsertAtIndex(data, index);
                            }
                            catch
                            {
                                Console.WriteLine("Incorrect input ");
                            }

                            break;


                        case 3://delete
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->      deletion start   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            int x = l.delete();
                            if (x == -1)
                            {
                                Console.WriteLine("element is not found ");
                            }
                            else
                                Console.WriteLine("{0} is deleted. ", x);
                            break;


                        case 4://delete at index
                            try
                            {
                                Console.WriteLine("please enter the index which will be deleted ");
                                int index = Convert.ToInt32(Console.ReadLine());
                                int b = l.DeleteAtIndex(index);
                                if (b == -1)
                                {
                                    Console.WriteLine("element is not found ");
                                }
                                else
                                    Console.WriteLine("{0} is deleted", b);
                            }
                            catch
                            {
                                Console.WriteLine("please  Incorrect Input ");
                            }
                            break;

                        case 5://center
                            int cen = l.Center();
                            if (cen == -1)
                            {
                                Console.WriteLine("Center Element is not found");
                            }
                            Console.WriteLine("Center Element is : " + cen);
                            break;



                        case 6:// sort
                            
                            
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->      Sorting done   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            l.mergeSort(l.head);
                            
                            break;


                        case 7://reverse
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->     Initital Linklist   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            l.print();
                            l.reverse();
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->     After Reverse   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            l.print();
                            
                            break;

                        case 8://size
                            int size = l.LinkListSize();
                            Console.WriteLine("Size of the linked list is :" + size);
                            break;

                        case 9://iterator
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->      Iterator start   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            l.iterator();

                            break;
                        case 10://print
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("               ----->      printing start   ------>            ");
                            Console.WriteLine("--------------------------------------------------------------");
                            l.print();
                            break;

                    }
                    Console.WriteLine("--------------------------Press Enter---------------------------");
                    
                }
            }
            Console.ReadKey();
        }
    }
}
