using System;

namespace EmployeeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("WIPRO", 30, 20, 120);
            Employee empone = new Employee("TCS", 30, 20, 120);
            emp.CheckEmployee();
            Console.Write(emp.ToString());
            Console.Write(empone.ToString());
            Console.ReadLine();
        }
    }
}
