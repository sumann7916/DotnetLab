using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
   

    //Parent Class
    internal class Person
    {
        public string firstName, lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public void Walk()
        {
            Console.WriteLine( firstName + lastName + " is Walking");
        }
    }

    //Interface 2
    interface INepali
    {
        void Nationality();
    }
    //Parent Class
    internal class Nepali: INepali
    {
        public void Nationality()
        {
            Console.WriteLine("I am Nepali");
        }
    }

    internal class Student : Person, INepali {

        public Student(string firstName, string lastName) : base(firstName, lastName) {
            Console.WriteLine("Object Created");
        }   
        Nepali obj = new Nepali();


        public void Nationality()
        {
            obj.Nationality();
        }
    }
}
