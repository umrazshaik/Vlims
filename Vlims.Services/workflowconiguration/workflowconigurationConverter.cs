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
    using VAMLIbrary.Core.Extentions;
    using PolicySummary.Common.Entities;
    
    
    // Comment
    public static class workflowconigurationConverter
    {
        
        public static List<workflowconiguration> SetAllworkflowconiguration(DataSet dataset)
        {
            try
            {
                List<workflowconiguration> result = new List<workflowconiguration>();
                workflowconiguration workflowconigurationData;
                if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; (i < dataset.Tables[0].Rows.Count); i = (i + 1))
                    {
                        DataRow row = dataset.Tables[0].Rows[i];
                        workflowconigurationData = new workflowconiguration();
                        workflowconigurationData.WFCId = Convert.ToString(row[workflowconigurationConstants.WFCId.TrimAt()]);
                        workflowconigurationData.DocumentMasterId = Convert.ToString(row[workflowconigurationConstants.DocumentMasterId.TrimAt()]);
                        workflowconigurationData.documentstage = Convert.ToString(row[workflowconigurationConstants.documentstage.TrimAt()]);
                        workflowconigurationData.documenttype = Convert.ToString(row[workflowconigurationConstants.documenttype.TrimAt()]);
                        workflowconigurationData.department = Convert.ToString(row[workflowconigurationConstants.department.TrimAt()]);
                        workflowconigurationData.reviewsCount = DatatypeConverter.SetIntValue(row[workflowconigurationConstants.reviewsCount.TrimAt()]);
                        workflowconigurationData.approvalsCount = DatatypeConverter.SetIntValue(row[workflowconigurationConstants.approvalsCount.TrimAt()]);
                        workflowconigurationData.CreatedBy = Convert.ToString(row[workflowconigurationConstants.CreatedBy.TrimAt()]);
                        workflowconigurationData.CreatedDate = DatatypeConverter.SetDateTime(row[workflowconigurationConstants.CreatedDate.TrimAt()]);
                        workflowconigurationData.ModifiedBy = Convert.ToString(row[workflowconigurationConstants.ModifiedBy.TrimAt()]);
                        workflowconigurationData.ModifiedDate = DatatypeConverter.SetDateTime(row[workflowconigurationConstants.ModifiedDate.TrimAt()]);
                        result.Add(workflowconigurationData);
                    }
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public static workflowconiguration Setworkflowconiguration(DataSet dataset)
        {
            var result = SetAllworkflowconiguration(dataset);
            if (result.Count > 0)
            {
                return result.FirstOrDefault();
            }
            return null;
        }
    }
}