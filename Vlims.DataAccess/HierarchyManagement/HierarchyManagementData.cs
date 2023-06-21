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

    using VAMLibrary.Core;
    using VAMLibrary.Core.Common;
    using Vlims.Entities.Common;
    using Vlims.Entities;


    // Comment
    public class HierarchyManagementData : IHierarchyManagementData
    {
        
        private readonly DataAccessHelper dataAccessHelper;
        
        public HierarchyManagementData(DataAccessHelper dataAccessHelper)
        {
            this.dataAccessHelper = dataAccessHelper;
        }
        
        public DataSet GetAllHierarchyManagement(RequestContext requestContext)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageNumber, Value = requestContext.PageNumber });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageSize, Value = requestContext.PageSize });
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(HierarchyManagementConstants.USP_HierarchyManagement_PSY_GET_ALL, sqlparms, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public DataSet GetHierarchyManagementByHMId(string hMId)
        {
            try
            {
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(HierarchyManagementConstants.USP_HierarchyManagement_PSY_GET, HierarchyManagementConstants.HMId, DbType.Int32, hMId, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool SaveHierarchyManagement(HierarchyManagement hierarchyManagement)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.AdminManagerId, Value = hierarchyManagement.AdminManagerId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.DepartmentConfiguration, Value = hierarchyManagement.DepartmentConfiguration });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.RoleConfiguration, Value = hierarchyManagement.RoleConfiguration });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.SetFunctionalProfile, Value = hierarchyManagement.SetFunctionalProfile });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.CreatedBy, Value = hierarchyManagement.CreatedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.ModifiedBy, Value = hierarchyManagement.ModifiedBy });
                Object result = dataAccessHelper.ExecuteStoredProcedure(HierarchyManagementConstants.USP_HierarchyManagement_PSY_INSERT, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool UpdateHierarchyManagement(HierarchyManagement hierarchyManagement)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.HMId, Value = hierarchyManagement.HMId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.AdminManagerId, Value = hierarchyManagement.AdminManagerId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.DepartmentConfiguration, Value = hierarchyManagement.DepartmentConfiguration });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.RoleConfiguration, Value = hierarchyManagement.RoleConfiguration });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.SetFunctionalProfile, Value = hierarchyManagement.SetFunctionalProfile });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = HierarchyManagementConstants.ModifiedBy, Value = hierarchyManagement.ModifiedBy });
                Object result = dataAccessHelper.ExecuteStoredProcedure(HierarchyManagementConstants.USP_HierarchyManagement_PSY_UPDATE, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteHierarchyManagementByHMId(string hMId)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(HierarchyManagementConstants.USP_HierarchyManagement_PSY_DELETE, HierarchyManagementConstants.HMId, DbType.Int32, hMId, ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAllHierarchyManagement(List<int> hMIds)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(HierarchyManagementConstants.USP_HierarchyManagement_PSY_DELETE_ALL, HierarchyManagementConstants.HMId, DbType.String, string.Join(',',  hMIds), ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
