using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //This class is a blueprint for a datatype
    internal class Human
    {
        //member variable
        public string firstName;

        public string lastName;


        public void IntroduceMyself()
        {
            Console.WriteLine("Hi i am {0} {1}", firstName, lastName);
        }
    }
}
