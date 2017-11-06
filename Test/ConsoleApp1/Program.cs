using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name..");
            string name = Console.ReadLine();
            string approved = "approved";

            string gonogo = $"System is capable of running .NET Core 2.0. {name} joining BlueJ is {approved}, as of {DateTime.Now.ToLocalTime()}!";

            Console.WriteLine(gonogo);
            Console.Read();
        }
    }
}
