using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace problem5
{
    public class HashTable
    {
        int numberOfBucket;
        int size;
        private HashNode[] Bucket;

        public HashTable()
        {
            this.numberOfBucket = 10;
            this.size = 0;
            this.Bucket = new HashNode[numberOfBucket];
        }

        public HashTable(int capacity)
        {
            this.numberOfBucket = capacity;
            this.size = 0;
            this.Bucket = new HashNode[numberOfBucket];
        }

        public int GetIndexValue(int key)
        {
            return (key % numberOfBucket);
        }

        public void Insert(int key, string value)
        {
            
            int index = GetIndexValue(key);
            HashNode head = Bucket[index];
            while (head != null)
            {
                if (head.key.Equals(key))
                {
                    head.value = value;
                    return;
                }
                head = head.next;
            }
            size++;
            head = Bucket[index];
            HashNode node = new HashNode(key, value);
            node.next = head;
            Bucket[index] = node;


        }

        public string Delete(int k)
        {
            int index = GetIndexValue(k);
            HashNode head = Bucket[index];
            HashNode previous = null;

            while (head != null)
            {
                if (head.key.Equals(k))
                {
                    break;
                }
                previous = head;
                head = head.next;
            }
            if (head == null)
            {
                return null;
            }
            size--;
            if (previous != null)
            {
                previous.next = head.next;
            }
            else
            {
                Bucket[index] = head.next;
            }
            
            return head.value;
        }

        public bool Contains(int key)
        {
            int index = GetIndexValue(key);
            HashNode Head = Bucket[index];
            while (Head != null)
            {
                if (Head.key.Equals(key))
                {
                    return true;
                }
                Head = Head.next;
            }
            return false;
        }

        public string GetValueByIndex(int key)
        {
            int index = GetIndexValue(key);
            HashNode Head = Bucket[index];
            while (Head != null)
            {
                if (Head.key.Equals(key))
                {
                    return Head.value;
                }
                Head = Head.next;
            }
            return null;
        }
        public int Size()
        {
            return size;
        }

        public void Iterate(int key)
        {
            if (Contains(key) == false)
                Console.WriteLine("Sorry !! This key is not Present in the Bucket");
            else
            {
                int index = GetIndexValue(key);
                HashNode head = Bucket[index];
                while (head != null)
                {
                    Console.WriteLine(head.value);
                    head = head.next;
                }
            }
        }

        public void print(int cap)
        {
            for (int i = 0; i <cap; i++)
            {
                Console.Write(i);
                int index = GetIndexValue(i);
                HashNode head = Bucket[index];
                while (head != null)
                {
                    Console.Write("------>");
                    Console.Write(head.value);
                    head = head.next;
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }



    public class HashNode
    {
        public int key;
        public string value;
        public HashNode next=null;
        public HashNode(int key, string value)
        {
            this.value = value;
            this.key = key;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Capacity of the Bucket :");
            int cap;
            if (!int.TryParse(Console.ReadLine(), out cap))
            {
                Console.Write("Invalid input !! ");
            }
            else
            {
                HashTable hashtable = new HashTable(cap);
                int choice = -1;
                while (choice != 0)
                {
                    Console.WriteLine("0. Stop");
                    Console.WriteLine("1. insert ");
                    Console.WriteLine("2. Delete ");
                    Console.WriteLine("3. Constains");
                    Console.WriteLine("4. Get Value by Index");
                    Console.WriteLine("5. Size");
                    Console.WriteLine("6. Iterator");
                    Console.WriteLine("7. Print");
                    Console.WriteLine("Please Enter your choice :");
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.Write("Can't convert into Integer ");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1://insert
                                int key;
                                String val;
                                Console.WriteLine("please Enter the Key :");
                                if (!int.TryParse(Console.ReadLine(), out key))
                                {
                                    Console.WriteLine("Can't Convert into Integer ");
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter  the Value :");
                                    val = Console.ReadLine();
                                    hashtable.Insert(key, val);
                                    Console.WriteLine("-------------{0} in Inserted -------------------------", val);
                                }
                                break;
                            case 2: //delete
                                int k;
                                Console.WriteLine("please Enter the Key :");
                                if (!int.TryParse(Console.ReadLine(), out k))
                                {
                                    Console.WriteLine("Can't Convert into Integer ");
                                }
                                else
                                {
                                    String v = hashtable.Delete(k);
                                    if (v == null)
                                        Console.WriteLine("Sorry!! Key is not Present in Bucket");
                                    else
                                        Console.WriteLine("-------------{0} in Deleted -------------------------", v);
                                }
                                break;
                            case 3://Contains
                                int c;
                                Console.WriteLine("please Enter the Key :");
                                if (!int.TryParse(Console.ReadLine(), out c))
                                {
                                    Console.WriteLine("Can't Convert into Integer ");
                                }
                                else
                                {
                                    bool vae = hashtable.Contains(c);
                                    if (vae == false)
                                        Console.WriteLine("Sorry!! Key is not Present in Bucket");
                                    else
                                        Console.WriteLine("-------------Yes ,key is Present -------------------------", vae);
                                }
                                break;
                            case 4://Get Value by Index
                                int ke;
                                Console.WriteLine("please Enter the Key :");
                                if (!int.TryParse(Console.ReadLine(), out ke))
                                {
                                    Console.WriteLine("Can't Convert into Integer ");
                                }
                                else
                                {
                                    String va = hashtable.GetValueByIndex(ke);
                                    if (va == null)
                                        Console.WriteLine("Sorry!! Key is not Present in Bucket");
                                    else
                                        Console.WriteLine("------------ Value is :{0} -------------------------", va);
                                }
                                break;
                            case 5:
                                Console.WriteLine("Size is :{0}", hashtable.Size());
                                break;
                            case 6://Iterate
                                int ku;
                                Console.WriteLine("please Enter the Key :");
                                if (!int.TryParse(Console.ReadLine(), out ku))
                                {
                                    Console.WriteLine("Can't Convert into Integer ");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine("--------------------------Iteration start--------------------------");
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    hashtable.Iterate(ku);
                                }
                                break;
                            case 7://print
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine("--------------------------Printing start--------------------------");
                                Console.WriteLine("--------------------------------------------------------------------");
                                hashtable.print(cap);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}



