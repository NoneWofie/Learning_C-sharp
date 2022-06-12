using System;

namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string userInput2 = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput) / int.Parse(userInput2);
                Console.WriteLine(userInputAsInt);
            }
            catch (FormatException)
            {
                throw;
                //Console.WriteLine("Format exception, Please enter the correct type");
            } catch (Exception)
            {
                Console.WriteLine("General Exception");
            } finally
            {
                Console.WriteLine("finally called");
            }

            


        }
    }
}
