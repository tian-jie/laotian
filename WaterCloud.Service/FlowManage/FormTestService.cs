/*******************************************************************************
 * Copyright © 2020 WaterCloud.Framework 版权所有
 * Author: WaterCloud
 * Description: WaterCloud快速开发平台
 * Website：
*********************************************************************************/
using System.Threading.Tasks;
using WaterCloud.Code;
using SqlSugar;
using WaterCloud.Domain.FlowManage;
using WaterCloud.DataBase;

namespace WaterCloud.Service.FlowManage
{
    public class FormTestService : DataFilterService<FormTestEntity>, IDenpendency,ICustomerForm
    {
        public FormTestService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task Add(string flowInstanceId, string frmData)
        {
            currentuser = OperatorProvider.Provider.GetCurrent();
            var req = frmData.ToObject<FormTestEntity>();
            req.F_FlowInstanceId = flowInstanceId;
            req.Create();
            req.F_CreatorUserName = currentuser.UserName;
            await repository.Insert(req);
        }
        public async Task Edit(string flowInstanceId, string frmData)
        {
            currentuser = OperatorProvider.Provider.GetCurrent();
            var req = frmData.ToObject<FormTestEntity>();
            req.F_FlowInstanceId = flowInstanceId;
            await repository.Update(a => a.F_FlowInstanceId == req.F_FlowInstanceId, a => new FormTestEntity
            {
                F_Attachment = req.F_Attachment,
                F_EndTime = req.F_EndTime,
                F_StartTime = a.F_StartTime,
                F_RequestComment = a.F_RequestComment,
                F_RequestType = a.F_RequestType,
                F_UserName = a.F_UserName

            });
        }
    }
}
