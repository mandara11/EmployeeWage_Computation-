﻿namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            CalculateMonthlyWage company = new CalculateMonthlyWage();
            company.ComputeEmpWage();
        }
    }
}