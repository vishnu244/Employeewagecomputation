using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfworkingDays;

        public int maxHoursPerMonth;

        public int totalEmpWage;


        public CompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfworkingDays = numOfworkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total Employee Wage for Company : " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfworkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
            }

        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalempHrs = 0;
            int totalWorkingDays = 0;
            while (totalempHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfworkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Working Day : " + totalWorkingDays+ " and Employee hours per day : " + empHrs);
            }
            return totalempHrs * companyEmpWage.empRatePerHour;
        }
    }
}
    

