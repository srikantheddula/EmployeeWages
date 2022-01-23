using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagesCalculation
{
    public interface IComputeEmployeeWages
    {
        void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPermonth);
        void computeEmpWage();
        int getTotalWage(string company);
    }
    class CompanyEmpWage
        {
            public string company;  //instance variables
            public int empRatePerHr;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmployeeWage;

            public CompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPermonth)
            {
                this.company = company;  // constructer method
                this.empRatePerHr = empRatePerHr;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPermonth;
            }
            public void setTotalEmployeeWage(int totalEmployeeWage)
            {
                this.totalEmployeeWage = totalEmployeeWage;
            }
            public string toString()
            {
                return "Total Emp Wage for company :" + this.company + "is :" + this.totalEmployeeWage;
            }
        }
}
