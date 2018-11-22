USE [WarehouseManager]
GO

/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 04.11.2018 15:23:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF(OBJECT_ID('[dbo].[EmployeeDetails]') is not null)
Drop table [dbo].[EmployeeDetails]
go


CREATE TABLE [dbo].[EmployeeDetails](
	[DetailsId] [int] identity(1,1) NOT NULL primary key,
	[EmployeeId] [int] foreign key references Employee(employeeId) NOT NULL,
	[HireDate] [date] NOT NULL,
	[DismissDate] [date] NULL,
	[SupervisorId] [int] NULL,
	[DefaultActivity] [varchar](500) NOT NULL
) ON [PRIMARY]
GO


