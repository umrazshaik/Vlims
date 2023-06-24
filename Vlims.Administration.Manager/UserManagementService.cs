//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.Administration.Manager
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Data;
    using System.Collections.Generic;
    using Vlims.Common;
    using Vlims.Administration.Entities;
    using Vlims.Administration.DataAccess;



    // Comment
    public class UserManagementService : IUserManagementService
    {
        
      
        
        public ResponseContext<UserManagement> GetAllUserManagement(RequestContext requestContext)
        {
            try
            {
                DataSet dataset = UserManagementData.GetAllUserManagement(requestContext);
                List<UserManagement> result = UserManagementConverter.SetAllUserManagement(dataset);
                return new ResponseContext<UserManagement>() { RowCount = CommonConverter.SetRowsCount(dataset), Response = result };
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public UserManagement GetUserManagementByUMId(string uMId)
        {
            try
            {
                DataSet dataset = UserManagementData.GetUserManagementByUMId(uMId);
                UserManagement result = UserManagementConverter.SetUserManagement(dataset);
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool SaveUserManagement(UserManagement userManagement)
        {
            try
            {
                String validationMessages = UserManagementValidator.IsValidUserManagement(userManagement);
                if (validationMessages.Length <= 0)
                {
                    var result = UserManagementData.SaveUserManagement(userManagement);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool UpdateUserManagement(UserManagement userManagement)
        {
            try
            {
                String validationMessages = UserManagementValidator.IsValidUserManagement(userManagement);
                if (validationMessages.Length <= 0)
                {
                    bool result = UserManagementData.UpdateUserManagement(userManagement);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteUserManagementByUMId(string uMId)
        {
            try
            {
                return UserManagementData.DeleteUserManagementByUMId(uMId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAllUserManagement(List<int> uMIds)
        {
            try
            {
                return UserManagementData.DeleteAllUserManagement(uMIds);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}