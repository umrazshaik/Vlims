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
    using Vlims.Administration.Manager;
    using Vlims.Common;
    using Vlims.Administration.Entities;


    /// <summary>
    /// Comment
    /// </summary>
    [ApiController()]
    [Route("api/userconfiguration")]
    public class UserConfigurationController : ControllerBase
    {
        
        private readonly IUserConfigurationService userConfigurationService;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userConfigurationService"></param>
        public UserConfigurationController(IUserConfigurationService userConfigurationService)
        {
            this.userConfigurationService = userConfigurationService;
        }
        
        /// <summary>
        /// This method is used to Get List of UserConfiguration
        /// </summary>
        /// <param name="requestContext"></param>
        [HttpPost("getusers")]
        public ActionResult GetAllUserConfiguration(RequestContext requestContext)
        {
            var result = userConfigurationService.GetAllUserConfiguration(requestContext);
            return Ok(result);
        }
        
        /// <summary>
        /// This method is used to Get UserConfiguration By Id uCFId
        /// </summary>
        /// <param name="uCFId"></param>
        [HttpGet("{uCFId}")]
        public ActionResult<UserConfiguration> GetUserConfigurationByUCFId(string uCFId)
        {
            var result = userConfigurationService.GetUserConfigurationByUCFId(uCFId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Save UserConfiguration
        /// </summary>
        /// <param name="userConfiguration"></param>
        [HttpPost("saveuserconfiguration")]
        public ActionResult<System.Boolean> SaveUserConfiguration(UserConfiguration userConfiguration)
        {
            var result = userConfigurationService.SaveUserConfiguration(userConfiguration);
            return result;
        }
        
        /// <summary>
        /// This Method is used to update UserConfiguration
        /// </summary>
        /// <param name="userConfiguration"></param>
        [HttpPost("updateuserconfiguration")]
        public ActionResult<System.Boolean> UpdateUserConfiguration(UserConfiguration userConfiguration)
        {
            var result = userConfigurationService.UpdateUserConfiguration(userConfiguration);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete UserConfiguration By Id uCFId
        /// </summary>
        /// <param name="uCFId"></param>
        [HttpDelete("{uCFId}")]
        public ActionResult<bool> DeleteUserConfigurationByUCFId(string uCFId)
        {
            var result = userConfigurationService.DeleteUserConfigurationByUCFId(uCFId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete UserConfiguration By Multiple ids uCFIds
        /// </summary>
        /// <param name="uCFIds"></param>
        [HttpDelete("deleteAll")]
        public ActionResult<bool> DeleteAllUserConfiguration(List<int> uCFIds)
        {
            var result = userConfigurationService.DeleteAllUserConfiguration(uCFIds);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uMId"></param>
        [HttpGet("getUserConfigurationByUserManagementId/{uMId}")]
        public ActionResult<List<UserConfiguration>> GetUserConfigurationByUserManagementId(System.Int32? uMId)
        {
            var result = userConfigurationService.GetUserConfigurationByUserManagementId(uMId);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uMId"></param>
        [HttpDelete("deleteUserConfigurationByUserManagementId/{uMId}")]
        public ActionResult<bool> DeleteUserConfigurationByUserManagementId(System.Int32? uMId)
        {
            var result = userConfigurationService.DeleteUserConfigurationByUserManagementId(uMId);
            return result;
        }
    }
}
