//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.DocumentMaster.DataAccess
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using Vlims.Common;
    using Vlims.DocumentMaster.Entities;
    using System.Xml.Serialization;
    using Microsoft.Practices.EnterpriseLibrary.Common.Utility;
    using Microsoft.VisualBasic;

    // Comment
    public class workflowconigurationData
    {



        public static DataSet GetAllworkflowconiguration(RequestContext requestContext)
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageNumber, Value = requestContext.PageNumber });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = RequestContextConstants.PageSize, Value = requestContext.PageSize });
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(workflowconigurationConstants.USP_workflowconiguration_PSY_GET_ALL, sqlparms, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static DataSet GetworkflowconigurationByWFCId(int wFCId)
        {
            try
            {
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(workflowconigurationConstants.USP_workflowconiguration_PSY_GET, workflowconigurationConstants.WFCId, DbType.Int32, wFCId, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool WorkspaceUserMapping(workflowconiguration p_workflowconiguration)
        {
            bool insert = false; List<WorkFlowMapping> lstReviwers = new List<WorkFlowMapping>();
            List<WorkFlowMapping> lstApprovers = new List<WorkFlowMapping>();
            if (p_workflowconiguration != null && p_workflowconiguration.reviewers.Any())
                p_workflowconiguration.reviewers.ForEach(p =>
                {
                    WorkFlowMapping mapping = new WorkFlowMapping();
                    mapping.UserId = Convert.ToInt32(p.UCFId);
                    mapping.UserName = p.UserID;
                    mapping.WorkFlowId = Convert.ToInt32(p_workflowconiguration.WFCId);
                    mapping.WorkFlowName = p_workflowconiguration.workflowName;
                    mapping.Type = "Review";
                    lstReviwers.Add(mapping);
                });
            if (p_workflowconiguration != null && p_workflowconiguration.approvals.Any())
                p_workflowconiguration.approvals.ForEach(p =>
                {
                    WorkFlowMapping mapping = new WorkFlowMapping();
                    mapping.UserId = Convert.ToInt32(p.UCFId);
                    mapping.UserName = p.UserID;
                    mapping.WorkFlowId = Convert.ToInt32(p_workflowconiguration.WFCId);
                    mapping.WorkFlowName = p_workflowconiguration.workflowName;
                    mapping.Type = "Approve";
                    lstApprovers.Add(mapping);
                });
            DataTable workflowusersmappings = GetWorkflowUserMapping();
            if (lstReviwers.Count > 0)
            {
                lstReviwers.ForEach(p =>
                {
                    workflowusersmappings.Rows.Add(p.UserId, p.UserName, p.WorkFlowId, p.WorkFlowName, p.Type);
                });
            }
            if (lstApprovers.Count > 0)
            {
                lstApprovers.ForEach(p =>
                {
                    workflowusersmappings.Rows.Add(p.UserId, p.UserName, p.WorkFlowId, p.WorkFlowName, p.Type);
                });
            }

            List<SqlParameter> sqlparms = new List<SqlParameter>();
            sqlparms.Add(new SqlParameter { SqlDbType = SqlDbType.Structured, ParameterName = "@mappings", Value = workflowusersmappings });
            Object result = dataAccessHelper.ExecuteStoredProcedure("[dbo].[USP_WorkFlowUsersMappings_PSY_INSERT]", sqlparms, ExecutionType.NonQuery);
            return insert;
        }

        public static DataTable GetWorkflowUserMapping()
        {

            DataTable TableInfo = new DataTable("Workflowusrmappings");
            TableInfo.Columns.Add("UserId", typeof(int));
            TableInfo.Columns.Add("UserName", typeof(string));
            TableInfo.Columns.Add("WorkFlowId", typeof(int));
            TableInfo.Columns.Add("WorkFlowName", typeof(string)).DefaultValue = "";
            TableInfo.Columns.Add("Type", typeof(string)).DefaultValue = null;
            return TableInfo;
        }
        public static bool Saveworkflowconiguration(workflowconiguration workflowconiguration)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(workflowconiguration));
                // Create a StringWriter to hold the XML data
                var writer = new StringWriter();

                // Serialize the Person object to XML and write it to the StringWriter
                serializer.Serialize(writer, workflowconiguration);

                // Get the XML string from the StringWriter
                string xmlString = writer.ToString();
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.DocumentMasterId, Value = workflowconiguration.DocumentMasterId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.workflowName_PSY, Value = workflowconiguration.workflowName });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.code, Value = workflowconiguration.code });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.documentstage, Value = workflowconiguration.documentstage });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.documenttype, Value = workflowconiguration.documenttype });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.department, Value = workflowconiguration.departments });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = workflowconigurationConstants.reviewsCount, Value = workflowconiguration.reviewsCount });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = workflowconigurationConstants.approvalsCount, Value = workflowconiguration.approvalsCount });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.CreatedBy, Value = workflowconiguration.CreatedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.ModifiedBy, Value = workflowconiguration.ModifiedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.Status, Value = workflowconiguration.Status });
                sqlparms.Add(new SqlParameter { DbType = DbType.Xml, ParameterName = workflowconigurationConstants.document, Value = xmlString });
                Object result = dataAccessHelper.ExecuteStoredProcedure(workflowconigurationConstants.USP_workflowconiguration_PSY_INSERT, sqlparms, ExecutionType.Scalar);
                if (Convert.ToInt32(result) > 0)
                    workflowconiguration.WFCId = result.ToString();
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool Updateworkflowconiguration(workflowconiguration workflowconiguration)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(workflowconiguration));
                // Create a StringWriter to hold the XML data
                var writer = new StringWriter();

                // Serialize the Person object to XML and write it to the StringWriter
                serializer.Serialize(writer, workflowconiguration);

                // Get the XML string from the StringWriter
                string xmlString = writer.ToString();
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.WFCId, Value = workflowconiguration.WFCId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.DocumentMasterId, Value = workflowconiguration.DocumentMasterId });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.workflowName_PSY, Value = workflowconiguration.workflowName });

                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.documentstage, Value = workflowconiguration.documentstage });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.documenttype, Value = workflowconiguration.documenttype });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.department, Value = workflowconiguration.departments });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = workflowconigurationConstants.reviewsCount, Value = workflowconiguration.reviewsCount });
                sqlparms.Add(new SqlParameter { DbType = DbType.Int32, ParameterName = workflowconigurationConstants.approvalsCount, Value = workflowconiguration.approvalsCount });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.ModifiedBy, Value = workflowconiguration.ModifiedBy });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = workflowconigurationConstants.Status, Value = workflowconiguration.Status });
                sqlparms.Add(new SqlParameter { DbType = DbType.Xml, ParameterName = workflowconigurationConstants.document, Value = xmlString });
                Object result = dataAccessHelper.ExecuteStoredProcedure(workflowconigurationConstants.USP_workflowconiguration_PSY_UPDATE, sqlparms, ExecutionType.Scalar);
                return (Convert.ToInt32(result) > 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteworkflowconigurationByWFCId(int wFCId)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(workflowconigurationConstants.USP_workflowconiguration_PSY_DELETE, workflowconigurationConstants.WFCId, DbType.Int32, wFCId, ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteAllworkflowconiguration(List<int> wFCIds)
        {
            try
            {
                var result = dataAccessHelper.ExecuteStoredProcedure(workflowconigurationConstants.USP_workflowconiguration_PSY_DELETE_ALL, workflowconigurationConstants.WFCId, DbType.String, string.Join(',', wFCIds), ExecutionType.NonQuery);
                return (Convert.ToInt32(result) >= 0);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
