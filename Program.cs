using System;
using System.Collections.Generic;

namespace Emp_Ut
{
    public class Program
    {
        private static List<Employee> emps = new List<Employee>();

        static void Main(string[] args)
        {
            IEmployee<Employee> obj = new Employee();
            int result = obj.add(5, 4);
            Console.WriteLine(result);
            emps = obj.GetEmpList();
            Employee e1 = obj.GetEmpById(1);
            Console.WriteLine(e1.EName = " " + e1.Salary);
        }
    }
}
