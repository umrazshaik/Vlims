//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.DocumentMaster.Manager
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using Vlims.DocumentMaster.Entities;
    using Vlims.DocumentMaster.DataAccess;
    using Vlims.Common;
    using Vlims.Services;

    // Comment
    public class dashboardconfigurationService : IdashboardconfigurationService
    {
        
        
        
        public ResponseContext<dashboardconfiguration> GetAlldashboardconfiguration(RequestContext requestContext)
        {
            try
            {
                DataSet dataset = dashboardconfigurationData.GetAlldashboardconfiguration(requestContext);
                List<dashboardconfiguration> result = dashboardconfigurationConverter.SetAlldashboardconfiguration(dataset);
                return new ResponseContext<dashboardconfiguration>() { RowCount = CommonConverter.SetRowsCount(dataset), Response = result };
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public dashboardconfiguration GetdashboardconfigurationByDCId(int dCId)
        {
            try
            {
                DataSet dataset = dashboardconfigurationData.GetdashboardconfigurationByDCId(dCId);
                dashboardconfiguration result = dashboardconfigurationConverter.Setdashboardconfiguration(dataset);
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool Savedashboardconfiguration(dashboardconfiguration dashboardconfiguration)
        {
            try
            {
                String validationMessages = dashboardconfigurationValidator.IsValiddashboardconfiguration(dashboardconfiguration);
                if (validationMessages.Length <= 0)
                {
                    var result = dashboardconfigurationData.Savedashboardconfiguration(dashboardconfiguration);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool Updatedashboardconfiguration(dashboardconfiguration dashboardconfiguration)
        {
            try
            {
                String validationMessages = dashboardconfigurationValidator.IsValiddashboardconfiguration(dashboardconfiguration);
                if (validationMessages.Length <= 0)
                {
                    bool result = dashboardconfigurationData.Updatedashboardconfiguration(dashboardconfiguration);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeletedashboardconfigurationByDCId(int dCId)
        {
            try
            {
                return dashboardconfigurationData.DeletedashboardconfigurationByDCId(dCId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAlldashboardconfiguration(List<int> dCIds)
        {
            try
            {
                return dashboardconfigurationData.DeleteAlldashboardconfiguration(dCIds);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}