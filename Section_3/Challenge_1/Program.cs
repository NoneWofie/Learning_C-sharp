using System;

namespace Challenge_1
{
    internal class Program
    {
        const string friend1 = "Tom";
        const string friend2 = "Alex";
        const string friend3 = "chicken";

        static void Main(string[] args)
        {
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine($"hi {name}, my friend!");

        }
    }
}
