﻿  CREATE PROCEDURE [dbo].[USP_DocumentManager_PSY_By_DMGId_DELETE] @DMGId int 
 AS 
 BEGIN 
  BEGIN TRY 
 DELETE FROM [dbo].[DocumentManager_PSY]  WHERE DMGId_PSY IN (@DMGId) 
  END TRY 
 BEGIN CATCH 
 SELECT ERROR_MESSAGE(); 
 END CATCH 
 END