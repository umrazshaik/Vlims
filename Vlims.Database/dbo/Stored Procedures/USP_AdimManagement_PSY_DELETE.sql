﻿  CREATE PROCEDURE [dbo].[USP_AdimManagement_PSY_DELETE] @AMId_PSY int 
 AS 
 BEGIN 
  BEGIN TRY 
 DELETE FROM [dbo].[AdimManagement_PSY]  WHERE [AMId_PSY] IN (@AMId_PSY) 
  END TRY 
 BEGIN CATCH 
 SELECT ERROR_MESSAGE(); 
 END CATCH 
 END