//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>g
//------------------------------------------------------------------------------

namespace Vlims.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Vlims.Administration.Entities;
    using Vlims.Administration.Manager;
    using Vlims.Common;


    /// <summary>
    /// Comment
    /// </summary>
    [ApiController()]
    [Route("api/departmentconfiguration")]
    public class DepartmentConfigurationController : ControllerBase
    {
        
        private readonly IDepartmentConfigurationService departmentConfigurationService;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departmentConfigurationService"></param>
        public DepartmentConfigurationController(IDepartmentConfigurationService departmentConfigurationService)
        {
            this.departmentConfigurationService = departmentConfigurationService;
        }
        
        /// <summary>
        /// This method is used to Get List of DepartmentConfiguration
        /// </summary>
        /// <param name="requestContext"></param>
        [HttpPost("getdepartments")]
        public ActionResult GetAllDepartmentConfiguration([FromQuery] RequestContext requestContext)
        {
            var result = departmentConfigurationService.GetAllDepartmentConfiguration(requestContext);
            return Ok(result);
        }
        
        /// <summary>
        /// This method is used to Get DepartmentConfiguration By Id dPCFId
        /// </summary>
        /// <param name="dPCFId"></param>
        [HttpGet("{dPCFId}")]
        public ActionResult<DepartmentConfiguration> GetDepartmentConfigurationByDPCFId(string dPCFId)
        {
            var result = departmentConfigurationService.GetDepartmentConfigurationByDPCFId(dPCFId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Save DepartmentConfiguration
        /// </summary>
        /// <param name="departmentConfiguration"></param>
        [HttpPost("savedepartmentconfiguration")]
        public ActionResult<System.Boolean> SaveDepartmentConfiguration(DepartmentConfiguration departmentConfiguration)
        {
            //RequestContext reqCxt = new RequestContext();
            //reqCxt.PageNumber = 1;reqCxt.PageSize = 50;
            //var resultDeparts = departmentConfigurationService.GetAllDepartmentConfiguration(reqCxt);
            //if(resultDeparts.Response.Count(item=>item.DepartmentName.Equals(departmentConfiguration.DepartmentName))==1)
            //{
            //    //Raise duplicate validation
            //   return Ok(false);
            //}
            var result = departmentConfigurationService.SaveDepartmentConfiguration(departmentConfiguration);
            return result;
        }
        /// <summary>
        /// This method is used to Get DocumentTypeConfiguration By Id dTCId
        /// </summary>
        /// <param name="dTCId"></param>
        [HttpGet("getbyId")]
        public ActionResult<DepartmentConfiguration> GetDocumentTypeConfigurationByDTCId(int dTCId)
        {
            var result = departmentConfigurationService.GetDepartmentConfigurationByDPCFId(dTCId.ToString());
            return result;
        }
        /// <summary>
        /// This Method is used to update DepartmentConfiguration
        /// </summary>
        /// <param name="departmentConfiguration"></param>
        [HttpPost("updatedepartmentconfiguration")]
        public ActionResult<System.Boolean> UpdateDepartmentConfiguration(DepartmentConfiguration departmentConfiguration)
        {
            var result = departmentConfigurationService.UpdateDepartmentConfiguration(departmentConfiguration);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete DepartmentConfiguration By Id dPCFId
        /// </summary>
        /// <param name="dPCFId"></param>
        [HttpDelete("{dPCFId}")]
        public ActionResult<bool> DeleteDepartmentConfigurationByDPCFId(string dPCFId)
        {
            var result = departmentConfigurationService.DeleteDepartmentConfigurationByDPCFId(dPCFId);
            return result;
        }
        
        /// <summary>
        /// This Method is used to Delete DepartmentConfiguration By Multiple ids dPCFIds
        /// </summary>
        /// <param name="dPCFIds"></param>
        [HttpDelete("deleteAll")]
        public ActionResult<bool> DeleteAllDepartmentConfiguration(List<int> dPCFIds)
        {
            var result = departmentConfigurationService.DeleteAllDepartmentConfiguration(dPCFIds);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hMId"></param>
        [HttpGet("getDepartmentConfigurationByHierarchyManagementId/{hMId}")]
        public ActionResult<List<DepartmentConfiguration>> GetDepartmentConfigurationByHierarchyManagementId(System.Int32? hMId)
        {
            var result = departmentConfigurationService.GetDepartmentConfigurationByHierarchyManagementId(hMId);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hMId"></param>
        [HttpDelete("deleteDepartmentConfigurationByHierarchyManagementId/{hMId}")]
        public ActionResult<bool> DeleteDepartmentConfigurationByHierarchyManagementId(System.Int32? hMId)
        {
            var result = departmentConfigurationService.DeleteDepartmentConfigurationByHierarchyManagementId(hMId);
            return result;
        }
    }
}
