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
    using Vlims.Common;
    using Vlims.DocumentMaster.Entities;
    using Vlims.DocumentMaster.DataAccess;

    // Comment
    public class workflowconigurationService : IworkflowconigurationService
    {
        
        
        
        public ResponseContext<workflowconiguration> GetAllworkflowconiguration(RequestContext requestContext)
        {
            try
            {
                DataSet dataset = workflowconigurationData.GetAllworkflowconiguration(requestContext);
                List<workflowconiguration> result = workflowconigurationConverter.SetAllworkflowconiguration(dataset);
                return new ResponseContext<workflowconiguration>() { RowCount = CommonConverter.SetRowsCount(dataset), Response = result };
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public workflowconiguration GetworkflowconigurationByWFCId(int wFCId)
        {
            try
            {
                DataSet dataset = workflowconigurationData.GetworkflowconigurationByWFCId(wFCId);
                workflowconiguration result = workflowconigurationConverter.Setworkflowconiguration(dataset);
                return result;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool Saveworkflowconiguration(workflowconiguration workflowconiguration)
        {
            try
            {
                String validationMessages = workflowconigurationValidator.IsValidworkflowconiguration(workflowconiguration);
                if (validationMessages.Length <= 0)
                {
                    var result = workflowconigurationData.Saveworkflowconiguration(workflowconiguration);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool Updateworkflowconiguration(workflowconiguration workflowconiguration)
        {
            try
            {
                String validationMessages = workflowconigurationValidator.IsValidworkflowconiguration(workflowconiguration);
                if (validationMessages.Length <= 0)
                {
                    bool result = workflowconigurationData.Updateworkflowconiguration(workflowconiguration);
                    return result;
                }
                throw new System.Exception(validationMessages);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteworkflowconigurationByWFCId(int wFCId)
        {
            try
            {
                return workflowconigurationData.DeleteworkflowconigurationByWFCId(wFCId);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        
        public bool DeleteAllworkflowconiguration(List<int> wFCIds)
        {
            try
            {
                return workflowconigurationData.DeleteAllworkflowconiguration(wFCIds);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}