using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Model
{
    /// <summary>
    /// Object các item cần filter
    /// </summary>
    /// Created by: TQAnh(16/03/2021)
    public class FilterItem
    {
        /// <summary>
        /// Check xem trường có cần filter hay không
        /// </summary>
        public Boolean IsFilter { get; set; }

        /// <summary>
        /// loại lọc
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// dữ liệu cần lọc
        /// </summary>
        public string Params { get; set; }

    }
}
