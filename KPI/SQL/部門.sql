USE [KPI]
GO

/****** Object:  Table [dbo].[场]    Script Date: 2021/8/22 と 09:35:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[场]') AND type in (N'U'))
DROP TABLE [dbo].[场]
GO

/****** Object:  Table [dbo].[场]    Script Date: 2021/8/22 と 09:35:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[场](
	[腹] [nvarchar](max) NOT NULL,
	[嘿] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


