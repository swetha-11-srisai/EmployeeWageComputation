using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStatement
{
    class Employee
    {
        const int Is_PARTTIME = 1, Is_FULLTIME = 2, EMPWAGEPERHR = 20;
        int empHrs;
        public void Empdailyworking()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case Is_PARTTIME:
                    empHrs = 4;
                    Console.WriteLine("Employee Present Parttime");
                    break;
                case Is_FULLTIME:
                    empHrs = 8;
                    Console.WriteLine("Employee Present full time");
                    break;
                default:
                    Console.WriteLine("Employee Absent");
                    break;

            }
            int salary = EMPWAGEPER * empHrs;

        }
    }
}
