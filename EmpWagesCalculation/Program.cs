using System;

namespace EmpWagesCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWagesProblem empWageBuilder = new EmployeeWagesProblem();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 20, 90);
            empWageBuilder.AddCompanyEmpWage("spencer", 20, 23, 100);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
}