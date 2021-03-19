using MISA.Common.Model;
using MISA.DataLayer.Interfaces;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {

        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {

        }
    }
}
