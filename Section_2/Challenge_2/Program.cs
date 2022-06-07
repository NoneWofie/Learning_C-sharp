using System;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("Enter a character to search: ");
            char letter = Console.ReadLine()[0];

            int indexInText = userInput.IndexOf(letter);

            Console.WriteLine($"Text: {userInput}, Inputed char: {letter}, index at {indexInText} ");
            

            //Concatenation
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName}".Trim());

        }
    }
}
