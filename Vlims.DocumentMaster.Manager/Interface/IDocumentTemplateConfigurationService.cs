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
    using System.Collections.Generic;
    using Vlims.Common;
    using Vlims.DocumentMaster.Entities;



    // Comment
    public interface IDocumentTemplateConfigurationService
    {
        
        ResponseContext<DocumentTemplateConfiguration> GetAllDocumentTemplateConfiguration(RequestContext requestContext);
        
        DocumentTemplateConfiguration GetDocumentTemplateConfigurationByDTID(int dTID);
        
        bool SaveDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration);
        
        bool UpdateDocumentTemplateConfiguration(DocumentTemplateConfiguration documentTemplateConfiguration);
        
        bool DeleteDocumentTemplateConfigurationByDTID(int dTID);
        
        bool DeleteAllDocumentTemplateConfiguration(List<int> dTIDs);
    }
}
