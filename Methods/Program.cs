using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");

            string name = Console.ReadLine();
            Hello(name);

            Console.ReadKey(true);
        }

         static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}!");
            
        }

    }
}
