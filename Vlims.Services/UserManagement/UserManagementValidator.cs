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
    
    using VAMLIbrary.Core.Validators;
    
    
    // Comment
    public static class UserManagementValidator
    {
        
        public static string IsValidUserManagement(UserManagement userManagement)
        {
            try
            {
                StringBuilder validationMessages = new StringBuilder();
                ValidationHelper validationHelper = new ValidationHelper();
                validationMessages.Append(validationHelper.NullCheckValidator(userManagement.UMId, nameof(userManagement.UMId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.UMId,50, nameof(userManagement.UMId)));
                validationMessages.Append(validationHelper.NullCheckValidator(userManagement.AdminManagerId, nameof(userManagement.AdminManagerId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.AdminManagerId,50, nameof(userManagement.AdminManagerId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.UserConfiguration,50, nameof(userManagement.UserConfiguration)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.Status,50, nameof(userManagement.Status)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.UserGroupConfiguration,50, nameof(userManagement.UserGroupConfiguration)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.AuditLogs,50, nameof(userManagement.AuditLogs)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.CreatedBy,100, nameof(userManagement.CreatedBy)));
                validationMessages.Append(validationHelper.LengthCheckValidator(userManagement.ModifiedBy,100, nameof(userManagement.ModifiedBy)));
                if (!String.IsNullOrEmpty(validationMessages.ToString()))
                {
                    return Convert.ToString(validationMessages.Remove(validationMessages.ToString().LastIndexOf(','),1));
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
