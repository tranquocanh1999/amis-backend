using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Common.Model
{
    /// <summary>
    /// Nhân viên
    /// CreatedBy: TQAnh (14/3/2021) 
    /// </summary>

    public class Employee
    {
        #region Constructor
        #endregion

        #region Method

        #endregion

        #region Property 
        /// <summary>
        /// khóa chính
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Mã đơn vị công tác 1-Phòng đào tạo 2-Phòng công nghệ 3-Phòng nhân sự
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Vị trí công việc 1-Nhân viên 2-Giám đốc 3-Thu ngân
        /// </summary>
        public int PositionID { get; set; }


        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string  Email { get; set; }
        #endregion

        #region Other

        /// <summary>
        /// Ngày tạo mới 
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo mới
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày chỉnh sửa gần nhất
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người chỉnh sửa gần nhất
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion

    }
}
