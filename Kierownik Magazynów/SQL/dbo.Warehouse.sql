USE [WarehouseManager]
GO

/****** Object:  Table [dbo].[Warehouse]    Script Date: 04.11.2018 15:59:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF(OBJECT_ID('[dbo].[Warehouse]') is not null)
Drop table [dbo].[Warehouse]
go

CREATE TABLE [dbo].[Warehouse](
	[WarehouseId] [int] NOT NULL PRIMARY KEY,
	[Name] [varchar](500) NOT NULL
) ON [PRIMARY]
GO


