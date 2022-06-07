using System;

namespace Constants
{
    internal class Program
    {
        //constants as fields/properties
        const double PI = 3.14159265259;
        const int weeks = 52, months = 12;
        const string birthday = "21/03/2001";

        static void Main(string[] args)
        {

            Console.WriteLine($"My birthday is {birthday}");

        }
    }
}
