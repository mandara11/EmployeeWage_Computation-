using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation//UC7
{
    public class ComputeEmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HOURS_IN_MONTH = 100;

        public static int totalemphours = 0;
        public static int totalworkingdays = 0;
        public static int empHrs = 0;
        public int ComputeEmpWage()
        {
            int empHrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;
            while (totalemphours <= MAX_HOURS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
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
                totalemphours += empHrs;
                Console.WriteLine("Days#:" + totalworkingdays + "empHrs : " + empHrs);
            }
            int totalempWage = totalemphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("total employee wage: " + totalempWage);
            return totalempWage;
        }
    }
}
