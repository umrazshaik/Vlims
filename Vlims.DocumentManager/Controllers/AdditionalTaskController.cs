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
    using Vlims.DMS.Entities;
    using Vlims.Common;
    using Vlims.DocumentManager.Manager;


    /// <summary>
    /// Comment
    /// </summary>
    [ApiController()]
    [Route("api/additionaltask")]
    public class AdditionalTaskController : ControllerBase
    {

        private readonly IAdditionalTaskService additionalTaskService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="additionalTaskService"></param>
        public AdditionalTaskController(IAdditionalTaskService additionalTaskService)
        {
            this.additionalTaskService = additionalTaskService;
        }

        /// <summary>
        /// This method is used to Get List of AdditionalTask
        /// </summary>
        /// <param name="requestContext"></param>
        [HttpPost("GetAddtask")]
        public ActionResult GetAllAdditionalTask([FromQuery] RequestContext requestContext)
        {
            var result = additionalTaskService.GetAllAdditionalTask(requestContext);
            return Ok(result);
        }

        /// <summary>
        /// This method is used to Get AdditionalTask By Id aTID
        /// </summary>
        /// <param name="aTID"></param>
        [HttpGet("getbyId")]
        public ActionResult<AdditionalTask> GetAdditionalTaskByATID(int aTID)
        {
            var result = additionalTaskService.GetAdditionalTaskByATID(aTID);
            return result;
        }

        /// <summary>
        /// This Method is used to Save AdditionalTask
        /// </summary>
        /// <param name="additionalTask"></param>
        [HttpPost("saveadditionaltask")]
        public ActionResult<System.Boolean> SaveAdditionalTask(AdditionalTask additionalTask)
        {
            var result = additionalTaskService.SaveAdditionalTask(additionalTask);
            return result;
        }

        /// <summary>
        /// This Method is used to update AdditionalTask
        /// </summary>
        /// <param name="additionalTask"></param>
        [HttpPost("updateadditionaltask")]
        public ActionResult<System.Boolean> UpdateAdditionalTask(AdditionalTask additionalTask)
        {
            var result = additionalTaskService.UpdateAdditionalTask(additionalTask);
            return result;
        }

        /// <summary>
        /// This Method is used to Delete AdditionalTask By Id aTID
        /// </summary>
        /// <param name="aTID"></param>
        [HttpDelete("{aTID}")]
        public ActionResult<bool> DeleteAdditionalTaskByATID(string aTID)
        {
            var result = additionalTaskService.DeleteAdditionalTaskByATID(aTID);
            return result;
        }

        /// <summary>
        /// This Method is used to Delete AdditionalTask By Multiple ids aTIDs
        /// </summary>
        /// <param name="aTIDs"></param>
        [HttpDelete("deleteAll")]
        public ActionResult<bool> DeleteAllAdditionalTask(List<int> aTIDs)
        {
            var result = additionalTaskService.DeleteAllAdditionalTask(aTIDs);
            return result;
        }
    }
}
