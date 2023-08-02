﻿  CREATE PROCEDURE [dbo].[USP_ExistingDocumentRequest_PSY_By_Documentmanagerid_GET] @Documentmanagerid int 
 AS 
 BEGIN 
 BEGIN TRY 
  SELECT EDRId_PSY,
Documentmanagerid_PSY,
documentno_PSY,
documenttitle_PSY,
printtype_PSY,
noofcopies_PSY,
workflow_PSY,
reason_PSY,
browse_PSY,
sampletemplate_PSY,
CreatedBy_PSY,
CreatedDate_PSY,
ModifiedBy_PSY,
ModifiedDate_PSY 
  FROM [dbo].[ExistingDocumentRequest_PSY] WITH (NOLOCK) where Documentmanagerid_PSY = @Documentmanagerid   
 END TRY 
 BEGIN CATCH 
  SELECT ERROR_MESSAGE(); 
 END CATCH 
 END