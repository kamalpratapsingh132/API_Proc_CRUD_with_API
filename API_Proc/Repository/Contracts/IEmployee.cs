using API_Proc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Proc.Repository.Contracts
{
   public  interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee CreateEmployee(Employee emp);
        bool DeleteEmployee(int id);

        Employee GetEmployeeById(int id);
        Employee UpdateEmployee(Employee model);
    }
}
