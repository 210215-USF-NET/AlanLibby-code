using System;
using ToH_Models;
namespace ToH_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.HeroName = "A hero...";
            Console.WriteLine("The hero's name is: " + hero.HeroName);
        }
    }
}
