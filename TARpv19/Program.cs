using System;

namespace TARpv19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();

            //Console.WriteLine("Hello World!" + name +"!");

            //string interpolation


            Console.WriteLine($"Hello, {name}!") ;
            Console.ReadLine();
        }
    }
}
