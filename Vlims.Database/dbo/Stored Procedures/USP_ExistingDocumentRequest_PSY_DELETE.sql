﻿  CREATE PROCEDURE [dbo].[USP_ExistingDocumentRequest_PSY_DELETE] @EDRId_PSY int 
 AS 
 BEGIN 
  BEGIN TRY 
 DELETE FROM [dbo].[ExistingDocumentRequest_PSY]  WHERE [EDRId_PSY] IN (@EDRId_PSY) 
  END TRY 
 BEGIN CATCH 
 SELECT ERROR_MESSAGE(); 
 END CATCH 
 END