USE [WarehouseManager]
GO

/****** Object:  Table [dbo].[Agency]    Script Date: 04.11.2018 15:00:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF(OBJECT_ID('dbo.Agency') is not null)
Drop table dbo.Agency
go

CREATE TABLE [dbo].[Agency](
	[AgencyId] [int] Identity(1,1) NOT NULL PRIMARY KEY,
	[AgencyName] [varchar](500) NOT NULL
) ON [PRIMARY]
GO


