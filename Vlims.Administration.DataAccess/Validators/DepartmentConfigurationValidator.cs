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
    using Vlims.Common;
    using Vlims.Administration.Entities;


    // Comment
    public static class DepartmentConfigurationValidator
    {

        public static string IsValidDepartmentConfiguration(DepartmentConfiguration departmentConfiguration)
        {
            try
            {
                StringBuilder validationMessages = new StringBuilder();
                ValidationHelper validationHelper = new ValidationHelper();
                //validationMessages.Append(validationHelper.NullCheckValidator(departmentConfiguration.DPCFId, nameof(departmentConfiguration.DPCFId)));
                //validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.DPCFId,150, nameof(departmentConfiguration.DPCFId)));
                validationMessages.Append(validationHelper.NullCheckValidator(departmentConfiguration.HierarchyManagementId, nameof(departmentConfiguration.HierarchyManagementId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.HierarchyManagementId, 150, nameof(departmentConfiguration.HierarchyManagementId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.DepartmentName, 150, nameof(departmentConfiguration.DepartmentName)));
                validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.DepartmentCode, 150, nameof(departmentConfiguration.DepartmentCode)));
                validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.Comments, 500, nameof(departmentConfiguration.Comments)));
                validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.CreatedBy, 150, nameof(departmentConfiguration.CreatedBy)));
                validationMessages.Append(validationHelper.LengthCheckValidator(departmentConfiguration.ModifiedBy, 150, nameof(departmentConfiguration.ModifiedBy)));
                if (!String.IsNullOrEmpty(validationMessages.ToString()))
                {
                    return Convert.ToString(validationMessages.Remove(validationMessages.ToString().LastIndexOf(','), 1));
                }
                else
                {
                    return Convert.ToString(validationMessages);
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
