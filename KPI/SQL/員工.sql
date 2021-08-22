USE [KPI]
GO

/****** Object:  Table [dbo].[員工]    Script Date: 2021/8/22 下午 09:34:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[員工]') AND type in (N'U'))
DROP TABLE [dbo].[員工]
GO

/****** Object:  Table [dbo].[員工]    Script Date: 2021/8/22 下午 09:34:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[員工](
	[SYSID] [nvarchar](10) NOT NULL,
	[代號] [nvarchar](max) NOT NULL,
	[名稱] [nvarchar](max) NOT NULL,
	[在職] [bit] NOT NULL,
	[部門] [nvarchar](max) NOT NULL,
	[職位] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_員工] PRIMARY KEY CLUSTERED 
(
	[SYSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


