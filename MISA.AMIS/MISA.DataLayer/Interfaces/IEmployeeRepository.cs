using MISA.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.Interfaces
{

    /// <summary>
    /// interface cho nhân viên
    /// </summary>
    ///  Created by: TQAnh(16/03/2021)
    public interface IEmployeeRepository :IDbContext<Employee>
    {
    }
}
