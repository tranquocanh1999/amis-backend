using Dapper;
using MISA.Common.Model;
using MISA.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MISA.DataLayer
{
    /// <summary>
    /// base chung lấy dữ liệu
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    /// Created by: TQAnh(16/03/2021)
    public class MariaDbContext<Entity> : IDbContext<Entity>
    {

        #region DECLARE

        protected string className = typeof(Entity).Name;
        // khai báo thông tin kết nối 
        String _connectionString = "Host=localhost;" +
        "Database =amis ;" +
        "Port=3307;User Id=root;" +
        " Password =123456 ;" +
        "Character Set=utf8";

        // khởi tạo kết nối 
        protected IDbConnection _dbConnection;
        #endregion

        #region Constructor
        /// <summary>
        /// hàm khởi tạo 
        /// </summary>
        ///   CreatedBy: TQAnh (14/03/2021)
        public MariaDbContext()
        {
            _dbConnection = new MySqlConnector.MySqlConnection(_connectionString);
        }

        #endregion

        #region Method
        /// <summary>
        /// Xóa một đối tượng
        /// </summary>
        /// <param name="id"> danh sách  khóa chính đối tượng cần xóa</param>
        /// <returns>trả về số dòng được thay đổi </returns>
        /// Created by: TQAnh(16/03/2021)
        public int Delete(string IDs)
        {

            var sqlQuery = $"DELETE FROM Application WHERE ApplicationId IN({IDs});";
            // thực thi truy vấn

            var efectRows = _dbConnection.Execute(sqlQuery, commandType: CommandType.Text);
            return efectRows;
        }

        public IEnumerable<Entity> GetAll(int pageSize, int offset, int status, string sqlCondition)
        {

            var sqlQuery = $"Proc_GetPage{className}";
            // thực thi truy vấn
            var entities = _dbConnection.Query<Entity>(sqlQuery, new { pageSize = pageSize, offset = offset, status = status, sqlCondition = sqlCondition }, commandType: CommandType.StoredProcedure);

            // trả về cho client
            return entities;
        }

        /// <summary>
        /// lấy tất cả danh sách đối tượng
        /// </summary>
        /// <returns>trả về danh sách đối tượng</returns>
        /// Created by: TQAnh(16/03/2021)
        public IEnumerable<Entity> GetAll()
        {

            var sqlQuery = $"Proc_GetAll{className}";
            // thực thi truy vấn
            var entities = _dbConnection.Query<Entity>(sqlQuery, commandType: CommandType.StoredProcedure);

            // trả về cho client
            return entities;
        }


        /// <summary>
        /// lấy đối tượng theo id
        /// </summary>
        /// <param name="value">giá trị id</param>

        /// <returns>trả về đối tượng </returns>
        ///  Created by: TQAnh(16/03/2021)
        public Entity GetByID(int id)
        {

            var sqlQuery = $"Proc_Get{className}ByID";
            // thực thi truy vấn
            var entities = _dbConnection.Query<Entity>(sqlQuery, new { ID = id }, commandType: CommandType.StoredProcedure).FirstOrDefault();

            // trả về cho client
            return entities;
        }


        /// <summary>
        /// thêm mới đối tượng 
        /// </summary>
        /// <param name="entity">đối tượng cần thêm mới</param>
        /// <returns> trả về số dòng được thay đổi</returns>
        ///   Created by: TQAnh(16/03/2021)
        public int Insert(Entity entity)
        {
            var sqlQuery = $"Proc_Insert{className}";
            var res = _dbConnection.Execute(sqlQuery, entity, commandType: CommandType.StoredProcedure);
            return res;
        }


        /// <summary>
        /// chỉnh sửa 1 đối tượng
        /// </summary>
        /// <param name="id">khóa chính đối tượng được thay đổi </param>
        /// <param name="entity"> đối tượng được thay đổi </param>
        /// <returns> trả về số dòng được thay đổi </returns>
        ///   Created by: TQAnh(16/03/2021)
        public int Update(Entity entity)
        {
            var sqlQuery = $"Proc_Update{className}";
            var res = _dbConnection.Execute(sqlQuery, entity, commandType: CommandType.StoredProcedure);
            return res;
        }

        /// <summary>
        /// lấy thực thể theo phân trang 
        /// </summary>
        /// <param name="pageSize">số bản ghi cần lấy</param>
        /// <param name="offset">vị trí bắt đầu lấy</param>
        /// <param name="status">trạng thái</param>
        /// <param name="sqlCondition"> điều kiện</param>
        /// <returns></returns>
        /// Created by: TQAnh(16/03/2021)
        public int GetTotalEleMent(int pageSize, int offset, int status, string sqlCondition)
        {
            var sqlQuery = "";
            if (status == 0)
                sqlQuery = $"SELECT COUNT(*) FROM Application a JOIN Employee e ON a.proposerID = e.EmployeeId  JOIN Employee e1  ON a.CensorId = e1.EmployeeId WHERE {sqlCondition}  ";
            else sqlQuery = $"SELECT COUNT(*) FROM Application a JOIN Employee e ON a.proposerID = e.EmployeeId  JOIN Employee e1  ON a.CensorId = e1.EmployeeId WHERE a.status={status} and {sqlCondition}  ";

            // lấy dữ liệu: 
            int numberOfRecord = _dbConnection.Query<int>(sqlQuery, commandType: CommandType.Text).FirstOrDefault();

            return numberOfRecord;
        }


        #endregion
    }
}
