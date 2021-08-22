USE [KPI]
GO

/****** Object:  Table [dbo].[腳色明細]    Script Date: 2021/8/22 下午 09:36:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[腳色明細]') AND type in (N'U'))
DROP TABLE [dbo].[腳色明細]
GO

/****** Object:  Table [dbo].[腳色明細]    Script Date: 2021/8/22 下午 09:36:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[腳色明細](
	[代號] [nvarchar](max) NOT NULL,
	[畫面] [nvarchar](max) NOT NULL,
	[功能] [nvarchar](max) NOT NULL,
	[啟用] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


