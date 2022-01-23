using System;

namespace EmpWagesCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWagesProblem empWageBuilder = new EmployeeWagesProblem();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 20, 90);
            empWageBuilder.AddCompanyEmpWage("spencer", 20, 30, 100);
            empWageBuilder.AddCompanyEmpWage("TATA", 20, 25, 60);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for Dmart company :" + empWageBuilder.getTotalWage("Dmart"));
        }
    }
}