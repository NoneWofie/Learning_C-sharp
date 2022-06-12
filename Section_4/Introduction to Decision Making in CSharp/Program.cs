using System;

namespace Introduction_to_Decision_Making_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature like?");

            string temperatureString = Console.ReadLine();

            int number;
            int temperature;

            if (int.TryParse(temperatureString, out number))
            {
                temperature = number;
            } else
            {
                temperature = 0;
            }

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }

            else if (temperature == 10)
            {
                Console.WriteLine("Its 10 degrees");
            }

            else if (temperature > 10)
            {
                Console.WriteLine("Don't take the coat");
            }
        }
    }
}
