USE [KPI]
GO

/****** Object:  Table [dbo].[職位]    Script Date: 2021/8/22 下午 09:36:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[職位]') AND type in (N'U'))
DROP TABLE [dbo].[職位]
GO

/****** Object:  Table [dbo].[職位]    Script Date: 2021/8/22 下午 09:36:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[職位](
	[代號] [nvarchar](max) NOT NULL,
	[名稱] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


