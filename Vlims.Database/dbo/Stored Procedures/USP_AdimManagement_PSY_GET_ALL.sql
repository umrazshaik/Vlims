﻿ CREATE PROCEDURE [dbo].[USP_AdimManagement_PSY_GET_ALL]  @PageSize  INT=50, @PageNumber INT=1  
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
 ,count(*) over() as TotalRows 
 FROM [dbo].[AdimManagement_PSY] WITH (NOLOCK) 
 Order by [AMId_PSY]  
 OFFSET @PageSize * (@PageNumber - 1) ROWS 
  FETCH NEXT @PageSize ROWS ONLY; 
  END TRY 
 BEGIN CATCH 
  SELECT ERROR_MESSAGE(); 
 END CATCH 
 END