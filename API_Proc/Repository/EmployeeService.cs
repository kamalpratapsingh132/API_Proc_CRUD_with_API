using API_Proc.Models;
using API_Proc.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Proc.Repository
{
    public class EmployeeService : IEmployee
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Employee CreateEmployee(Employee emp)
        {
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return emp;
        }

        public bool DeleteEmployee(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.ID == id);
            if (emp == null)
            {
                return false;
            }
            else
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return true;
            }
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.ID == id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public Employee UpdateEmployee(Employee model)
        {
            dbContext.Employees.Update(model);
            dbContext.SaveChanges();
            return model;
        }
    }
}
