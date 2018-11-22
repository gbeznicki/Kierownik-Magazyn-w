USE [WarehouseManager]
GO

/****** Object:  Table [dbo].[Range]    Script Date: 04.11.2018 16:00:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF(OBJECT_ID('[dbo].[Range]') is not null)
Drop table [dbo].[Range]
go


CREATE TABLE [dbo].[Range](
	[RangeId] [int] NOT NULL PRIMARY KEY,
	[WarehouseId] [int]  foreign key references Warehouse(warehouseId) NOT NULL,
	[AgencyId] [int]  foreign key references Agency(agencyId) NOT NULL,
	[RangeFrom] [int] NOT NULL,
	[RangeTo] [int] NOT NULL,
	[TotalRange] [int] NOT NULL
) ON [PRIMARY]
GO


