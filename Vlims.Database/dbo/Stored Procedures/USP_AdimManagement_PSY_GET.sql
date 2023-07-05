﻿  CREATE PROCEDURE [dbo].[USP_AdimManagement_PSY_GET] @AMId_PSY int 
 AS 
 BEGIN 
 BEGIN TRY 
  SELECT AMId_PSY,
SecurityManagement_PSY,
HierarchyManagement_PSY,
PlantManagement_PSY,
UserManagement_PSY,
CreatedBy_PSY,
CreatedDate_PSY,
ModifiedBy_PSY,
ModifiedDate_PSY 
  FROM [dbo].[AdimManagement_PSY] WITH (NOLOCK) where [AMId_PSY] = @AMId_PSY   
 END TRY 
 BEGIN CATCH 
  SELECT ERROR_MESSAGE(); 
 END CATCH 
 END