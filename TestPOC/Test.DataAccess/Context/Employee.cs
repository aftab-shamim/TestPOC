using System;
using System.Collections.Generic;

namespace Test.DataAccess.Context
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? ContractTypeId { get; set; }
        public decimal? Salary { get; set; }
    }
}
