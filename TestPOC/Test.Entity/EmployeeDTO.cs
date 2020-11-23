using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Entity
{
    public class EmployeeDTO
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int ContractTypeID { get; set; }
        public decimal? Salary { get; set; }

        public int Id { get; set; }
        public string SalaryType { get; set; }

        public decimal? AnnualSalary { get; set; }
       
    }    
}
