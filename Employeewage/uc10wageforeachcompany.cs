using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public interface IComputeEmpWage
    {
        public void computeEmpWage();
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth);

    }
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
            this.totalEmpWage = 0;   
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
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfworkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            
        }
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.tostring());
                Console.WriteLine("\n");
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalempHrs = 0;
            int dailywage = 0;
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
                dailywage = empHrs * companyEmpWage.empRatePerHour;
                Console.WriteLine("Daily wage : "+dailywage);
            }   
            return totalempHrs * companyEmpWage.empRatePerHour;
        }
    }
}
    

