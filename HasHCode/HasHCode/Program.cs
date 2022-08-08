using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            HashClass.GenericHashTable<string, string> hash = new HashClass.GenericHashTable<string, string>(20);
            int ch = -1;
            while (ch != 6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(" HashTable Menu");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Get value by Key");
                Console.WriteLine("4. size ");
                Console.WriteLine("5. Print");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.Write("Your choice :");
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("\nSelect correct menu item.\n");
                }
                else
                {

                    switch (ch)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter Key data to be inserted into Hash Table");
                                var KeyData = Console.ReadLine();
                                Console.WriteLine("Enter Value for the key ");
                                var valueInput = (Console.ReadLine());
                                hash.Add(KeyData, valueInput);

                                Console.WriteLine("Successfully entered");
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter key To remove from the hash table ");
                                var keyData = Console.ReadLine();
                                hash.Remove(keyData);
                                Console.WriteLine("Removed Succesfully ");

                            }
                            break;


                        case 3:
                            {
                                Console.WriteLine("Enter key you wanted to search");
                                var keyData = Console.ReadLine();
                                if (hash.Find(keyData) == null)
                                {
                                    Console.WriteLine("Not found ");
                                }
                                else
                                {
                                    Console.WriteLine($"the value for key {keyData} : {hash.Find(keyData)} ");
                                }

                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine($"The size of hash map is {hash.countsize} ");
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("The hash map contains: ");
                                hash.print();
                            }
                            break;

                        case 6:
                            {
                                //exit
                            }
                            break;
                        default:
                            Console.WriteLine("\nSelect correct menu item.\n");
                            break;

                    }
                }
            }






        }
    }
}
