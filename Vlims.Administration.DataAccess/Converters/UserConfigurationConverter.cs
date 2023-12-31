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
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Data;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Vlims.Administration.Entities;
    using Vlims.Common;



    // Comment
    public static class UserConfigurationConverter
    {

        public static List<UserConfiguration> SetAllUserConfiguration(DataSet dataset, bool isadmin = true)
        {
            try
            {
                List<UserConfiguration> result = new List<UserConfiguration>();
                UserConfiguration userConfigurationData;
                if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                {
                    if (isadmin)
                    {
                        RemoveAdminRecord(dataset);
                    }

                    for (int i = 0; (i < dataset.Tables[0].Rows.Count); i++)
                    {
                        DataRow row = dataset.Tables[0].Rows[i];
                        userConfigurationData = new UserConfiguration();
                        userConfigurationData.UCFId = Convert.ToString(row[UserConfigurationConstants.UCFId.Trim('@')]);
                        userConfigurationData.UserManagementID = Convert.ToString(row[UserConfigurationConstants.UserManagementID.Trim('@')]);
                        userConfigurationData.FirstName = Convert.ToString(row[UserConfigurationConstants.FirstName.Trim('@')]);
                        userConfigurationData.LastName = Convert.ToString(row[UserConfigurationConstants.LastName.Trim('@')]);
                        if (!isadmin)
                            userConfigurationData.UserID = Convert.ToString(row[UserConfigurationConstants.UserID.Trim('@')]);
                        else
                            userConfigurationData.UserID = userConfigurationData.FirstName + userConfigurationData.LastName;//Convert.ToString(row[UserConfigurationConstants.UserID.Trim('@')]);
                        userConfigurationData.Department = Convert.ToString(row[UserConfigurationConstants.Department.Trim('@')]);
                        userConfigurationData.Role = Convert.ToString(row[UserConfigurationConstants.Role.Trim('@')]);
                        userConfigurationData.Doj = Convert.ToString(row[UserConfigurationConstants.Doj.Trim('@')]);
                        userConfigurationData.Empid = DatatypeConverter.SetIntValue(row[UserConfigurationConstants.Empid.Trim('@')]);
                        userConfigurationData.EmailId = Convert.ToString(row[UserConfigurationConstants.EmailId.Trim('@')]);
                        userConfigurationData.Activedirectory = Convert.ToString(row[UserConfigurationConstants.Activedirectory.Trim('@')]);
                        userConfigurationData.Standarduser = Convert.ToString(row[UserConfigurationConstants.Standarduser.Trim('@')]);
                        userConfigurationData.CreatedBy = Convert.ToString(row[UserConfigurationConstants.CreatedBy.Trim('@')]);
                        userConfigurationData.CreatedDate = DatatypeConverter.SetDateTime(row[UserConfigurationConstants.CreatedDate.Trim('@')]);
                        userConfigurationData.ModifiedBy = Convert.ToString(row[UserConfigurationConstants.ModifiedBy.Trim('@')]);
                        userConfigurationData.ModifiedDate = DatatypeConverter.SetDateTime(row[UserConfigurationConstants.ModifiedDate.Trim('@')]);
                        userConfigurationData.Password = Convert.ToString(row[UserConfigurationConstants.Password.Trim('@')]);
                        userConfigurationData.Status = Convert.ToString(row[UserConfigurationConstants.Status.Trim('@')]);
                        result.Add(userConfigurationData);
                    }
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        private static void RemoveAdminRecord(DataSet dataset)
        {
            DataRow foundRow = dataset.Tables[0].AsEnumerable().FirstOrDefault(o => o.Field<string>("UserID_PSY").Equals("admin", StringComparison.InvariantCultureIgnoreCase));
            if (foundRow != null)
            {
                dataset.Tables[0].Rows.Remove(foundRow);
            }
        }

        public static UserConfiguration SetUserConfiguration(DataSet dataset)
        {
            var result = SetAllUserConfiguration(dataset);
            if (result.Count > 0)
            {
                return result.FirstOrDefault();
            }
            return null;
        }

        public static DataTable SetDataSet(List<UserConfiguration> userConfigurations)
        {
            DataTable dataTable = new DataTable();
            DataRow row = null;
            SetDataTableColumns(dataTable);
            try
            {
                if (userConfigurations != null && userConfigurations.Count > 0)
                {
                    for (int i = 0; (i < userConfigurations.Count); i = (i + 1))
                    {
                        row = dataTable.NewRow();
                        row[UserConfigurationConstants.UCFId.Trim()] = userConfigurations[i].UCFId;
                        row[UserConfigurationConstants.UserManagementID.Trim()] = userConfigurations[i].UserManagementID;
                        row[UserConfigurationConstants.FirstName.Trim()] = userConfigurations[i].FirstName;
                        row[UserConfigurationConstants.LastName.Trim()] = userConfigurations[i].LastName;
                        row[UserConfigurationConstants.UserID.Trim()] = userConfigurations[i].UserID;
                        row[UserConfigurationConstants.Department.Trim()] = userConfigurations[i].Department;
                        row[UserConfigurationConstants.Role.Trim()] = userConfigurations[i].Role;
                        row[UserConfigurationConstants.Doj.Trim()] = userConfigurations[i].Doj;
                        row[UserConfigurationConstants.Empid.Trim()] = userConfigurations[i].Empid;
                        row[UserConfigurationConstants.EmailId.Trim()] = userConfigurations[i].EmailId;
                        row[UserConfigurationConstants.Activedirectory.Trim()] = userConfigurations[i].Activedirectory;
                        row[UserConfigurationConstants.Standarduser.Trim()] = userConfigurations[i].Standarduser;
                        row[UserConfigurationConstants.CreatedBy.Trim()] = userConfigurations[i].CreatedBy;
                        row[UserConfigurationConstants.CreatedDate.Trim()] = userConfigurations[i].CreatedDate;
                        row[UserConfigurationConstants.ModifiedBy.Trim()] = userConfigurations[i].ModifiedBy;
                        row[UserConfigurationConstants.Status.Trim()] = userConfigurations[i].Status;
                        row[UserConfigurationConstants.ModifiedDate.Trim()] = userConfigurations[i].ModifiedDate;
                        row[UserConfigurationConstants.Password.Trim()] = userConfigurations[i].Password;
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
            dataTable.TableName = "UT_UserConfiguration_PSY";
            dataTable.Columns.Add(UserConfigurationConstants.UCFId.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.UserManagementID.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.FirstName.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.LastName.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.UserID.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Department.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Role.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Doj.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Empid.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.EmailId.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Activedirectory.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Standarduser.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.CreatedBy.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.CreatedDate.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.ModifiedBy.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.Status.Trim());
            dataTable.Columns.Add(UserConfigurationConstants.ModifiedDate.Trim());
        }
    }
}
