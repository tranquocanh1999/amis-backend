using MISA.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service.Interfaces
{
    /// <summary>
    /// giao diện cho service chung 
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    public interface IBaseService<Entity>
    {

        /// <summary>
        /// lấy danh sách 
        /// </summary>
        /// <returns> trả về một ServiceResult  </returns>
        /// Created by: TQAnh(16/03/2021)
        ServiceResult GetData(Payload payload);


        /// <summary>
        /// lấy danh sách 
        /// </summary>
        /// <returns> trả về một ServiceResult  </returns>
        ///   Created by: TQAnh(16/03/2021)
        ServiceResult GetData();

        /// <summary>
        /// lấy dữ liệu theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  Created by: TQAnh(16/03/2021)
        ServiceResult GetByID(int id);


        /// <summary>
        /// thêm mới một bản ghi 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ///  Created by: TQAnh(16/03/2021)
        ServiceResult Insert(Entity entity);

        /// <summary>
        /// Chỉnh sửa một bản ghi 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ///  Created by: TQAnh(16/03/2021)
        ServiceResult Update( Entity entity);

        /// <summary>
        /// xóa đối tượng
        /// </summary>
        /// <param name="id">khóa chính đối tượng cần xóa</param>
        /// <returns> trả về một ServiceResult  </returns>
        ///  Created by: TQAnh(16/03/2021)
        ServiceResult Delete(String IDs);
    }
}
