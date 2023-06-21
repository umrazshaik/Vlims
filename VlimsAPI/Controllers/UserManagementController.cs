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
    [Route("api/usermanagement")]
    public class UserManagementController : ControllerBase
    {
        
        private readonly IUserManagementService userManagementService;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManagementService"></param>
        public UserManagementController(IUserManagementService userManagementService)
        {
            this.userManagementService = userManagementService;
        }
        
        /// <summary>
        /// This method is used to Get List of UserManagement
        /// </summary>
        /// <param name="requestContext"></param>
        [HttpPost()]
        public ActionResult<ResponseContext<UserManagement>> GetAllUserManagement(RequestContext requestContext)
        {
            var result = userManagementService.GetAllUserManagement(requestContext);
            return result;
        }
        
        /// <summary>
        /// This method is used to Get UserManagement By Id uMId
        /// </summary>
        /// <param name="uMId"></param>
        [HttpGet("{uMId}")]
        public ActionResult<UserManagement> GetUserManagementByUMId(string uMId)
        {
            var result = userManagementService.GetUserManagementByUMId(uMId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Save UserManagement
        /// </summary>
        /// <param name="userManagement"></param>
        [HttpPost("saveusermanagement")]
        public ActionResult<System.Boolean> SaveUserManagement(UserManagement userManagement)
        {
            var result = userManagementService.SaveUserManagement(userManagement);
            return result;
        }
        
        /// <summary>
        /// This Method is used to update UserManagement
        /// </summary>
        /// <param name="userManagement"></param>
        [HttpPost("updateusermanagement")]
        public ActionResult<System.Boolean> UpdateUserManagement(UserManagement userManagement)
        {
            var result = userManagementService.UpdateUserManagement(userManagement);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete UserManagement By Id uMId
        /// </summary>
        /// <param name="uMId"></param>
        [HttpDelete("{uMId}")]
        public ActionResult<bool> DeleteUserManagementByUMId(string uMId)
        {
            var result = userManagementService.DeleteUserManagementByUMId(uMId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete UserManagement By Multiple ids uMIds
        /// </summary>
        /// <param name="uMIds"></param>
        [HttpDelete("deleteAll")]
        public ActionResult<bool> DeleteAllUserManagement(List<int> uMIds)
        {
            var result = userManagementService.DeleteAllUserManagement(uMIds);
            return result;
        }
    }
}
