using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Ut
{
    public interface IEmployee<Employee>
    {
        List<Employee> GetEmpList(); 
        bool AddEmployee(Employee e); 
        bool RemoveEmployee(int id); 
        Employee GetEmpById(int id); 
        string message(string name); 
        bool checksal(int sal);
        int add (int x,int y);


    }
}
