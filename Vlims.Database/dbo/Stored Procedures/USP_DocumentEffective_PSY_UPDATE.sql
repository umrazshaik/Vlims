﻿
  CREATE PROCEDURE [dbo].[USP_DocumentEffective_PSY_UPDATE] @DEID_PSY int, @Documentmanagerid_PSY NVarChar(50),
@documenttitle_PSY NVarChar(50),
@documentno_PSY NVarChar(50),
@documenttype_PSY NVarChar(50),
@department_PSY NVarChar(50),
@document_PSY NVarChar(500),
@EffectiveDate_PSY DateTime,
@Reviewdate_PSY DateTime,
@ModifiedBy_PSY NVarChar(100),
@Status_PSY NVarChar(50),
@wokflow_PSY NVarChar(50)
 AS 
 BEGIN 
  BEGIN TRY 
  
  DECLARE @ISWORKITEMS BIT
  IF (SELECT COUNT(*) FROM dbo.DocumentEffective_PSY WHERE DEID_PSY = @DEID_PSY AND Workflow_PSY IS NULL) > 0
  BEGIN
  SET @ISWORKITEMS=1;
  END

 UPDATE [dbo].[DocumentEffective_PSY] SET Documentmanagerid_PSY=@Documentmanagerid_PSY,
documenttitle_PSY=@documenttitle_PSY,
documentno_PSY=@documentno_PSY,
documenttype_PSY=@documenttype_PSY,
department_PSY=@department_PSY,
document_PSY=@document_PSY,
EffectiveDate_PSY=@EffectiveDate_PSY,
Reviewdate_PSY=@Reviewdate_PSY,
ModifiedBy_PSY=@ModifiedBy_PSY,
Status_PSY=@Status_PSY,
Workflow_PSY=@wokflow_PSY
WHERE  [DEID_PSY] = @DEID_PSY ;  

IF(@ISWORKITEMS=1)
BEGIN
INSERT into workitems_PSY(TaskName_PSY,TaskType_PSY,Stage_PSY,AssignedToGroup_PSY,InitiatedBy_PSY,InitiatedOn_PSY,Status_PSY,DueDate_PSY,RefrenceId_PSY,ActionType_PSY,IsCompleted_PSY)
 SELECT @documenttype_PSY,'Effective','Pending',NULL,WSR.UserName,GetDate(),'IN-PROGRESS',GetDate(),@DEID_PSY,WSR.Type,0 from WorkflowUsersMapping WSR WHERE WSR.WorkFlowName=@wokflow_PSY AND WSR.Type='Review'

 INSERT into workitems_PSY(TaskName_PSY,TaskType_PSY,Stage_PSY,AssignedToGroup_PSY,InitiatedBy_PSY,InitiatedOn_PSY,Status_PSY,DueDate_PSY,RefrenceId_PSY,ActionType_PSY,IsCompleted_PSY)
 SELECT @documenttype_PSY,'Effective','Pending',NULL,WSR.UserName,GetDate(),'IN-PROGRESS',GetDate(),@DEID_PSY,WSR.Type,0 from WorkflowUsersMapping WSR WHERE WSR.WorkFlowName=@wokflow_PSY AND WSR.Type='Approve'
END

IF(@Status_PSY!='IN-PROGRESS' AND @Status_PSY!='IN PROGRESS')
BEGIN
EXEC [dbo].[USP_UpdateWorkItemsByReferenceId_PSY] @Status_PSY,@DEID_PSY,@ModifiedBy_PSY,'EFFECTIVE'
END

DECLARE @referenceId int=0; set @referenceId=(select Refrence_PSY from DocumentEffective_PSY where DEID_PSY=@DEID_PSY)


IF(@Status_PSY='APPROVED' OR @Status_PSY='APPROVE')
BEGIN
DECLARE @ID INT DECLARE @printID int,@version int=0
SET @version=(SELECT COUNT(*)+1 FROM AdditionalTask_PSY WHERE Refrence_PSY=@referenceId AND Status_PSY='APPROVED')
INSERT INTO AdditionalTask_PSY(DocumentEffective_ID,CreatedBy_PSY,CreatedDate_PSY,ModifiedBy_PSY,ModifiedDate_PSY,Status_PSY,Version,Refrence_PSY)
VALUES(@DEID_PSY,
@ModifiedBy_PSY,GetDate(),@ModifiedBy_PSY,GetDate(),'APPROVED',@version,@referenceId)
SELECT @ID = @@IDENTITY;

--INSERT INTO DocumentPrint_PSY(documenttitle_PSY,printtype_PSY,documentno_PSY,noofcopies_PSY,workflow_PSY,reason_PSY,CreatedBy_PSY,CreatedDate_PSY,
--ModifiedBy_PSY,ModifiedDate_PSY,Status_PSY,Refrence_PSY)
--select dp.documenttitle_PSY,dp.documenttype_PSY,dp.documentno_PSY,0,
--dp.wokflow_PSY,null,@ModifiedBy_PSY,GETDATE(),@ModifiedBy_PSY,GETDATE(),'In-Progress',@referenceId from DocumentPreparation_PSY dp where DPNID_PSY=@Documentmanagerid_PSY;
--SELECT @printID=@@IDENTITY;

--INSERT into workitems_PSY(TaskName_PSY,TaskType_PSY,Stage_PSY,AssignedToGroup_PSY,InitiatedBy_PSY,InitiatedOn_PSY,Status_PSY,DueDate_PSY,RefrenceId_PSY,ActionType_PSY,IsCompleted_PSY)
-- SELECT @documenttype_PSY,'Print','Pending',NULL,WSR.UserName,GetDate(),'IN-PROGRESS',GetDate(),@printID,WSR.Type,0 from WorkflowUsersMapping WSR WHERE WSR.WorkFlowName=@wokflow_PSY AND WSR.Type='Review'

-- INSERT into workitems_PSY(TaskName_PSY,TaskType_PSY,Stage_PSY,AssignedToGroup_PSY,InitiatedBy_PSY,InitiatedOn_PSY,Status_PSY,DueDate_PSY,RefrenceId_PSY,ActionType_PSY,IsCompleted_PSY)
-- SELECT @documenttype_PSY,'Print','Pending',NULL,WSR.UserName,GetDate(),'IN-PROGRESS',GetDate(),@printID,WSR.Type,0 from WorkflowUsersMapping WSR WHERE WSR.WorkFlowName=@wokflow_PSY AND WSR.Type='Approve'

SELECT @ID = @@IDENTITY;

END

IF(@Status_PSY='REJECT' OR @Status_PSY='REJECTED')
BEGIN
DECLARE @REF INT=0
SET @REF=(SELECT Documentmanagerid_PSY FROM DocumentEffective_PSY WHERE DEID_PSY=@DEID_PSY)
DELETE FROM workitems_PSY WHERE RefrenceId_PSY=@DEID_PSY
DELETE FROM DocumentEffective_PSY WHERE DEID_PSY=@DEID_PSY

UPDATE DocumentPreparation_PSY SET Status_PSY='IN-PROGRESS' WHERE DPNID_PSY=@REF
UPDATE workitems_PSY SET Stage_PSY='Pending',Status_PSY='IN-PROGRESS',IsCompleted_PSY=0 WHERE RefrenceId_PSY=@REF


END

select @DEID_PSY; 

  END TRY 
 BEGIN CATCH 
 SELECT ERROR_MESSAGE(); 
 END CATCH 
 END
GO


