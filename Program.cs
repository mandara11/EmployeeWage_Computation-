namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            //DailyEmpWage obj1 = new DailyEmpWage();
            //obj1.CheckEmployeeAttendence();

            //PartTime obj3 = new PartTime();
            //obj3.AddPartTime();

            //PartTimeSwitch obj4 = new PartTimeSwitch();
            //obj4.AddPartTimeSwitch();

            //MonthWages obj5 = new MonthWages();
            //obj5.WagesforMonth();

            CalculateMonthlyWage obj6 = new CalculateMonthlyWage();
            obj6.CalculateMonthlyEmpWage();
        }
    }
}