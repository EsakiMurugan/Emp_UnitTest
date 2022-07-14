using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Ut
{
    public class Employee : IEmployee<Employee>
    {
        public int Eid { get; set; }
        public string EName { get; set; }
        public float Salary { get; set; }
        public Employee() { }

        public Employee(int eid, string eName, float salary)
        {
            Eid = eid;
            EName = eName;
            Salary = salary;
        }
        public static List<Employee> employees = new List<Employee>();

        public bool AddEmployee(Employee e)
        {
            employees.Add(e);
            return true;
        }

        public bool checksal(int sal)
        {
            int result = add(sal, 20);
            if (result > 50)
                return true;
            else
                return false;   
        }
        public int add(int x,int y)
        {
            return x + y;
        }

        public Employee GetEmpById(int id)
        {
            Employee e = employees.Where(x => x.Eid == id).SingleOrDefault();
            return e;
        }

        public List<Employee> GetEmpList()
        {
            employees.Add(new Employee(1, "Esaki", 25000));
            employees.Add(new Employee(2,"Faisal", 30000));
            return employees;

        }

        public string message(string name)
        {
            return "Hello" + name;
        }

        public bool RemoveEmployee(int id)
        {
            Employee e = GetEmpById(id);
            employees.Remove(e);
            return true;
        }
    }
    
}
