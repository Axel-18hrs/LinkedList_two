using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList node = new LinkedList();
            bool exit = true;

            while (exit)
            {
                Console.Clear();
                Console.WriteLine("// Select an option" +
                    "\n[1]: Enter a value" +
                    "\n[2]: Delete a value" +
                    "\n[3]: Search for a value" +
                    "\n[4]: Traverse Nodes" +
                    "\n[5]: Exit");

                int option;

                // Control of the inputs
                try
                {
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter a value:");
                            node.AddNode(int.Parse(Console.ReadLine()));
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Enter a value:");
                            node.DeleteNode(int.Parse(Console.ReadLine()));
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Number to search for:");
                            node.SearchNode(int.Parse(Console.ReadLine()));
                            break;

                        case 4:
                            Console.Clear();
                            node.TraverseNode();
                            break;

                        case 5:
                            Console.WriteLine("// Goodbye.");
                            exit = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("// Not a valid choice");
                }

                Console.ReadKey();
            }
        }
    }
}
