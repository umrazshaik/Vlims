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
    [Route("api/hierarchymanagement")]
    public class HierarchyManagementController : ControllerBase
    {
        
        private readonly IHierarchyManagementService hierarchyManagementService;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hierarchyManagementService"></param>
        public HierarchyManagementController(IHierarchyManagementService hierarchyManagementService)
        {
            this.hierarchyManagementService = hierarchyManagementService;
        }
        
        /// <summary>
        /// This method is used to Get List of HierarchyManagement
        /// </summary>
        /// <param name="requestContext"></param>
        [HttpPost()]
        public ActionResult<ResponseContext<HierarchyManagement>> GetAllHierarchyManagement(RequestContext requestContext)
        {
            var result = hierarchyManagementService.GetAllHierarchyManagement(requestContext);
            return result;
        }
        
        /// <summary>
        /// This method is used to Get HierarchyManagement By Id hMId
        /// </summary>
        /// <param name="hMId"></param>
        [HttpGet("{hMId}")]
        public ActionResult<HierarchyManagement> GetHierarchyManagementByHMId(string hMId)
        {
            var result = hierarchyManagementService.GetHierarchyManagementByHMId(hMId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Save HierarchyManagement
        /// </summary>
        /// <param name="hierarchyManagement"></param>
        [HttpPost("savehierarchymanagement")]
        public ActionResult<System.Boolean> SaveHierarchyManagement(HierarchyManagement hierarchyManagement)
        {
            var result = hierarchyManagementService.SaveHierarchyManagement(hierarchyManagement);
            return result;
        }
        
        /// <summary>
        /// This Method is used to update HierarchyManagement
        /// </summary>
        /// <param name="hierarchyManagement"></param>
        [HttpPost("updatehierarchymanagement")]
        public ActionResult<System.Boolean> UpdateHierarchyManagement(HierarchyManagement hierarchyManagement)
        {
            var result = hierarchyManagementService.UpdateHierarchyManagement(hierarchyManagement);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete HierarchyManagement By Id hMId
        /// </summary>
        /// <param name="hMId"></param>
        [HttpDelete("{hMId}")]
        public ActionResult<bool> DeleteHierarchyManagementByHMId(string hMId)
        {
            var result = hierarchyManagementService.DeleteHierarchyManagementByHMId(hMId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete HierarchyManagement By Multiple ids hMIds
        /// </summary>
        /// <param name="hMIds"></param>
        [HttpDelete("deleteAll")]
        public ActionResult<bool> DeleteAllHierarchyManagement(List<int> hMIds)
        {
            var result = hierarchyManagementService.DeleteAllHierarchyManagement(hMIds);
            return result;
        }
    }
}
