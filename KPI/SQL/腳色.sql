USE [KPI]
GO

/****** Object:  Table [dbo].[腳色]    Script Date: 2021/8/22 下午 09:35:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[腳色]') AND type in (N'U'))
DROP TABLE [dbo].[腳色]
GO

/****** Object:  Table [dbo].[腳色]    Script Date: 2021/8/22 下午 09:35:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[腳色](
	[代號] [nvarchar](max) NOT NULL,
	[名稱] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


