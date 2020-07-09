USE [MYDB1]
GO

/****** Object:  Table [dbo].[BookTable]    Script Date: 2020-07-09 오후 12:20:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BookTable](
	[Isbn] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
	[Publisher] [varchar](50) NULL,
	[Page] [int] NULL,
	[UserId] [int] NULL,
	[UserName] [varchar](50) NULL,
	[isBorrowed] [bit] NULL,
	[BorrowedAt] [datetime] NULL,
 CONSTRAINT [PK_BookTable] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

