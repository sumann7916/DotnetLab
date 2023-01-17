using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class Lab2
    {
        public static void SumArray()
        {
            //Using For Loop
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i <= arr.Length; i++ )
            {
                sum += i;
            }
            Console.WriteLine("Sum of Array using for loop: " + sum);

            //Using ForEach Loop
            sum = 0;
            foreach (int n in arr)
            {
                sum += n;
            }
            Console.WriteLine("Sum of Array using forEach loop: " + sum);
            
        }

        public static void display (int a)
        {
            Console.WriteLine("int type: " + a);
        }
        public static void display (string b)
        {
            Console.WriteLine("string type: " + b);
        }
    }
}
