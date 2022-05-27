//Namespace called system
//Has a bunch of different classes
//eg. what is a Console
using System;

//creating our own library
namespace Hello_World
{
    class Program
    {
        //Entry point of our program
        //static -> dont need to create an object for this class
        //void -> function doesnt return anything
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Reuben");
            Console.Read();
        }
    }
}
