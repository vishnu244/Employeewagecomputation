using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class WageCalculation
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;

        public string company;
        public int emprateperhr;
        public int numofworkingdays;
        public int maxhrpermnt;
        public int totalempwage;

        public WageCalculation(string company, int emprateperhr, int numofworkingdays, int maxhrpermnt)
        {
            this.company = company;
            this.emprateperhr = emprateperhr;
            this.numofworkingdays = numofworkingdays;
            this.maxhrpermnt = maxhrpermnt;
                
        }
        public void computewage()
        {
            int emphr = 0, totalemphrs = 0, totalworkingdays = 0; 

            while (totalemphrs <= maxhrpermnt && totalworkingdays < numofworkingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case is_part_time:
                        emphr = 4;
                        break;
                    case is_full_time:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;

                }
                totalemphrs += emphr;
                Console.WriteLine("Working Day : " + totalworkingdays + " and Employee hours per day : " + emphr);
            }
            int totalempwage = totalemphrs * emprateperhr;
            Console.WriteLine("\n");
            Console.WriteLine("Total Working Days = " + totalworkingdays + " and Total Employee hours = " + totalemphrs);
            Console.WriteLine("Total Employee Wage for company " + company + " is : " + totalempwage);
            Console.WriteLine("\n");
        }

        public string tostring()
        {
            return "Total Employee wage for company " + this.company + " is : " + this.totalempwage;
        }

    }
}
