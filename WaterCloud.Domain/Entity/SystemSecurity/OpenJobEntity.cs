//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using SqlSugar;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Annotations;

namespace WaterCloud.Domain.SystemSecurity
{
    /// <summary>
	/// 定时任务
	/// </summary>
    [SugarTable("sys_openjob")]
    [Tenant("0")]
    public partial class OpenJobEntity : IEntity<OpenJobEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        [SugarColumn(ColumnName ="F_Id", IsPrimaryKey = true,ColumnDescription ="主键Id")]
        public string F_Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        [Description("任务名称")]
        [Required(ErrorMessage = "任务名称不能为空")]
        [SugarColumn(IsNullable = true, ColumnName = "F_JobName", ColumnDataType = "nvarchar(50)", ColumnDescription = "任务名称")]
        public string F_JobName { get; set; }
        /// <summary>
        /// 任务组别
        /// </summary>
        [Description("任务组别")]
        [Required(ErrorMessage = "任务组别不能为空")]
        [SugarColumn(IsNullable = true, ColumnName = "F_JobGroup",ColumnDataType = "nvarchar(50)", ColumnDescription = "任务组别")]
        public string F_JobGroup { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        [Description("文件名称")]
        [SugarColumn(IsNullable = true, ColumnName = "F_FileName", ColumnDataType = "nvarchar(100)", ColumnDescription = "文件名称")]
        public string F_FileName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [Description("开始时间")]
        [SugarColumn(IsNullable = true,ColumnDescription = "开始时间")]
        public System.DateTime? F_StarRunTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [Description("结束时间")]
        [SugarColumn(IsNullable = true,ColumnDescription = "结束时间")]
        public System.DateTime? F_EndRunTime { get; set; }
        /// <summary>
        /// 最近执行时间
        /// </summary>
        [Description("最近执行时间")]
        [SugarColumn(IsNullable = true, ColumnDescription = "最近执行时间")]
        public System.DateTime? F_LastRunTime { get; set; }

        /// <summary>
        /// 最近执行状态
        /// </summary>
        [Description("最近执行状态")]
        [SugarColumn(IsNullable = true, ColumnDescription = "最近执行状态")]
        public bool? F_LastRunMark { get; set; }
        /// <summary>
        /// 上次发生错误时间
        /// </summary>
        [Description("上次发生错误时间")]
        [SugarColumn(IsNullable = true, ColumnDescription = "上次发生错误时间")]
        public DateTime? F_LastRunErrTime { get; set; }
        /// <summary>
        /// 上次发生错误信息
        /// </summary>
        [Description("上次发生错误信息")]
        [SugarColumn(IsNullable = true, ColumnDescription = "上次发生错误信息")]
        public string F_LastRunErrMsg { get; set; }
        /// <summary>
        /// CRON表达式
        /// </summary>
        [Description("CRON表达式")]
        [Required(ErrorMessage = "CRON表达式不能为空")]
        [SugarColumn(IsNullable = true, ColumnName = "F_CronExpress",ColumnDataType = "nvarchar(50)", ColumnDescription = "CRON表达式")]
        public string F_CronExpress { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnDescription = "删除标记")]
        public bool? F_DeleteMark { get; set; }
        /// <summary>
        /// 有效标记
        /// </summary>
        [SugarColumn(IsNullable = true,ColumnDescription = "有效标记")]
        public bool? F_EnabledMark { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_Description", ColumnDataType = "longtext", ColumnDescription = "备注")]
        public string F_Description { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(IsNullable = true,ColumnDescription = "公司Id")]
        public DateTime? F_CreatorTime { get; set; }
        /// <summary>
        /// 创建人Id
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_CreatorUserId",ColumnDataType = "nvarchar(50)", ColumnDescription = "创建人Id")]
        public string F_CreatorUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnDescription = "修改时间")]
        public DateTime? F_LastModifyTime { get; set; }
        /// <summary>
        /// 修改人Id
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_LastModifyUserId",ColumnDataType = "nvarchar(50)", ColumnDescription = "修改人Id")]
        public string F_LastModifyUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        [SugarColumn(IsNullable = true,ColumnDescription = "删除时间")]
        public DateTime? F_DeleteTime { get; set; }
        /// <summary>
        /// 删除人Id
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_DeleteUserId", ColumnDataType = "nvarchar(50)", ColumnDescription = "删除人Id")]
        public string F_DeleteUserId { get; set; }
        /// <summary>
        /// 任务类型
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnDescription = "任务类型")]
        public int? F_JobType { get; set; }
        /// <summary>
        /// 请求头
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_RequestHeaders", ColumnDataType = "longtext", ColumnDescription = "请求头")]
        public string F_RequestHeaders { get; set; }
        /// <summary>
        /// 请求内容
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_RequestString", ColumnDataType = "longtext", ColumnDescription = "请求内容")]
        public string F_RequestString { get; set; }
        /// <summary>
        /// 请求url
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_RequestUrl", ColumnDataType = "longtext", ColumnDescription = "请求url")]
        public string F_RequestUrl { get; set; }
        /// <summary>
        /// 立即执行
        /// </summary>
        [SugarColumn(IsIgnore =true)]
        public bool? F_DoItNow { get; set; }
        /// <summary>
        /// 数据库序号
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_DbNumber",ColumnDataType = "nvarchar(50)", ColumnDescription = "数据库序号")]
        public string F_DbNumber { get; set; }
        /// <summary>
        /// 下次执行时间
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public DateTime? NextValidTimeAfter { get; set; }
        /// <summary>
        /// 是否记录日志
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_IsLog", ColumnDataType = "nvarchar(50)", ColumnDescription = "是否记录日志")]
        public string F_IsLog { get; set; }
        /// <summary>
        /// 执行数据库
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_JobDBProvider", ColumnDataType = "longtext", ColumnDescription = "执行数据库")]
        public string F_JobDBProvider { get; set; }
        /// <summary>
        /// 执行sql
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_JobSql", ColumnDataType = "longtext", ColumnDescription = "执行sql")]
        public string F_JobSql { get; set; }
        /// <summary>
        /// 执行sql参数
        /// </summary>
        [SugarColumn(IsNullable = true, ColumnName = "F_JobSqlParm", ColumnDataType = "longtext", ColumnDescription = "执行sql参数")]
        public string F_JobSqlParm { get; set; }
    }
}