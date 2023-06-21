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
    using VAMLIbrary.Core.Validators;
    
    
    // Comment
    public static class SecurityManagementValidator
    {
        
        public static string IsValidSecurityManagement(SecurityManagement securityManagement)
        {
            try
            {
                StringBuilder validationMessages = new StringBuilder();
                ValidationHelper validationHelper = new ValidationHelper();
                validationMessages.Append(validationHelper.NullCheckValidator(securityManagement.SMId, nameof(securityManagement.SMId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(securityManagement.SMId,50, nameof(securityManagement.SMId)));
                validationMessages.Append(validationHelper.NullCheckValidator(securityManagement.AdminManagerId, nameof(securityManagement.AdminManagerId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(securityManagement.AdminManagerId,50, nameof(securityManagement.AdminManagerId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(securityManagement.MinimumUserIdLength,50, nameof(securityManagement.MinimumUserIdLength)));
                validationMessages.Append(validationHelper.LengthCheckValidator(securityManagement.MinimumPasswordLength,50, nameof(securityManagement.MinimumPasswordLength)));
                validationMessages.Append(validationHelper.LengthCheckValidator(securityManagement.CreatedBy,100, nameof(securityManagement.CreatedBy)));
                validationMessages.Append(validationHelper.LengthCheckValidator(securityManagement.ModifiedBy,100, nameof(securityManagement.ModifiedBy)));
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