//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicySummary.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    
    
    using PolicySummary.Sheet1.Services;
    
    
    /// <summary>
    /// Comment
    /// </summary>
    [ApiController()]
    [Route("api/documenttemplateconfiguration")]
    public class DocumentTemplateConfigurationController : ControllerBase
    {
        
        private readonly IDocumentTemplateConfigurationService documentTemplateConfigurationService;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentTemplateConfigurationService"></param>
        public DocumentTemplateConfigurationController(IDocumentTemplateConfigurationService documentTemplateConfigurationService)
        {
            this.documentTemplateConfigurationService = documentTemplateConfigurationService;
        }
        
        /// <summary>
        /// This method is used to Get List of DocumentTemplateConfiguration
        /// </summary>
        /// <param name="requestContext"></param>
        [HttpPost()]
        public ActionResult<ResponseContext<DocumentTemplateConfiguration>> GetAllDocumentTemplateConfiguration(RequestContext requestContext)
        {
            var result = documentTemplateConfigurationService.GetAllDocumentTemplateConfiguration(requestContext);
            return result;
        }
        
        /// <summary>
        /// This method is used to Get DocumentTemplateConfiguration By Id dTID
        /// </summary>
        /// <param name="dTID"></param>
        [HttpGet("{dTID}")]
        public ActionResult<DocumentTemplateConfiguration> GetDocumentTemplateConfigurationByDTID(int dTID)
        {
            var result = documentTemplateConfigurationService.GetDocumentTemplateConfigurationByDTID(dTID);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Save DocumentTemplateConfiguration
        /// </summary>
        /// <param name="documentTemplateConfiguration"></param>
        [HttpPost("savedocumenttemplateconfiguration")]
        public ActionResult<System.Boolean> SaveDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration)
        {
            var result = documentTemplateConfigurationService.SaveDocumentTemplateConfiguration(documentTemplateConfiguration);
            return result;
        }
        
        /// <summary>
        /// This Method is used to update DocumentTemplateConfiguration
        /// </summary>
        /// <param name="documentTemplateConfiguration"></param>
        [HttpPost("updatedocumenttemplateconfiguration")]
        public ActionResult<System.Boolean> UpdateDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration)
        {
            var result = documentTemplateConfigurationService.UpdateDocumentTemplateConfiguration(documentTemplateConfiguration);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete DocumentTemplateConfiguration By Id dTID
        /// </summary>
        /// <param name="dTID"></param>
        [HttpDelete("{dTID}")]
        public ActionResult<bool> DeleteDocumentTemplateConfigurationByDTID(int dTID)
        {
            var result = documentTemplateConfigurationService.DeleteDocumentTemplateConfigurationByDTID(dTID);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete DocumentTemplateConfiguration By Multiple ids dTIDs
        /// </summary>
        /// <param name="dTIDs"></param>
        [HttpDelete("deleteAll")]
        public ActionResult<bool> DeleteAllDocumentTemplateConfiguration(List<int> dTIDs)
        {
            var result = documentTemplateConfigurationService.DeleteAllDocumentTemplateConfiguration(dTIDs);
            return result;
        }
    }
}
