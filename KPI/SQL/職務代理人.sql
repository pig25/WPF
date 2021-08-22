USE [KPI]
GO

/****** Object:  Table [dbo].[職務代理人]    Script Date: 2021/8/22 下午 09:36:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[職務代理人]') AND type in (N'U'))
DROP TABLE [dbo].[職務代理人]
GO

/****** Object:  Table [dbo].[職務代理人]    Script Date: 2021/8/22 下午 09:36:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[職務代理人](
	[SYSID] [nvarchar](10) NOT NULL,
	[職務代理人] [nchar](10) NOT NULL,
 CONSTRAINT [PK_職務代理人] PRIMARY KEY CLUSTERED 
(
	[SYSID] ASC,
	[職務代理人] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


