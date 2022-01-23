using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesCalculation
{
    /// <summary>
    /// store the daily wage along with total employee wage
    /// </summary>
    public class EmployeeWagesProblem : IComputeEmployeeWages
    {
        public const int IS_FULL_TIME = 1;   //constants fields
        public const int IS_PART_TIME = 2;
        


        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string,CompanyEmpWage> companyToEmpWageMap;
        public EmployeeWagesProblem()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPermonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHoursPermonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmployeeWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 1,DailyWage = 0;
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
                DailyWage = empHrs * companyEmpWage.empRatePerHr;
                int[] total= { DailyWage };          // Creating an arry for to store the Daily employee wage
                Console.WriteLine("Daily Wage of Employee: {0}", total[0]);
                return totalEmpHrs * companyEmpWage.empRatePerHr; //return int totalempwage 
            }
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmployeeWage;
        }
    }
}
 
