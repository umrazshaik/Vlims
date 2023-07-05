﻿CREATE TABLE [dbo].[Documentrequest_PSY] (
    [DRID_PSY]              INT            IDENTITY (1, 1) NOT NULL,
    [documentmanagerid_PSY] NVARCHAR (50)  NOT NULL,
    [documenttype_PSY]      NVARCHAR (50)  NULL,
    [department_PSY]        NVARCHAR (50)  NULL,
    [Purpose_PSY]           NVARCHAR (50)  NULL,
    [ApprovalsCount_PSY]    INT            NULL,
    [AssigntoGroup_PSY]     NVARCHAR (50)  NULL,
    [CreatedBy_PSY]         NVARCHAR (100) NULL,
    [CreatedDate_PSY]       DATETIME       NULL,
    [ModifiedBy_PSY]        NVARCHAR (100) NULL,
    [ModifiedDate_PSY]      DATETIME       NULL,
    CONSTRAINT [PK_Documentrequest_PSY] PRIMARY KEY CLUSTERED ([DRID_PSY] ASC)
);
