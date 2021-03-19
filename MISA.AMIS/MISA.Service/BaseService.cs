using MISA.Common.Model;
using MISA.DataLayer.Interfaces;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace MISA.Service
{
    public class BaseService<Entity> : IBaseService<Entity>
    {
        #region DECLARE
        // khai báo các thuộc tính
        protected ServiceResult serviceResult;
        protected IDbContext<Entity> _dbContext;
        protected String sqlQuerry;
        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo 
        /// </summary>
        /// <param name="dbContext"> một interface của IDbContext<Entity> </param>
        /// CreatedBy: TQAnh ( 08/02/2021)
        public BaseService(IDbContext<Entity> dbContext)
        {
            serviceResult = new ServiceResult();
            _dbContext = dbContext;
        }




        #endregion
        #region Method

        /// <summary>
        /// lấy danh sách 
        /// </summary>
        /// <param name="payload">trường cần filter </param>
        /// <returns></returns>
        /// Created by: TQAnh(16/03/2021)
        public ServiceResult GetData(Payload payload)
        {

            Page<Entity> page = new Page<Entity>();
            var sqlConditions = sqlCondition(payload);
            page.Data= _dbContext.GetAll(payload.pageSize,payload.Offset,payload.Status, sqlConditions);
            page.TotalEleMent= _dbContext.GetTotalEleMent(payload.pageSize, payload.Offset, payload.Status, sqlConditions);
            page.PageSize = payload.pageSize;
            serviceResult.Data = page;
            return serviceResult;
        }


        /// <summary>
        /// lấy danh sách 
        /// </summary>
        /// <returns> trả về một ServiceResult  </returns>
        /// Created by: TQAnh(16/03/2021)
        public ServiceResult GetData()
        {   
            serviceResult.Data = _dbContext.GetAll();
            return serviceResult;
        }

        /// <summary>
        /// thêm mới một bản ghi 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ///  Created by: TQAnh(16/03/2021)
        public ServiceResult Insert(Entity entity)
        {

            var erroMsg = new ErroMsg();
            var isValid = ValidateData(entity, erroMsg);
            if (isValid == true)
            {
                serviceResult.Data = _dbContext.Insert(entity);
            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Data = erroMsg;

            }
            return serviceResult;
        }

        /// <summary>
        /// xóa đối tượng
        /// </summary>
        /// <param name="id">khóa chính đối tượng cần xóa</param>
        /// <returns> trả về một ServiceResult  </returns>
        ///  Created by: TQAnh(16/03/2021)
        public ServiceResult Delete(string IDs)
        {

            serviceResult.Data = _dbContext.Delete(IDs);
            return serviceResult;
        }


        /// <summary>
        /// lấy dữ liệu theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  Created by: TQAnh(16/03/2021)
        public ServiceResult GetByID(int id)
        {


            serviceResult.Data = _dbContext.GetByID(id);
            return serviceResult;


        }


        /// <summary>
        /// Chỉnh sửa một bản ghi 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ///  Created by: TQAnh(16/03/2021)
        public ServiceResult Update( Entity entity)
        {

            var erroMsg = new ErroMsg();
            var isValid = ValidateData(entity, erroMsg);
            if (isValid == true)
            {
                serviceResult.Data = _dbContext.Update( entity);


            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Data = erroMsg;

            }
            return serviceResult;

        }

        /// <summary>
        /// validate dữ liệu
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="erroMsg"></param>
        /// <returns></returns>
        /// Created by: TQAnh(16/03/2021)
        protected virtual bool ValidateData(Entity entity, ErroMsg erroMsg)
        { return true; }

        /// <summary>
        /// tạo câu lệnh sql
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        /// Created by: TQAnh(16/03/2021)
        protected virtual string sqlCondition(Payload payload)
        { return "true"; }

        #endregion
    }
}
