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
    using Vlims.Entities.Common;
    using Vlims.Entities;



    // Comment
    public interface IUserGroupConfigurationData
    {
        
        DataSet GetAllUserGroupConfiguration(RequestContext requestContext);
        
        DataSet GetUserGroupConfigurationByUgcid(string ugcid);
        
        bool SaveUserGroupConfiguration(UserGroupConfiguration userGroupConfiguration);
        
        bool UpdateUserGroupConfiguration(UserGroupConfiguration userGroupConfiguration);
        
        bool DeleteUserGroupConfigurationByUgcid(string ugcid);
        
        bool DeleteAllUserGroupConfiguration(List<int> ugcids);
        
        DataSet GetUserGroupConfigurationByUserManagementId(System.Int32? uMId);
        
        bool DeleteUserGroupConfigurationByUserManagementId(System.Int32? uMId);
    }
}
