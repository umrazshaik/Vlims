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
    
    
    
    
    // Comment
    public interface IDocumentPreparationService
    {
        
        ResponseContext<DocumentPreparation> GetAllDocumentPreparation(RequestContext requestContext);
        
        DocumentPreparation GetDocumentPreparationByDPNID(string dPNID);
        
        bool SaveDocumentPreparation(DocumentPreparation documentPreparation);
        
        bool UpdateDocumentPreparation(DocumentPreparation documentPreparation);
        
        bool DeleteDocumentPreparationByDPNID(string dPNID);
        
        bool DeleteAllDocumentPreparation(List<int> dPNIDs);
    }
}
