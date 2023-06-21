//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicySummary.Sheet1.Services
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Data;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using PolicySummary.Sheet1.Entities;
    using VAMLIbrary.Core.Extentions;
    using PolicySummary.Common.Entities;
    
    
    // Comment
    public static class DepartmentConfigurationConverter
    {
        
        public static List<DepartmentConfiguration> SetAllDepartmentConfiguration(DataSet dataset)
        {
            try
            {
                List<DepartmentConfiguration> result = new List<DepartmentConfiguration>();
                DepartmentConfiguration departmentConfigurationData;
                if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; (i < dataset.Tables[0].Rows.Count); i = (i + 1))
                    {
                        DataRow row = dataset.Tables[0].Rows[i];
                        departmentConfigurationData = new DepartmentConfiguration();
                        departmentConfigurationData.DPCFId = Convert.ToString(row[DepartmentConfigurationConstants.DPCFId.TrimAt()]);
                        departmentConfigurationData.HierarchyManagementId = Convert.ToString(row[DepartmentConfigurationConstants.HierarchyManagementId.TrimAt()]);
                        departmentConfigurationData.DepartmentName = Convert.ToString(row[DepartmentConfigurationConstants.DepartmentName.TrimAt()]);
                        departmentConfigurationData.DepartmentCode = Convert.ToString(row[DepartmentConfigurationConstants.DepartmentCode.TrimAt()]);
                        departmentConfigurationData.Comments = Convert.ToString(row[DepartmentConfigurationConstants.Comments.TrimAt()]);
                        departmentConfigurationData.CreatedBy = Convert.ToString(row[DepartmentConfigurationConstants.CreatedBy.TrimAt()]);
                        departmentConfigurationData.CreatedDate = DatatypeConverter.SetDateTime(row[DepartmentConfigurationConstants.CreatedDate.TrimAt()]);
                        departmentConfigurationData.ModifiedBy = Convert.ToString(row[DepartmentConfigurationConstants.ModifiedBy.TrimAt()]);
                        departmentConfigurationData.ModifiedDate = DatatypeConverter.SetDateTime(row[DepartmentConfigurationConstants.ModifiedDate.TrimAt()]);
                        result.Add(departmentConfigurationData);
                    }
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public static DepartmentConfiguration SetDepartmentConfiguration(DataSet dataset)
        {
            var result = SetAllDepartmentConfiguration(dataset);
            if (result.Count > 0)
            {
                return result.FirstOrDefault();
            }
            return null;
        }
        
        public static DataTable SetDataSet(List<DepartmentConfiguration> departmentConfigurations)
        {
            DataTable dataTable = new DataTable();
            DataRow row = null;
            SetDataTableColumns(dataTable);
            try
            {
                if (departmentConfigurations != null && departmentConfigurations.Count > 0)
                {
                    for (int i = 0; (i < departmentConfigurations.Count); i = (i + 1))
                    {
                        row = dataTable.NewRow();
                        row[DepartmentConfigurationConstants.DPCFId.TrimAt()] = departmentConfigurations[i].DPCFId;
                        row[DepartmentConfigurationConstants.HierarchyManagementId.TrimAt()] = departmentConfigurations[i].HierarchyManagementId;
                        row[DepartmentConfigurationConstants.DepartmentName.TrimAt()] = departmentConfigurations[i].DepartmentName;
                        row[DepartmentConfigurationConstants.DepartmentCode.TrimAt()] = departmentConfigurations[i].DepartmentCode;
                        row[DepartmentConfigurationConstants.Comments.TrimAt()] = departmentConfigurations[i].Comments;
                        row[DepartmentConfigurationConstants.CreatedBy.TrimAt()] = departmentConfigurations[i].CreatedBy;
                        row[DepartmentConfigurationConstants.CreatedDate.TrimAt()] = departmentConfigurations[i].CreatedDate;
                        row[DepartmentConfigurationConstants.ModifiedBy.TrimAt()] = departmentConfigurations[i].ModifiedBy;
                        row[DepartmentConfigurationConstants.ModifiedDate.TrimAt()] = departmentConfigurations[i].ModifiedDate;
                        dataTable.Rows.Add(row);
                    }
                }
                return dataTable;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        private static void SetDataTableColumns(DataTable dataTable)
        {
            dataTable.TableName = "UT_DepartmentConfiguration_PSY";
            dataTable.Columns.Add(DepartmentConfigurationConstants.DPCFId.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.HierarchyManagementId.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.DepartmentName.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.DepartmentCode.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.Comments.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.CreatedBy.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.CreatedDate.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.ModifiedBy.TrimAt());
            dataTable.Columns.Add(DepartmentConfigurationConstants.ModifiedDate.TrimAt());
        }
    }
}