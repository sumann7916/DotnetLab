using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class Lab1
    {
        public static void IfElse()
        {
            Console.WriteLine("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 80 && marks <= 100)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 60 && marks < 80) Console.WriteLine("B");
            else Console.WriteLine("F");
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
        }
    }
}
