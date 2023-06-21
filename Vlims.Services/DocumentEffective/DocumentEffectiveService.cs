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
    using PolicySummary.Common.Entities;
    using PolicySummary.Sheet1.Entities;
    using PolicySummary.Sheet1.Data;
    
    
    // Comment
    public class DocumentEffectiveService : IDocumentEffectiveService
    {
        
        private readonly IDocumentEffectiveData documentEffectiveData;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentEffectiveData"></param>
        public DocumentEffectiveService(IDocumentEffectiveData documentEffectiveData)
        {
            this.documentEffectiveData = documentEffectiveData;
        }
        
        public ResponseContext<DocumentEffective> GetAllDocumentEffective(RequestContext requestContext)
        {
            try
            {
                DataSet dataset = documentEffectiveData.GetAllDocumentEffective(requestContext);
                List<DocumentEffective> result = DocumentEffectiveConverter.SetAllDocumentEffective(dataset);
                return new ResponseContext<DocumentEffective>() { RowCount = CommonConverter.SetRowsCount(dataset), Response = result };
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public DocumentEffective GetDocumentEffectiveByDEID(string dEID)
        {
            try
            {
                DataSet dataset = documentEffectiveData.GetDocumentEffectiveByDEID(dEID);
                DocumentEffective result = DocumentEffectiveConverter.SetDocumentEffective(dataset);
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool SaveDocumentEffective(DocumentEffective documentEffective)
        {
            try
            {
                String validationMessages = DocumentEffectiveValidator.IsValidDocumentEffective(documentEffective);
                if (validationMessages.Length <= 0)
                {
                    var result = documentEffectiveData.SaveDocumentEffective(documentEffective);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool UpdateDocumentEffective(DocumentEffective documentEffective)
        {
            try
            {
                String validationMessages = DocumentEffectiveValidator.IsValidDocumentEffective(documentEffective);
                if (validationMessages.Length <= 0)
                {
                    bool result = documentEffectiveData.UpdateDocumentEffective(documentEffective);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteDocumentEffectiveByDEID(string dEID)
        {
            try
            {
                return documentEffectiveData.DeleteDocumentEffectiveByDEID(dEID);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAllDocumentEffective(List<int> dEIDs)
        {
            try
            {
                return documentEffectiveData.DeleteAllDocumentEffective(dEIDs);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}