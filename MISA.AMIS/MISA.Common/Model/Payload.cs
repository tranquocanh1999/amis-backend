using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Model
{
    /// <summary>
    /// Dữ liệu cần filter của hóa đơn
    /// </summary>
    /// Created by: TQAnh(16/03/2021)
    public class Payload
    {
        /// <summary>
        /// số bản ghi trên 1 trang
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// vị trí bắt đầu lọc
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// trạng thái hóa đơn
        /// </summary>
        public int Status { get; set; }


        /// <summary>
        /// lọc cơ bản
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// trường lọc người đề nghị
        /// </summary>
        public FilterItem proposerName { get; set; }

        /// <summary>
        /// trường lọc người duyệt
        /// </summary>
        public FilterItem censorName { get; set; }
    }
}
