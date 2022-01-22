using System;

namespace EmpWagesCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling static method  for EmpWage
            EmployeeWagesProblem.EmployWage("dmart",20,30,90);
            EmployeeWagesProblem.EmployWage("spencer", 10, 20, 70);
        }
    }
}
