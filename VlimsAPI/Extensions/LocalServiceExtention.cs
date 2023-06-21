//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicySummary.Sheet1.API.Extensions
{
    using System.IO;
    using System.Text;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PolicySummary.Sheet1.Services;
    using PolicySummary.Sheet1.Data;
    using VAMLibrary.Core;
    
    
    public static class LocalServiceExtention
    {
        
        public static void RegisterLocalServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<DataAccessHelper>();
            serviceCollection.AddScoped<IDocumentMasterService, DocumentMasterService>();
            serviceCollection.AddScoped<IDocumentMasterData, DocumentMasterData>();
            serviceCollection.AddScoped<IMasterDataService, MasterDataService>();
            serviceCollection.AddScoped<IMasterDataData, MasterDataData>();
            serviceCollection.AddScoped<IDocumentTypeConfigurationService, DocumentTypeConfigurationService>();
            serviceCollection.AddScoped<IDocumentTypeConfigurationData, DocumentTypeConfigurationData>();
            serviceCollection.AddScoped<IDocumentTemplateConfigurationService, DocumentTemplateConfigurationService>();
            serviceCollection.AddScoped<IDocumentTemplateConfigurationData, DocumentTemplateConfigurationData>();
            serviceCollection.AddScoped<IworkflowconigurationService, workflowconigurationService>();
            serviceCollection.AddScoped<IworkflowconigurationData, workflowconigurationData>();
            serviceCollection.AddScoped<InoticationconfigurationService, noticationconfigurationService>();
            serviceCollection.AddScoped<InoticationconfigurationData, noticationconfigurationData>();
            serviceCollection.AddScoped<IdashboardconfigurationService, dashboardconfigurationService>();
            serviceCollection.AddScoped<IdashboardconfigurationData, dashboardconfigurationData>();
            serviceCollection.AddScoped<IDocumentManagerService, DocumentManagerService>();
            serviceCollection.AddScoped<IDocumentManagerData, DocumentManagerData>();
            serviceCollection.AddScoped<IDocumentrequestService, DocumentrequestService>();
            serviceCollection.AddScoped<IDocumentrequestData, DocumentrequestData>();
            serviceCollection.AddScoped<IDocumentPreparationService, DocumentPreparationService>();
            serviceCollection.AddScoped<IDocumentPreparationData, DocumentPreparationData>();
            serviceCollection.AddScoped<IDocumentEffectiveService, DocumentEffectiveService>();
            serviceCollection.AddScoped<IDocumentEffectiveData, DocumentEffectiveData>();
            serviceCollection.AddScoped<IAdditionalTaskService, AdditionalTaskService>();
            serviceCollection.AddScoped<IAdditionalTaskData, AdditionalTaskData>();
            serviceCollection.AddScoped<IDocumentRevisionService, DocumentRevisionService>();
            serviceCollection.AddScoped<IDocumentRevisionData, DocumentRevisionData>();
            serviceCollection.AddScoped<IAdimManagementService, AdimManagementService>();
            serviceCollection.AddScoped<IAdimManagementData, AdimManagementData>();
            serviceCollection.AddScoped<ISecurityManagementService, SecurityManagementService>();
            serviceCollection.AddScoped<ISecurityManagementData, SecurityManagementData>();
            serviceCollection.AddScoped<IHierarchyManagementService, HierarchyManagementService>();
            serviceCollection.AddScoped<IHierarchyManagementData, HierarchyManagementData>();
            serviceCollection.AddScoped<IDepartmentConfigurationService, DepartmentConfigurationService>();
            serviceCollection.AddScoped<IDepartmentConfigurationData, DepartmentConfigurationData>();
            serviceCollection.AddScoped<IRoleConfigurationService, RoleConfigurationService>();
            serviceCollection.AddScoped<IRoleConfigurationData, RoleConfigurationData>();
            serviceCollection.AddScoped<IPlantManagementService, PlantManagementService>();
            serviceCollection.AddScoped<IPlantManagementData, PlantManagementData>();
            serviceCollection.AddScoped<IUserManagementService, UserManagementService>();
            serviceCollection.AddScoped<IUserManagementData, UserManagementData>();
            serviceCollection.AddScoped<IUserConfigurationService, UserConfigurationService>();
            serviceCollection.AddScoped<IUserConfigurationData, UserConfigurationData>();
            serviceCollection.AddScoped<IUserGroupConfigurationService, UserGroupConfigurationService>();
            serviceCollection.AddScoped<IUserGroupConfigurationData, UserGroupConfigurationData>();
        }
    }
}