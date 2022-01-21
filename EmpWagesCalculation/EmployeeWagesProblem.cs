using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesCalculation
{
    /// <summary>
    ///  //Caluculating Wages assuming 20 Working Days in a Month using forloop
    /// </summary>
    public class EmployeeWagesProblem
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 10;
        const int NUM_OF_WORKING_DAYS = 20;
        public static void EmployWage()   //Static method Calculating Empwage 
        {
           
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            Random randomNumber = new Random();
            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
                int checkingNum = randomNumber.Next(0, 3);
                switch (checkingNum)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("\nEmp present FullTime");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("\nEmp present partTime");

                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("\nEmp absent");

                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("daycount:\t" + day + "\nEmp Wage:\t" + empWage);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("\n\nTotal Employee wage :\t" + totalEmpWage);
        }
        }
}
 
