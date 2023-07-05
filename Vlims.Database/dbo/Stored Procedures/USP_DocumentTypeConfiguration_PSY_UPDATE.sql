﻿  CREATE PROCEDURE [dbo].[USP_DocumentTypeConfiguration_PSY_UPDATE] @DTCId_PSY int, @DocumentMasterId_PSY NVarChar(50),
@Documenttypename_PSY NVarChar(50),
@documenttypeprefix_PSY NVarChar(50),
@Description_PSY NVarChar(50),
@Assigntodepartment_PSY NVarChar(50),
@ModifiedBy_PSY NVarChar(100) 
 AS 
 BEGIN 
  BEGIN TRY 
  
 UPDATE [dbo].[DocumentTypeConfiguration_PSY] SET DocumentMasterId_PSY=@DocumentMasterId_PSY,
Documenttypename_PSY=@Documenttypename_PSY,
documenttypeprefix_PSY=@documenttypeprefix_PSY,
Description_PSY=@Description_PSY,
Assigntodepartment_PSY=@Assigntodepartment_PSY,
ModifiedBy_PSY=@ModifiedBy_PSY WHERE  [DTCId_PSY] = @DTCId_PSY ;  select @DTCId_PSY; 
  
  END TRY 
 BEGIN CATCH 
 SELECT ERROR_MESSAGE(); 
 END CATCH 
 END