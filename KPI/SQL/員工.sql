USE [KPI]
GO

/****** Object:  Table [dbo].[���u]    Script Date: 2021/8/22 �U�� 09:34:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[���u]') AND type in (N'U'))
DROP TABLE [dbo].[���u]
GO

/****** Object:  Table [dbo].[���u]    Script Date: 2021/8/22 �U�� 09:34:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[���u](
	[SYSID] [nvarchar](10) NOT NULL,
	[�N��] [nvarchar](max) NOT NULL,
	[�W��] [nvarchar](max) NOT NULL,
	[�b¾] [bit] NOT NULL,
	[����] [nvarchar](max) NOT NULL,
	[¾��] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_���u] PRIMARY KEY CLUSTERED 
(
	[SYSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


