USE [KPI]
GO

/****** Object:  Table [dbo].[¾�ȥN�z�H]    Script Date: 2021/8/22 �U�� 09:36:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[¾�ȥN�z�H]') AND type in (N'U'))
DROP TABLE [dbo].[¾�ȥN�z�H]
GO

/****** Object:  Table [dbo].[¾�ȥN�z�H]    Script Date: 2021/8/22 �U�� 09:36:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[¾�ȥN�z�H](
	[SYSID] [nvarchar](10) NOT NULL,
	[¾�ȥN�z�H] [nchar](10) NOT NULL,
 CONSTRAINT [PK_¾�ȥN�z�H] PRIMARY KEY CLUSTERED 
(
	[SYSID] ASC,
	[¾�ȥN�z�H] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


