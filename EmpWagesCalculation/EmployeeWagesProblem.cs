using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesCalculation
{
    /// <summary>
    /// empWage calculation using interface approch
    /// </summary>
    public class EmployeeWagesProblem : IComputeEmployeeWages
    {
        public const int IS_FULL_TIME = 1;   //constants fields
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;    
        public EmployeeWagesProblem()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPermonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHoursPermonth);   
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmployeeWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 1;
                Random randomNumber = new Random();
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage. numOfWorkingDays)
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
               
                return totalEmpHrs * companyEmpWage.empRatePerHr; //return int totalempwage 
            }
        }
    }
}
 
