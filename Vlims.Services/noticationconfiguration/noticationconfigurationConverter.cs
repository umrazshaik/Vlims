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
    public static class noticationconfigurationConverter
    {
        
        public static List<noticationconfiguration> SetAllnoticationconfiguration(DataSet dataset)
        {
            try
            {
                List<noticationconfiguration> result = new List<noticationconfiguration>();
                noticationconfiguration noticationconfigurationData;
                if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; (i < dataset.Tables[0].Rows.Count); i = (i + 1))
                    {
                        DataRow row = dataset.Tables[0].Rows[i];
                        noticationconfigurationData = new noticationconfiguration();
                        noticationconfigurationData.NCId = Convert.ToString(row[noticationconfigurationConstants.NCId.TrimAt()]);
                        noticationconfigurationData.DocumentMasterId = Convert.ToString(row[noticationconfigurationConstants.DocumentMasterId.TrimAt()]);
                        noticationconfigurationData.CreatedBy = Convert.ToString(row[noticationconfigurationConstants.CreatedBy.TrimAt()]);
                        noticationconfigurationData.CreatedDate = DatatypeConverter.SetDateTime(row[noticationconfigurationConstants.CreatedDate.TrimAt()]);
                        noticationconfigurationData.ModifiedBy = Convert.ToString(row[noticationconfigurationConstants.ModifiedBy.TrimAt()]);
                        noticationconfigurationData.ModifiedDate = DatatypeConverter.SetDateTime(row[noticationconfigurationConstants.ModifiedDate.TrimAt()]);
                        result.Add(noticationconfigurationData);
                    }
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public static noticationconfiguration Setnoticationconfiguration(DataSet dataset)
        {
            var result = SetAllnoticationconfiguration(dataset);
            if (result.Count > 0)
            {
                return result.FirstOrDefault();
            }
            return null;
        }
    }
}