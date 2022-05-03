using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;

        bool IsPresent;
        bool IsFullTime;
        Random generateNum = new Random();

        public void CheckEmpIsPresentOrNot()
        {
            int num = generateNum.Next(0,2);

            if(num == 1)
            {
                Console.WriteLine("Employee is Present");
                IsPresent = true;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                IsPresent=false;
            }
        }

        public void CalcEmpDailyWage()
        {
            int EmpWage = 0;

            if (IsPresent && IsFullTime)
            {
                EmpWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            }
            else if (IsPresent && !IsFullTime)
            {
                EmpWage = WAGE_PER_HOUR * PART_TIME_HOUR;
            }
            Console.WriteLine("Employee Daily Wage is {0} ",EmpWage);
        }

        public void CheckEmpFullOrPartTime()
        {
            int num=generateNum.Next(0,2);
            if (num == 1)
            {
                IsFullTime=true;
                Console.WriteLine("Full Time Employee");
            }
            else
            {
                IsFullTime=false;
                Console.WriteLine("Part Time Employee");
            }
        }
    }   

}
