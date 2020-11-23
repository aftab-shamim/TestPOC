using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.BusinessLayer.Interface;
using Test.Entity;

namespace Test.WebAPI.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRespository _repo = null;
        public EmployeeController(IEmployeeRespository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetAllEmployee")]
        public IEnumerable<EmployeeDTO> GetAllEmployee()
        {
            IEnumerable<EmployeeDTO> employeesList = _repo.GetAllEmployee();
            return employeesList;
        }

        [HttpGet]
        [Route("GetEmployeeByID/{id:int}")]
        public EmployeeDTO GetEmployeeByID(int id)
        {
            EmployeeDTO employee = _repo.GetEmployeeByID(id);
            return employee;
        }

    }
}