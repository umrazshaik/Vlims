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
    public interface ISecurityManagementService
    {
        
        ResponseContext<SecurityManagement> GetAllSecurityManagement(RequestContext requestContext);
        
        SecurityManagement GetSecurityManagementBySMId(string sMId);
        
        bool SaveSecurityManagement(SecurityManagement securityManagement);
        
        bool UpdateSecurityManagement(SecurityManagement securityManagement);
        
        bool DeleteSecurityManagementBySMId(string sMId);
        
        bool DeleteAllSecurityManagement(List<int> sMIds);
    }
}
