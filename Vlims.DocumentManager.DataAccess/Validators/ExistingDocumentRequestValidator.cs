//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using Newtonsoft.Json;
using Vlims.Common;



// Comment
public static class ExistingDocumentRequestValidator
{

    public static string IsValidExistingDocumentRequest(ExistingDocumentRequest existingDocumentRequest)
    {
        try
        {
            StringBuilder validationMessages = new StringBuilder();
            ValidationHelper validationHelper = new ValidationHelper();
            validationMessages.Append(validationHelper.NullCheckValidator(existingDocumentRequest.EDRId, nameof(existingDocumentRequest.EDRId)));
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.EDRId, 50, nameof(existingDocumentRequest.EDRId)));
            validationMessages.Append(validationHelper.NullCheckValidator(existingDocumentRequest.Documentmanagerid, nameof(existingDocumentRequest.Documentmanagerid)));
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.Documentmanagerid, 50, nameof(existingDocumentRequest.Documentmanagerid)));
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.reason, 50, nameof(existingDocumentRequest.reason)));
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.CreatedBy, 100, nameof(existingDocumentRequest.CreatedBy)));
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.ModifiedBy, 100, nameof(existingDocumentRequest.ModifiedBy)));
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
