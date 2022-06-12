using System;

namespace User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("You inputted -> " + input);
            string input2 = Console.ReadLine();
            Console.WriteLine("You inputted -> " + input2);

            int sum = int.Parse(input) + int.Parse(input2);
            Console.WriteLine("Sum is -> " + sum);

            Console.ReadLine();
        }
    }
}
