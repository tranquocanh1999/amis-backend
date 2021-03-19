using MISA.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.Interfaces
{
    /// <summary>
    /// interface cho đơn đề nghị công tác
    /// </summary>
    ///   CreatedBy: TQAnh (14/3/2021)
   public interface IApplicationRepository :IDbContext<Application>
    {
    }
}
