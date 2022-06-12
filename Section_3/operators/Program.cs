using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operator
            num3 = -num1;
            Console.WriteLine(num3);

            bool isSunny = true;
            Console.WriteLine(!isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine(num);
            //post increment
            Console.WriteLine(num++);
            //pre increment
            Console.WriteLine(++num);
            Console.WriteLine(num);

            //decrement operator
            num = 0;
            num--;
            Console.WriteLine(num);
            //post increment
            Console.WriteLine(num--);
            //pre increment
            Console.WriteLine(--num);
            Console.WriteLine(num);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine(isLower);


            //conditional operators (& -> and) 
            bool isLowerAndSunny;
            isLowerAndSunny = num1 < num2;

            //Or (||)
            isLowerAndSunny = (num1  num2);
        }
    }
}
