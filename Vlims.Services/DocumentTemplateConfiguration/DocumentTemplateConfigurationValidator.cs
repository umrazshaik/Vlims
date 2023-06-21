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
    public static class DocumentTemplateConfigurationValidator
    {
        
        public static string IsValidDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration)
        {
            try
            {
                StringBuilder validationMessages = new StringBuilder();
                ValidationHelper validationHelper = new ValidationHelper();
                validationMessages.Append(validationHelper.NullCheckValidator(documentTemplateConfiguration.DTID, nameof(documentTemplateConfiguration.DTID)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.DTID,50, nameof(documentTemplateConfiguration.DTID)));
                validationMessages.Append(validationHelper.NullCheckValidator(documentTemplateConfiguration.DocumentMasterId, nameof(documentTemplateConfiguration.DocumentMasterId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.DocumentMasterId,50, nameof(documentTemplateConfiguration.DocumentMasterId)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.Templatename,50, nameof(documentTemplateConfiguration.Templatename)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.Uniquecode,50, nameof(documentTemplateConfiguration.Uniquecode)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.documenttype,50, nameof(documentTemplateConfiguration.documenttype)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.header,50, nameof(documentTemplateConfiguration.header)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.rows,50, nameof(documentTemplateConfiguration.rows)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.columns,50, nameof(documentTemplateConfiguration.columns)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.footer,50, nameof(documentTemplateConfiguration.footer)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.rows,50, nameof(documentTemplateConfiguration.rows)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.columns,50, nameof(documentTemplateConfiguration.columns)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.CreatedBy,100, nameof(documentTemplateConfiguration.CreatedBy)));
                validationMessages.Append(validationHelper.LengthCheckValidator(documentTemplateConfiguration.ModifiedBy,100, nameof(documentTemplateConfiguration.ModifiedBy)));
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