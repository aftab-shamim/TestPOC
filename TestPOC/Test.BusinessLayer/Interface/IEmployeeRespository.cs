using System;
using System.Collections.Generic;
using System.Text;
using Test.Entity;

namespace Test.BusinessLayer.Interface
{
    public interface IEmployeeRespository
    {
        IEnumerable<EmployeeDTO> GetAllEmployee();
        EmployeeDTO GetEmployeeByID(int id);
    }
}
