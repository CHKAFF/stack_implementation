using System;
using System.Security.Cryptography.X509Certificates;
using Stack;
namespace ConsoleStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi this is my stack implementation. " +
                              "You can choose the stack type, for this write one " +
                              "of the data types (int, float, double, string, bool)." +
                              "Enter 'exit' to exit");
            var exitFlag = true;
            while (exitFlag)
            {
                switch (Console.ReadLine())
                {
                    case "int":
                        break;
                    case "float":
                        break;
                    case "double":
                        break;
                    case "string":
                        break;
                    case "bool":
                        break;
                    case "exit":
                        exitFlag = false;
                        Console.WriteLine("Goodbye!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid data type. Select from the list");
                        break;
                }
            }
        }

        public bool StackWork<T>()
        {
            var exitFlag = true;
            var stack = new Stack<T>();
            Console.WriteLine("");
            while (exitFlag)
            {
                switch (Console.ReadLine())
                {
                    case "push":
                        var value = Console.ReadLine();
                        break;
                    case "pop":
                        break;
                    default:
                        Console.WriteLine("Enter 'push' or 'pop'");
                        break;
                }
            }
            return false;
        }
    }
}