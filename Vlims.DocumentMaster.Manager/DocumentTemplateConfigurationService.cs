//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.DocumentMaster.Manager
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using Vlims.Common;
    using Vlims.DocumentMaster.Entities;
    using Vlims.DocumentMaster.DataAccess;
    using Vlims.Services;

    // Comment
    public class DocumentTemplateConfigurationService : IDocumentTemplateConfigurationService
    {
        
        public ResponseContext<DocumentTemplateConfiguration> GetAllDocumentTemplateConfiguration(RequestContext requestContext)
        {
            try
            {
                DataSet dataset = DocumentTemplateConfigurationData.GetAllDocumentTemplateConfiguration(requestContext);
                List<DocumentTemplateConfiguration> result = DocumentTemplateConfigurationConverter.SetAllDocumentTemplateConfiguration(dataset);
                return new ResponseContext<DocumentTemplateConfiguration>() { RowCount = CommonConverter.SetRowsCount(dataset), Response = result };
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public DocumentTemplateConfiguration GetDocumentTemplateConfigurationByDTID(int dTID)
        {
            try
            {
                DataSet dataset = DocumentTemplateConfigurationData.GetDocumentTemplateConfigurationByDTID(dTID);
                DocumentTemplateConfiguration result = DocumentTemplateConfigurationConverter.SetDocumentTemplateConfiguration(dataset);
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool SaveDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration)
        {
            try
            {
                documentTemplateConfiguration.Status = "In-Progress";
                if (documentTemplateConfiguration!=null && documentTemplateConfiguration.DocumentMasterId==null)
                {
                    documentTemplateConfiguration.DocumentMasterId = "1";
                    documentTemplateConfiguration.header = "header";
                    documentTemplateConfiguration.footer = "footer";
                }
                String validationMessages = DocumentTemplateConfigurationValidator.IsValidDocumentTemplateConfiguration(documentTemplateConfiguration);
                if (validationMessages.Length <= 0)
                {
                    var result = DocumentTemplateConfigurationData.SaveDocumentTemplateConfiguration(documentTemplateConfiguration);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool UpdateDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration)
        {
            try
            {
                String validationMessages = DocumentTemplateConfigurationValidator.IsValidDocumentTemplateConfiguration(documentTemplateConfiguration);
                if (validationMessages.Length <= 0)
                {
                    bool result = DocumentTemplateConfigurationData.UpdateDocumentTemplateConfiguration(documentTemplateConfiguration);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteDocumentTemplateConfigurationByDTID(int dTID)
        {
            try
            {
                return DocumentTemplateConfigurationData.DeleteDocumentTemplateConfigurationByDTID(dTID);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAllDocumentTemplateConfiguration(List<int> dTIDs)
        {
            try
            {
                return DocumentTemplateConfigurationData.DeleteAllDocumentTemplateConfiguration(dTIDs);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
