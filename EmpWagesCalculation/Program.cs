using System;

namespace EmpWagesCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWagesProblem dmart = new EmployeeWagesProblem("Dmart", 10, 30, 60);
            dmart.EmployWage();
            Console.WriteLine(dmart.ToString());

            EmployeeWagesProblem spencer = new EmployeeWagesProblem("spencer", 30, 20, 40);
            spencer.EmployWage();
            Console.WriteLine(dmart.ToString());
        }
    }
}