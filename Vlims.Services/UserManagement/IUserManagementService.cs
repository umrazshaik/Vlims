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
    
    
    // Comment
    public interface IUserManagementService
    {
        
        ResponseContext<UserManagement> GetAllUserManagement(RequestContext requestContext);
        
        UserManagement GetUserManagementByUMId(string uMId);
        
        bool SaveUserManagement(UserManagement userManagement);
        
        bool UpdateUserManagement(UserManagement userManagement);
        
        bool DeleteUserManagementByUMId(string uMId);
        
        bool DeleteAllUserManagement(List<int> uMIds);
    }
}