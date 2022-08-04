using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class PartTime
    {
        public void AddPartTime()
        {
            //constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int RATE_PER_HOUR = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            Random obj = new Random();
            int num = obj.Next(0, 3);
            if (num == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (num == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage= empHrs * RATE_PER_HOUR;
            Console.WriteLine("Employee wage is : " + empWage);
            Console.WriteLine("Employee Worked Hours: " +empHrs);
        }
    }
}
