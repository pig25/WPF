USE [KPI]
GO

/****** Object:  Table [dbo].[帳號]    Script Date: 2021/8/22 下午 09:35:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[帳號]') AND type in (N'U'))
DROP TABLE [dbo].[帳號]
GO

/****** Object:  Table [dbo].[帳號]    Script Date: 2021/8/22 下午 09:35:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[帳號](
	[密碼] [nvarchar](max) NOT NULL,
	[啟用] [nvarchar](max) NOT NULL,
	[腳色] [nvarchar](max) NOT NULL,
	[SYSID] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_帳號] PRIMARY KEY CLUSTERED 
(
	[SYSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


