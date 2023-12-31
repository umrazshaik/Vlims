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
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.CreatedBy, 150, nameof(existingDocumentRequest.CreatedBy)));
            validationMessages.Append(validationHelper.LengthCheckValidator(existingDocumentRequest.ModifiedBy, 150, nameof(existingDocumentRequest.ModifiedBy)));
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

