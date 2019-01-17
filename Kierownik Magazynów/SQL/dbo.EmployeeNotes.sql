USE [WarehouseManager]
GO

/****** Object:  Table [dbo].[EmployeeNotes]    Script Date: 04.11.2018 15:56:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF(OBJECT_ID('[dbo].[EmployeeNotes]') is not null)
Drop table [dbo].[EmployeeNotes]
go


CREATE TABLE [dbo].[EmployeeNotes](
	[NoteId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[EmployeeId] [int] foreign key references Employee(employeeId) NOT NULL,
	[NoteText] [varchar](max) NOT NULL,
	[CreationDate] [date] NOT NULL,
	[ModifyDate] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


