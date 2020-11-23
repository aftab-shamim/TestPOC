using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessLayer.Interface;
using Test.DataAccess.Context;
using Test.Entity;
using System.Linq;

namespace Test.BusinessLayer.Implementation
{
    public class EmployeeRepository : IEmployeeRespository
    {
        private TestDBContext objTestDB;
        public EmployeeRepository()
        {
            objTestDB = new TestDBContext();
        }

        public IEnumerable<EmployeeDTO> GetAllEmployee()
        {
            var Result = (from Emp in objTestDB.Employee
                          join CT in objTestDB.ContractType on Emp.ContractTypeId equals CT.Id
                          select new EmployeeDTO
                          {
                              EmpId = Emp.EmpId,
                              Ename = Emp.Ename,
                              Job = Emp.Job,
                              Salary = Emp.Salary,
                              ContractTypeID = Emp.EmpId,
                              SalaryType = CT.SalaryType,
                              Id = CT.Id,
                              AnnualSalary = (CT.SalaryType == "Hourly" ? 120 * Emp.Salary * 12 : Emp.Salary * 12)
                          }).ToList();
            return Result;
            
        }

        public EmployeeDTO GetEmployeeByID(int id)
        {
            var Result = (from Emp in objTestDB.Employee
                          join CT in objTestDB.ContractType
                          on Emp.ContractTypeId equals CT.Id
                          where Emp.EmpId == id
                          select new EmployeeDTO
                          {
                              EmpId = Emp.EmpId,
                              Ename = Emp.Ename,
                              Job = Emp.Job,
                              Salary = Emp.Salary,
                              ContractTypeID = Emp.EmpId,
                              SalaryType = CT.SalaryType,
                              Id = CT.Id,
                              AnnualSalary = (CT.SalaryType == "Hourly" ? 120 * Emp.Salary * 12 : Emp.Salary * 12)
                          }).SingleOrDefault();
            return Result;
            
        }
    }
}
