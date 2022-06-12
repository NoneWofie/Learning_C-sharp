using System;

namespace RegisteringAndLogginIn
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();

            Console.WriteLine("Please enter your Password");
            password = Console.ReadLine();

            Console.WriteLine("Registration completed");
            Console.WriteLine("--------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine()) {
                Console.WriteLine("Please enter your Password");

                if (password == Console.ReadLine()) { 
                    Console.WriteLine("Sucess!");
                } else
                {
                    Console.WriteLine("Wrong password");
                }
            } else
            {
                Console.WriteLine("Invalid username");
            }

 
        }
    }
}
