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
    //using PolicySummary.DMS.Entities;
    //using VAMLIbrary.Core.Extentions;
   // using PolicySummary.Common.Entities;
    using Vlims.DMS.Entities;
    using Vlims.Common;


    // Comment
    public static class AdditionalTaskConverter
    {
        
        public static List<AdditionalTask> SetAllAdditionalTask(DataSet dataset)
        {
            try
            {
                List<AdditionalTask> result = new List<AdditionalTask>();
                AdditionalTask additionalTaskData;
                if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; (i < dataset.Tables[0].Rows.Count); i = (i + 1))
                    {
                        DataRow row = dataset.Tables[0].Rows[i];
                        additionalTaskData = new AdditionalTask();
                        additionalTaskData.ATID = Convert.ToString(row[AdditionalTaskConstants.ATID.Trim('@')]);
                        additionalTaskData.Status = Convert.ToString(row[AdditionalTaskConstants.Status_PSY.Trim('@')]);
                        additionalTaskData.DocumentEffectiveID = Convert.ToInt16(row[AdditionalTaskConstants.DocumentEffective_ID.Trim('@')]);
                        additionalTaskData.CreatedBy = Convert.ToString(row[AdditionalTaskConstants.CreatedBy.Trim('@')]);
                        additionalTaskData.CreatedDate = DatatypeConverter.SetDateTime(row[AdditionalTaskConstants.CreatedDate.Trim('@')]);
                        additionalTaskData.ModifiedBy = Convert.ToString(row[AdditionalTaskConstants.ModifiedBy.Trim('@')]);
                        additionalTaskData.ModifiedDate = DatatypeConverter.SetDateTime(row[AdditionalTaskConstants.ModifiedDate.Trim('@')]);
                        result.Add(additionalTaskData);
                    }
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public static AdditionalTask SetAdditionalTask(DataSet dataset)
        {
            var result = SetAllAdditionalTask(dataset);
            if (result.Count > 0)
            {
                return result.FirstOrDefault();
            }
            return null;
        }
    }
}
