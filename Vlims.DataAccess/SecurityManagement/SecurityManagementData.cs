//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicySummary.Sheet1.Data
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Vlims.Entities.Common;
    using Vlims.Entities;

    using VAMLibrary.Core;
    using VAMLibrary.Core.Common;
    using Vlims.Entities.Common;


    // Comment
    public class SecurityManagementData : ISecurityManagementData
    {
        
        private readonly DataAccessHelper dataAccessHelper;
        
        public SecurityManagementData(DataAccessHelper dataAccessHelper)
        {
            this.dataAccessHelper = dataAccessHelper;
        }
        
        public DataSet GetAllSecurityManagement(RequestContext requestContext)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageNumber, Value = requestContext.PageNumber });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageSize, Value = requestContext.PageSize });
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(SecurityManagementConstants.USP_SecurityManagement_PSY_GET_ALL, sqlparms, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public DataSet GetSecurityManagementBySMId(string sMId)
        {
            try
            {
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(SecurityManagementConstants.USP_SecurityManagement_PSY_GET, SecurityManagementConstants.SMId, DbType.Int32, sMId, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool SaveSecurityManagement(SecurityManagement securityManagement)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.AdminManagerId, Value = securityManagement.AdminManagerId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.MinimumUserIdLength, Value = securityManagement.MinimumUserIdLength });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.MinimumPasswordLength, Value = securityManagement.MinimumPasswordLength });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = SecurityManagementConstants.PasswordComplexity, Value = securityManagement.PasswordComplexity });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = SecurityManagementConstants.InvalidAttempts, Value = securityManagement.InvalidAttempts });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = SecurityManagementConstants.SessionTimeOut, Value = securityManagement.SessionTimeOut });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.CreatedBy, Value = securityManagement.CreatedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.ModifiedBy, Value = securityManagement.ModifiedBy });
                Object result = dataAccessHelper.ExecuteStoredProcedure(SecurityManagementConstants.USP_SecurityManagement_PSY_INSERT, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool UpdateSecurityManagement(SecurityManagement securityManagement)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.SMId, Value = securityManagement.SMId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.AdminManagerId, Value = securityManagement.AdminManagerId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.MinimumUserIdLength, Value = securityManagement.MinimumUserIdLength });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.MinimumPasswordLength, Value = securityManagement.MinimumPasswordLength });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = SecurityManagementConstants.PasswordComplexity, Value = securityManagement.PasswordComplexity });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = SecurityManagementConstants.InvalidAttempts, Value = securityManagement.InvalidAttempts });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = SecurityManagementConstants.SessionTimeOut, Value = securityManagement.SessionTimeOut });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = SecurityManagementConstants.ModifiedBy, Value = securityManagement.ModifiedBy });
                Object result = dataAccessHelper.ExecuteStoredProcedure(SecurityManagementConstants.USP_SecurityManagement_PSY_UPDATE, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteSecurityManagementBySMId(string sMId)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(SecurityManagementConstants.USP_SecurityManagement_PSY_DELETE, SecurityManagementConstants.SMId, DbType.Int32, sMId, ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAllSecurityManagement(List<int> sMIds)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(SecurityManagementConstants.USP_SecurityManagement_PSY_DELETE_ALL, SecurityManagementConstants.SMId, DbType.String, string.Join(',',  sMIds), ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
