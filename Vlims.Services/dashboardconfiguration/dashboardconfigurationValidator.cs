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
    public static class dashboardconfigurationValidator
    {
        
        public static string IsValiddashboardconfiguration(dashboardconfiguration dashboardconfiguration)
        {
            try
            {
                StringBuilder validationMessages = new StringBuilder();
                ValidationHelper validationHelper = new ValidationHelper();
                validationMessages.Append(validationHelper.LengthCheckValidator(dashboardconfiguration.DCId,50, nameof(dashboardconfiguration.DCId)));
                validationMessages.Append(validationHelper.NullCheckValidator(dashboardconfiguration.DocumentMasterId, nameof(dashboardconfiguration.DocumentMasterId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(dashboardconfiguration.DocumentMasterId,50, nameof(dashboardconfiguration.DocumentMasterId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(dashboardconfiguration.CreatedBy,100, nameof(dashboardconfiguration.CreatedBy)));
                validationMessages.Append(validationHelper.LengthCheckValidator(dashboardconfiguration.ModifiedBy,100, nameof(dashboardconfiguration.ModifiedBy)));
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
