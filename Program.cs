namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            

            //UC9
            SaveEachCompanyTotalWage dMart = new SaveEachCompanyTotalWage("DMart", 20, 2, 10);
            SaveEachCompanyTotalWage reliance = new SaveEachCompanyTotalWage("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            Console.WriteLine(reliance.ToString());
        }
    }
}