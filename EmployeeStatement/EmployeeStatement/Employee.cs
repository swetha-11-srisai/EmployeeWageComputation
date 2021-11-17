﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStatement
{
    class Employee
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private  int totalEmpWage;
        public Employee(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
            public void CheckEmployee() 
            {
            //variables
            
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Employee Hours : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine(" Total Employee Wage for company : "+company + totalEmpWage);
           
        }
        public string toString()
        {
            return " Total Employee Wage  for company: "+this.company +this.totalEmpWage;
        }

    }
}

