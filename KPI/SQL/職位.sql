USE [KPI]
GO

/****** Object:  Table [dbo].[¾��]    Script Date: 2021/8/22 �U�� 09:36:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[¾��]') AND type in (N'U'))
DROP TABLE [dbo].[¾��]
GO

/****** Object:  Table [dbo].[¾��]    Script Date: 2021/8/22 �U�� 09:36:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[¾��](
	[�N��] [nvarchar](max) NOT NULL,
	[�W��] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


