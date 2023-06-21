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
    public class UserManagementService : IUserManagementService
    {
        
        private readonly IUserManagementData userManagementData;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManagementData"></param>
        public UserManagementService(IUserManagementData userManagementData)
        {
            this.userManagementData = userManagementData;
        }
        
        public ResponseContext<UserManagement> GetAllUserManagement(RequestContext requestContext)
        {
            try
            {
                DataSet dataset = userManagementData.GetAllUserManagement(requestContext);
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
                DataSet dataset = userManagementData.GetUserManagementByUMId(uMId);
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
                    var result = userManagementData.SaveUserManagement(userManagement);
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
                    bool result = userManagementData.UpdateUserManagement(userManagement);
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
                return userManagementData.DeleteUserManagementByUMId(uMId);
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
                return userManagementData.DeleteAllUserManagement(uMIds);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}