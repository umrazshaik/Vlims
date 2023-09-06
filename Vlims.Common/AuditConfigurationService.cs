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
    using System.Collections.Generic;
    using Vlims.Common;



    // Comment
    public class AuditConfigurationService : IAuditConfigurationService
    {        

        List<AuditLogEntity> IAuditConfigurationService.GetAllAuditConfiguration(string type)
        {
            return AuditLog.GetAllAuditConfiguration(type);
        }


        bool IAuditConfigurationService.SaveAuditConfiguration(AuditLogEntity auditLog)
        {
            switch (auditLog.state)
            {
                case DefinitionStatus.New:
                    auditLog.Action = Actions.Added;
                    auditLog.Message = "Added" + auditLog.Type.ToLower() + " " + auditLog.EntityName;
                    break;
                case DefinitionStatus.Modify:
                    auditLog.Action = Actions.Modified;
                    auditLog.Message = "Updated" + auditLog.Type.ToLower() + " " + auditLog.EntityName;
                    break;
                default:
                    break;
            }
            AuditLog.InsertAuditLog(auditLog);
            return true;
        }
    }
}
