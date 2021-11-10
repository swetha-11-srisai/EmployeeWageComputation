using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStatement
{
    class Employee
    {
        public const int Is_PRESENT = 1, EMPWAGEPERHR = 20, FULLDAYHR = 8;

        public void DailyWageCalculated()
        {
            Random random = new Random();
            if (random.Next(0,2) == Is_PRESENT)
            {

                int salary = EMPWAGEPERHR * FULLDAYHR;
                Console.WriteLine("Employee Present");
            }
            else
                Console.WriteLine("Employee Absenet");
        }
    }
}
