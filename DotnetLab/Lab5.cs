using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class Lab5
    {
        public static void ZeroException()
        {
            int num1 = 2000;
            int num2 = 0;
            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cant Divide By 0");
            }
            
        }
     
    }
}
