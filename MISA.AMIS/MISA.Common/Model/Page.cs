using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Model
{
    /// <summary>
    /// phân trang 
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    /// Created by: TQAnh(16/03/2021)
    public class Page<Entity>
    {

        /// <summary>
        /// danh sách thực thể 
        /// </summary>
        public IEnumerable<Entity> Data { get; set; }

        /// <summary>
        /// Tổng số dữ liệu trong database
        /// </summary>
        public int TotalEleMent { get; set; }

        /// <summary>
        /// số bản ghi trên 1 trang 
        /// </summary>
        public int PageSize { get; set; }
     






    }
}
