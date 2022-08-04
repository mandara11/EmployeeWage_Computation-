using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class DailyEmpWage
    {
        public void CheckEmployeeAttendence()
        {
            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            Random obj = new Random();
            int empCheck = obj.Next(2);
            if (empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs=0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
