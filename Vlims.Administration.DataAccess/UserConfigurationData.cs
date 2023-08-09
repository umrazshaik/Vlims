//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.Administration.DataAccess
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Vlims.Common;
    using Vlims.Administration.Entities;



    // Comment
    public static class UserConfigurationData
    {


        public static DataSet GetAllUserConfiguration(RequestContext requestContext)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageNumber, Value = requestContext.PageNumber });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageSize, Value = requestContext.PageSize });
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_GET_ALL, sqlparms, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static DataSet GetUserConfigurationByUCFId(int uCFId)
        {
            try
            {
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_GET, UserConfigurationConstants.UCFId, DbType.Int32, uCFId, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool SaveUserConfiguration(UserConfiguration userConfiguration)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.UserManagementID, Value = userConfiguration.UserManagementID });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.FirstName, Value = userConfiguration.FirstName });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.LastName, Value = userConfiguration.LastName });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.UserID, Value = userConfiguration.UserID });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Department, Value = userConfiguration.Department });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Role, Value = userConfiguration.Role });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Doj, Value = userConfiguration.Doj });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = UserConfigurationConstants.Empid, Value = userConfiguration.Empid });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.EmailId, Value = userConfiguration.EmailId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Activedirectory, Value = userConfiguration.Activedirectory });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Standarduser, Value = userConfiguration.Standarduser });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.CreatedBy, Value = userConfiguration.CreatedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.ModifiedBy, Value = userConfiguration.ModifiedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Status, Value = userConfiguration.Status });
                Object result = dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_INSERT, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool SaveApprovalConfiguration(ApprovalConfiguration ApprovalConfiguration)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = ApprovalkConfigurationConstants.DocTypeNoOfApprovals, Value = ApprovalConfiguration.DocTypeNoOfApprovals });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = ApprovalkConfigurationConstants.DocTempNoOfApprovals, Value = ApprovalConfiguration.DocTempNoOfApprovals });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = ApprovalkConfigurationConstants.WFlowNoOfApprovals, Value = ApprovalConfiguration.WFlowNoOfApprovals });
               
                Object result = dataAccessHelper.ExecuteStoredProcedure(ApprovalkConfigurationConstants.USP_ApprovalConfiguration_PSY_INSERT_ALL, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static DataSet GetApprovalConfiguration(RequestContext requestContext)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                //sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = ApprovalkConfigurationConstants.DocTypeNoOfApprovals,});
                //sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = ApprovalkConfigurationConstants.DocTempNoOfApprovals,});
                //sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = ApprovalkConfigurationConstants.WFlowNoOfApprovals,});


                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(ApprovalkConfigurationConstants.USP_ApprovalConfiguration_PSY_GET, sqlparms, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }







        public static bool UpdateUserConfiguration(UserConfiguration userConfiguration)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.UCFId, Value = userConfiguration.UCFId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.UserManagementID, Value = userConfiguration.UserManagementID });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.FirstName, Value = userConfiguration.FirstName });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.LastName, Value = userConfiguration.LastName });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.UserID, Value = userConfiguration.UserID });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Department, Value = userConfiguration.Department });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Role, Value = userConfiguration.Role });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Doj, Value = userConfiguration.Doj });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = UserConfigurationConstants.Empid, Value = userConfiguration.Empid });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.EmailId, Value = userConfiguration.EmailId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Activedirectory, Value = userConfiguration.Activedirectory });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Standarduser, Value = userConfiguration.Standarduser });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.ModifiedBy, Value = userConfiguration.ModifiedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Status, Value = userConfiguration.Status });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = UserConfigurationConstants.Password, Value = userConfiguration.Password });
                Object result = dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_UPDATE, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteUserConfigurationByUCFId(string uCFId)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_DELETE, UserConfigurationConstants.UCFId, DbType.Int32, uCFId, ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteAllUserConfiguration(List<int> uCFIds)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_DELETE_ALL, UserConfigurationConstants.UCFId, DbType.String, string.Join(',', uCFIds), ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static DataSet GetUserConfigurationByUserManagementId(System.Int32? uMId)
        {
            try
            {
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_By_UMId_GET, "@UMId", DbType.Int32, uMId, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteUserConfigurationByUserManagementId(System.Int32? uMId)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(UserConfigurationConstants.USP_UserConfiguration_PSY_By_UMId_DELETE, "@UMId", DbType.Int32, uMId, ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool SaveUserConfiguration(ApprovalConfiguration approvalConfiguration)
        {
            throw new NotImplementedException();
        }
    }
}

