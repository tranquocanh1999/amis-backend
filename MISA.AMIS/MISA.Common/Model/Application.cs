using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Common.Model
{
    /// <summary>
    /// Đơn đề nghị công tác 
    /// Created by: TQAnh(16/03/2021)
    /// </summary>
    public class Application
    {
        #region Constructor
        #endregion

        #region Method

        #endregion

        #region Property 
        /// <summary>
        /// khóa chính
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Mã người đề nghị
        /// </summary>
        public int ProposerID { get; set; }



        /// <summary>
        /// Mã người đề nghị
        /// </summary>
        public string proposerName { get; set; }


        /// <summary>
        /// Mã người đề nghị
        /// </summary>
        public string CensorName { get; set; }

        /// <summary>
        /// Mã đơn vị công tác
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Mã người duyệt
        /// </summary>
        public int CensorID { get; set; }

        /// <summary>
        /// Ngày duyệt
        /// </summary>
        public DateTime RecommendedDate { get; set; }

        /// <summary>
        /// Ngày đi 
        /// </summary>
        public DateTime DepartureDay { get; set; }

        /// <summary>
        /// Ngày về 
        /// </summary>
        public DateTime DateBack { get; set; }

        /// <summary>
        /// Địa điểm công tác
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// lí do công tác 
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// trạng thái đơn đề nghị 1-Chờ duyệt 2-Đã duyệt 3-Từ chối
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// danh sách người hỗ trợ 
        /// </summary>
        public string PeopleSupportIds { get; set; }

        /// <summary>
        /// yêu cầu giúp đỡ
        /// </summary>
        public string RequestSupport { get; set; }


        /// <summary>
        /// danh sách người liên quan
        /// </summary>
        public string PeopleInvolIds { get; set; }

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
