using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessLayer.Interface;
using Test.Entity;
using System.Linq;

namespace Test.UnitTesting
{
    public class EmployeeRepositoryFake : IEmployeeRespository
    {
        private readonly List<EmployeeDTO> _employeeDTOs;
        public EmployeeRepositoryFake()
        {
            _employeeDTOs = new List<EmployeeDTO>()
            {
                new EmployeeDTO() {
                    EmpId = 1,
                    Ename = "Raju",
                    Job ="Account",
                    ContractTypeID = 1,
                    Salary = 200,
                    SalaryType = "Hourly",
                    AnnualSalary = 28000
                },
                 new EmployeeDTO() {
                    EmpId = 2,
                    Ename = "Suraj",
                    Job ="Developer",
                    ContractTypeID =2,
                    Salary = 40000,
                    SalaryType = "Monthly",
                    AnnualSalary = 480000
                },
                  new EmployeeDTO() {
                    EmpId = 3,
                    Ename = "Amjad",
                    Job ="HR",
                    ContractTypeID = 2,
                    Salary = 20000,
                    SalaryType = "Monthly",
                    AnnualSalary = 240000
                },
            };
        }

        public IEnumerable<EmployeeDTO> GetAllEmployee()
        {
            return _employeeDTOs;
        }
      
        public EmployeeDTO GetEmployeeByID(int id)
        {
            return _employeeDTOs.Where(a => a.EmpId == id)
                .FirstOrDefault();
        }
    }
}
