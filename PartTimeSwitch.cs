using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class PartTimeSwitch
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public void AddPartTimeSwitch()
        {

            //variables
            int empHrs = 0;
            int empWage = 0;

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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("employee wage: " + empWage);
            Console.WriteLine("Employee Worked Hours: " +empHrs);

        }
    }
}
