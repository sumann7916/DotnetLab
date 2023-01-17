using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class Collection
    {
        public static void Example()
        {
            //Using Array List
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("Hello");
            myArrayList.Add(3.14);

            //Using List with generics
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine("ArrayList elements:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            // Iterating through the List
            Console.WriteLine("\nList elements:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
