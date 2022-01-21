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
        public static void EmployWage()   //Static method Calculating Empwage using if else if statements
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 10;
            int Is_Part_Time = 2;
            int empHrs = 0;
            int empWage = 0;

            Random randomNumber = new Random();
            int checkingNum = randomNumber.Next(0, 2);
            if (checkingNum == Is_Full_Time)
            {
                Console.WriteLine("Emp present FullTime");
                empHrs = 8;
            }
            else if (checkingNum == Is_Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("Emp present partTime");
            }
            else
            {
                Console.WriteLine("Emp is absent");
                empHrs = 0;

            }
            empWage = empHrs * Emp_Rate_Per_Hour; //empwage calculation
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
 
