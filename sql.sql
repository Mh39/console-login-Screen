USE [TIT]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 12/12/2022 12:23:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[Valid] [nvarchar](22) NULL
) ON [PRIMARY]
GO

