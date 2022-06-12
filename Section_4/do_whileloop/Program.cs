using System;

namespace do_whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 15;
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter a name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;

            } while (lengthOfText < 20);
            Console.WriteLine("tHANKS STOP IT " + wholeText);
        }
    }
}
