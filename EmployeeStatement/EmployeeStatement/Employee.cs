using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStatement
{
    class Employee
    {
        int Is_PRESENT = 1;
        public void AttendenceCheck()
        {
            Random random = new Random();
            if (random.Next(0,2) == Is_PRESENT)
                Console.WriteLine("Employee Present");
            else
                Console.WriteLine("Employee Absenet");
        }
    }
}
