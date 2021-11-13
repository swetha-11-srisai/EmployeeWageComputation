using System;

namespace EmployeeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee.Check("WIPRO",30,20,120);
            Employee.Check("TATA", 40, 25, 100);
            Console.ReadLine();
        }
    }
}
