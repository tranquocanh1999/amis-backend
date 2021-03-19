using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Model;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.AMIS.Api.Controllers
{
    /// <summary>
    /// Controller của nhân viên
    /// </summary>
    /// Created by: TQAnh(16/03/2021)
    [ApiController]
    public class EmployeesController : BaseController<Employee>
    {
        public EmployeesController(IEmployeeService _iEmployeeService) : base(_iEmployeeService)
        { 
        
        }
        }
}
