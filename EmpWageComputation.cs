using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
        Random generateNum = new Random();

        public void CheckEmpIsPresentOrNot()
        {
            int num = generateNum.Next(0,2);

            if(num == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
