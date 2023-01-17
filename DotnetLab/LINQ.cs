using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class Linq
    {
        public static void Example ()
        {
            List<string> myList = new List<string>()
            {
                "I am Suman",
                "I am From Nepal",
                "I am an IT Student",
                "I like Machine Learning"
            };

            //Creating LINQ Query
            var q1 = from l in myList
                      select l;

            var q2 = from l in myList
                     where l.Contains("I am")
                     select l;

            //Executin LINQ query
            foreach(var q in q1)
            {
                Console.WriteLine(q);

            }
            foreach(var q in q2)
            {
                Console.WriteLine(q);
            }
        }





    }
}
