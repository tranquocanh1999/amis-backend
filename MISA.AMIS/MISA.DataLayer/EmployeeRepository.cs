using MISA.Common.Model;
using MISA.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer
{

    public class EmployeeRepository : MariaDbContext<Employee> , IEmployeeRepository
    {
     
    }
}
