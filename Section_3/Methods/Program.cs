using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethingSpecific("I am a arguement");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(6, 6));
        }


        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply (int a, int b)
        {
            return (a * b);
        }

        public static double Divide(int num1,int num2)
        {   
            return num1 / num2;
        }
    }


}
