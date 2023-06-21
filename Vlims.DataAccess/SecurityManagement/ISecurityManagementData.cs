//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicySummary.Sheet1.Data
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using PolicySummary.Common.Entities;
    using PolicySummary.Sheet1.Entities;
    
    
    // Comment
    public interface ISecurityManagementData
    {
        
        DataSet GetAllSecurityManagement(RequestContext requestContext);
        
        DataSet GetSecurityManagementBySMId(string sMId);
        
        bool SaveSecurityManagement(SecurityManagement securityManagement);
        
        bool UpdateSecurityManagement(SecurityManagement securityManagement);
        
        bool DeleteSecurityManagementBySMId(string sMId);
        
        bool DeleteAllSecurityManagement(List<int> sMIds);
    }
}