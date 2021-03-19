using MISA.Common.Model;
using MISA.DataLayer.Interfaces;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class ApplicationService : BaseService<Application>, IApplicationService
    {

        public ApplicationService(IApplicationRepository applicationRepository) : base(applicationRepository)
        {

        }
        protected override bool ValidateData(Application application, ErroMsg erroMsg)
        {
            var isValid = true;
            // 1. Trường bắt buộc nhập

            // check người duyệt có trống hay không
            if (application.CensorID <= 0)
            {
                if (erroMsg != null)
                    erroMsg.UserMsg.Add(MISA.Common.Properties.Resources.UserMsg_EmptyCensorId);

                isValid = false;
            }

            //check người đề nghị có trống hay không
            if (application.ProposerID <= 0)
            {
                if (erroMsg != null)
                    erroMsg.UserMsg.Add(MISA.Common.Properties.Resources.UserMsg_EmptyProposerID);
                isValid = false;
            }

            //2.Kiểm tra ngày tháng đã hợp lệ chưa 





            return isValid;

        }

        protected override string sqlCondition(Payload payload)
        {

            string sqlConditions = "";
            if (payload.Filter != "")
            {
                sqlConditions = $"( e.FullName Like '%{payload.Filter}%' OR e1.FullName Like  '%{payload.Filter}%' Or a.place Like  '%{payload.Filter}%') ";
            }
            else
            {
                if (payload.proposerName.IsFilter)
                {
                    if (payload.proposerName.Type == "Trống")
                        sqlConditions = $" e.FullName IS NULL";
                    if (payload.proposerName.Type == "Không trống")
                        sqlConditions = $" e.FullName IS NOT NULL";
                    if (payload.proposerName.Type == "Bằng")
                        sqlConditions = $"e.FullName Like '%{payload.proposerName.Params}%'";
                    if (payload.proposerName.Type == "Khác")
                        sqlConditions = $"e.FullName NOT Like '%{payload.proposerName.Params}%'";
                   

                }
                else

                sqlConditions = "true";
            }


            return sqlConditions;
        }
    }
}
