//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.DocumentManager.DataAccess
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Data;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    //  using VAMLIbrary.Core.Validators;
    using Vlims.DMS.Entities;
    using Vlims.Common;


    // Comment
    public static class AdditionalTaskValidator
    {

        public static string IsValidAdditionalTask(AdditionalTask additionalTask)
        {
            try
            {
                StringBuilder validationMessages = new StringBuilder();
                ValidationHelper validationHelper = new ValidationHelper();
                validationMessages.Append(validationHelper.NullCheckValidator(additionalTask.ATID, nameof(additionalTask.ATID)));
                validationMessages.Append(validationHelper.LengthCheckValidator(additionalTask.ATID, 150, nameof(additionalTask.ATID)));
                //validationMessages.Append(validationHelper.NullCheckValidator(additionalTask.DocumentEffectiveID, nameof(additionalTask.DocumentEffectiveID)));
                //validationMessages.Append(validationHelper.LengthCheckValidator(additionalTask.DocumentEffectiveID,50, nameof(additionalTask.DocumentEffectiveID)));
                validationMessages.Append(validationHelper.LengthCheckValidator(additionalTask.CreatedBy, 150, nameof(additionalTask.CreatedBy)));
                validationMessages.Append(validationHelper.LengthCheckValidator(additionalTask.ModifiedBy, 150, nameof(additionalTask.ModifiedBy)));
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
