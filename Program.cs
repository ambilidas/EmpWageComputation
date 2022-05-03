using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageComputation emp = new EmpWageComputation();
            emp.CheckEmpIsPresentOrNot();
            emp.CheckEmpFullOrPartTime();
            emp.CalcEmpDailyWage();
        }
    }
}


