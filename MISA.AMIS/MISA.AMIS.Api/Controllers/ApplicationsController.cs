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
    /// Controller của hóa đơn
    /// </summary>
    /// Created by: TQAnh(16/03/2021)
    [ApiController]
    public class ApplicationsController : BaseController<Application>
    {
        
        public ApplicationsController(IApplicationService _iApplicationService) : base(_iApplicationService)
        {

        }
    }
}
