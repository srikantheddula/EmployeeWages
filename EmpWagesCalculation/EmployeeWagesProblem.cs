using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesCalculation
{
    /// <summary>
    /// Compute Empwages multiple companies and save by company
    /// </summary>
    public class EmployeeWagesProblem
    {
        const int IS_FULL_TIME = 1;   //constants fields
        const int IS_PART_TIME = 2;

        private string company;        //instance global variabls
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;

        public EmployeeWagesProblem(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)   //constructor with parameters passing values
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;                               //assign param values values to global vaiables
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public  void EmployWage()   //instance method 
        {
            //local variables
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random randomNumber = new Random();

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays <= numOfWorkingDays)   
            {
                int checkingNum = randomNumber.Next(0, 3);
                totalWorkingDays++;
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
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("days: " + totalWorkingDays + "\t Emp hrs " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("company:"+company+"\n\nTotal Employee wage :\t" + totalEmpWage);          
        }
    }
}
 
