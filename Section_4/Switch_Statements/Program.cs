using System;

namespace Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 30:
                    Console.WriteLine("30 years old");
                    break;
                default:
                    Console.WriteLine("Default case caled");
                    break;
            }

            string username = "Denis";

            switch (username)
            {
                case "Denis":
                        Console.WriteLine("LO");
                    break;
            }
        }
    }
}
