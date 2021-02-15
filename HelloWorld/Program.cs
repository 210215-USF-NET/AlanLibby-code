using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name to be greeted");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + '!');
        }
    }
}
