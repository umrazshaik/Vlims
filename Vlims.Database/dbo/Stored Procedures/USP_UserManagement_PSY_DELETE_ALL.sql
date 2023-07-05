﻿  CREATE PROCEDURE [dbo].[USP_UserManagement_PSY_DELETE_ALL] @UMId_PSY nvarchar(max)  
 AS 
 BEGIN 
  BEGIN TRY 
 DELETE FROM [dbo].[UserManagement_PSY] WHERE [UMId_PSY] IN (select value from STRING_SPLIT(@UMId_PSY, ',')) 
  END TRY 
 BEGIN CATCH 
 SELECT ERROR_MESSAGE(); 
 END CATCH 
 END