using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            // an instance of Human
            Human denis = new Human();
            denis.firstName = "Denis";
            denis.lastName = "hehe";
            denis.IntroduceMyself();

            Human michael = new Human();
            michael.firstName = "lol";
            michael.lastName = "john cena";
            michael.IntroduceMyself();

        }
    }
}
