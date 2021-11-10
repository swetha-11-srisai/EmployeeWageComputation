using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStatement
{
    class Employee
    {
        const int Is_PARTTIME = 1, Is_FULLTIME = 2, EMPWAGEPERHR= 20;
        int empHrs;
        public void AddPartTime()
        {
            Random random = new Random();
            if (random.Next(0,3) == Is_PARTTIME)
            {
                empHrs = 4;
                int salary = EMPWAGEPERHR * empHrs;
                Console.WriteLine("Employee Present Part Time");
            }
            else if (random.Next(0, 3) == Is_FULLTIME)
            {
                empHrs = 8;
                int salary = EMPWAGEPERHR * empHrs;
                Console.WriteLine("Employee Present Full Time");
            }
            else
            {

                Console.WriteLine("Employee Absent");
            }

        }
    }
}
