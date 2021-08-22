USE [KPI]
GO

/****** Object:  Table [dbo].[�b��]    Script Date: 2021/8/22 �U�� 09:35:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[�b��]') AND type in (N'U'))
DROP TABLE [dbo].[�b��]
GO

/****** Object:  Table [dbo].[�b��]    Script Date: 2021/8/22 �U�� 09:35:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[�b��](
	[�K�X] [nvarchar](max) NOT NULL,
	[�ҥ�] [nvarchar](max) NOT NULL,
	[�}��] [nvarchar](max) NOT NULL,
	[SYSID] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_�b��] PRIMARY KEY CLUSTERED 
(
	[SYSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


