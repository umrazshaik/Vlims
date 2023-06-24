//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.DocumentMaster.DataAccess
{
    using System;
    using System.Linq;
    using System.Data;
    using System.Collections.Generic;
    using Vlims.Common;
    using Vlims.DocumentMaster.Entities;


    // Comment
    public static class DocumentTemplateConfigurationConverter
    {
        
        public static List<DocumentTemplateConfiguration> SetAllDocumentTemplateConfiguration(DataSet dataset)
        {
            try
            {
                List<DocumentTemplateConfiguration> result = new List<DocumentTemplateConfiguration>();
                DocumentTemplateConfiguration documentTemplateConfigurationData;
                if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; (i < dataset.Tables[0].Rows.Count); i = (i + 1))
                    {
                        DataRow row = dataset.Tables[0].Rows[i];
                        documentTemplateConfigurationData = new DocumentTemplateConfiguration();
                        documentTemplateConfigurationData.DTID = Convert.ToString(row[DocumentTemplateConfigurationConstants.DTID.Trim()]);
                        documentTemplateConfigurationData.DocumentMasterId = Convert.ToString(row[DocumentTemplateConfigurationConstants.DocumentMasterId.Trim()]);
                        documentTemplateConfigurationData.Templatename = Convert.ToString(row[DocumentTemplateConfigurationConstants.Templatename.Trim()]);
                        documentTemplateConfigurationData.Uniquecode = Convert.ToString(row[DocumentTemplateConfigurationConstants.Uniquecode.Trim()]);
                        documentTemplateConfigurationData.documenttype = Convert.ToString(row[DocumentTemplateConfigurationConstants.documenttype.Trim()]);
                        documentTemplateConfigurationData.header = Convert.ToString(row[DocumentTemplateConfigurationConstants.header.Trim()]);
                        documentTemplateConfigurationData.rows = Convert.ToString(row[DocumentTemplateConfigurationConstants.rows.Trim()]);
                        documentTemplateConfigurationData.columns = Convert.ToString(row[DocumentTemplateConfigurationConstants.columns.Trim()]);
                        documentTemplateConfigurationData.footer = Convert.ToString(row[DocumentTemplateConfigurationConstants.footer.Trim()]);
                        documentTemplateConfigurationData.rows = Convert.ToString(row[DocumentTemplateConfigurationConstants.rows.Trim()]);
                        documentTemplateConfigurationData.columns = Convert.ToString(row[DocumentTemplateConfigurationConstants.columns.Trim()]);
                        documentTemplateConfigurationData.CreatedBy = Convert.ToString(row[DocumentTemplateConfigurationConstants.CreatedBy.Trim()]);
                        documentTemplateConfigurationData.CreatedDate = DatatypeConverter.SetDateTime(row[DocumentTemplateConfigurationConstants.CreatedDate.Trim()]);
                        documentTemplateConfigurationData.ModifiedBy = Convert.ToString(row[DocumentTemplateConfigurationConstants.ModifiedBy.Trim()]);
                        documentTemplateConfigurationData.ModifiedDate = DatatypeConverter.SetDateTime(row[DocumentTemplateConfigurationConstants.ModifiedDate.Trim()]);
                        result.Add(documentTemplateConfigurationData);
                    }
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public static DocumentTemplateConfiguration SetDocumentTemplateConfiguration(DataSet dataset)
        {
            var result = SetAllDocumentTemplateConfiguration(dataset);
            if (result.Count > 0)
            {
                return result.FirstOrDefault();
            }
            return null;
        }
    }
}