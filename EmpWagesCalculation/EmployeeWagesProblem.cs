using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesCalculation
{
    /// <summary>
    /// EmployeeWage Calculation
    /// </summary>
    public class EmployeeWagesProblem
    {
        public static void EmployWage()   //Static method Calculating Empwage using Switch case 
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 10;
           
                int empHrs = 0;
                int empWage = 0;
                Random randomNumber = new Random();
                int checkingNum = randomNumber.Next(0, 3);
                switch (checkingNum)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("Emp present FullTime");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Emp present partTime");

                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Emp absent");

                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Emp Wage: \n" + empWage);
            }
        }
}
 
