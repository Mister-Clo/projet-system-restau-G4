USE [restaurant]
GO
/****** Object:  Table [dbo].[TYPE_RECETTE]    Script Date: 2020-12-17 11:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPE_RECETTE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
 CONSTRAINT [TYPE_RECETTE_PK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TYPE_RECETTE] ON 

INSERT [dbo].[TYPE_RECETTE] ([id], [nom]) VALUES (1, N'Feuillete au crabe')
INSERT [dbo].[TYPE_RECETTE] ([id], [nom]) VALUES (2, N'Oeufs cocotte')
INSERT [dbo].[TYPE_RECETTE] ([id], [nom]) VALUES (3, N'Bouillinade d''anguilles ou de poissons')
INSERT [dbo].[TYPE_RECETTE] ([id], [nom]) VALUES (4, N'Boles de picoulats')
INSERT [dbo].[TYPE_RECETTE] ([id], [nom]) VALUES (5, N'Blanquette de veau')
INSERT [dbo].[TYPE_RECETTE] ([id], [nom]) VALUES (6, N'Gaspatcho')
SET IDENTITY_INSERT [dbo].[TYPE_RECETTE] OFF
GO
