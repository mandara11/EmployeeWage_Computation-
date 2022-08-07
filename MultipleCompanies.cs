using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation//UC8
{
    internal class MultipleCompanies
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public static int ComputeEmpwage(string company, int empRatePerHour, int numOfWorkimgDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;
            while (totalemphrs <= maxHoursPerMonth && totalworkingdays < numOfWorkimgDays)
            {
                totalworkingdays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalemphrs += empHrs;
                Console.WriteLine("Day# :" + totalworkingdays + "empHrs : " + empHrs);
            }
            int totalempwage = totalemphrs * empRatePerHour;
            Console.WriteLine("total Emp wage for company : " + company + "is : " + totalempwage);
            return totalempwage;
        }
    }
}