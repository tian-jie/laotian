using System;
using SqlSugar;

namespace WaterCloud.Domain.SystemOrganize
{
    /// <summary>
    /// 创 建：超级管理员
    /// 日 期：2020-08-06 08:54
    /// 描 述：角色类别实体扩展类
    /// </summary>
    [SugarTable("sys_role")]
    public class RoleExtend : RoleEntity
    {
        //使用导入错误信息
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string F_Remark { get; set; }
        public string F_CompanyName { get; set; }
    }
}
