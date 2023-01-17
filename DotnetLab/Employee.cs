using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class Employee
    {
        public string firstName, lastName;
        public double salary;

        //Creating Constructor
        public Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;    
            this.salary = salary;
            Console.WriteLine("Object Created \n");
        }

        //Creating Methods

        //Show Employee Full Name and Salary
        public void ShowDetails()
        {
            Console.WriteLine("Name: " + firstName + lastName);
            Console.WriteLine("Salary: " + salary + "\n");
        }

        //Increment Salary
        public void IncrementSalary(double incrementAmount)
        {
            this.salary += incrementAmount;
        }

    }
}
