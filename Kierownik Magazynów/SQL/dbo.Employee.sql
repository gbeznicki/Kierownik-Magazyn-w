USE [WarehouseManager]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 04.11.2018 15:22:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF(OBJECT_ID('dbo.Employee') is not null)
Drop table [dbo].[Employee]
go


CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](200) NOT NULL
) ON [PRIMARY]
GO


