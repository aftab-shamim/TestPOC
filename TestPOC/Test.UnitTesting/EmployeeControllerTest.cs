using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessLayer.Interface;
using Test.Entity;
using Test.WebAPI.Controllers;
using Xunit;


namespace Test.UnitTesting
{
    public class EmployeeControllerTest 
    {
        EmployeeController _controller;
        IEmployeeRespository _service;

        public EmployeeControllerTest()
        {
            _service = new EmployeeRepositoryFake();
            _controller = new EmployeeController(_service);
        }
       
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var Result = _controller.GetAllEmployee();
            // Assert
            var items = Assert.IsType<List<EmployeeDTO>>(Result);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_ExistingIdPassed_ReturnsResult()
        {
            // Arrange
            int EmpId = 1;
            var emp = new EmployeeDTO()
            {
                EmpId = 1,
                Ename = "Raju",
                Job = "Account",
                ContractTypeID = 1,
                Salary = 200,                
                SalaryType = "Hourly",
                AnnualSalary = 28000
            };
            // Act
            var employee = _controller.GetEmployeeByID(EmpId);
            // Assert
            Assert.Equal(emp.EmpId, employee.EmpId);            
        }
        [Fact]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            // Arrange
            int EmpId = 245;
            // Act
            var employee = _controller.GetEmployeeByID(EmpId);
            // Assert
            Assert.Null(employee);
        }
    }
}

