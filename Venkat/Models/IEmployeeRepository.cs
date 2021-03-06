using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venkat.Models
{
    public interface IEmployeeRepository
    {
         Employee GetEmployee(int Id);
         IEnumerable<Employee> GetAllEmployee();
         Employee AddEmployee(Employee employee);
         Employee Update(Employee employeeChanges);
         Employee Delete(int Id);
    }
}