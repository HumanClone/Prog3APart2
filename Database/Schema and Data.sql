USE [FarmerTracker]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22/05/2023 18:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Pname] [varchar](20) NULL,
	[Ptype] [varchar](20) NULL,
	[Pdate] [datetime] NULL,
	[Price] [money] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/05/2023 18:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[Farmer] [varchar](3) NULL,
	[UserPassword] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (1, N'Grapes', N'Fruit', CAST(N'2023-03-06T00:00:00.000' AS DateTime), 100.0000, 4)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (2, N'Bananas', N'Fruit', CAST(N'2023-01-09T00:00:00.000' AS DateTime), 50.0000, 4)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (3, N'Carrots', N'Vegetable', CAST(N'2023-04-11T00:00:00.000' AS DateTime), 60.0000, 4)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (4, N'Beef', N'Meat', CAST(N'2023-05-01T00:00:00.000' AS DateTime), 200.0000, 4)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (5, N'Milk', N'Dairy', CAST(N'2023-02-22T00:00:00.000' AS DateTime), 100.0000, 3)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (6, N'Eggs', N'Other', CAST(N'2023-03-23T00:00:00.000' AS DateTime), 50.0000, 3)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (7, N'Wheat', N'Grain', CAST(N'2023-05-24T00:00:00.000' AS DateTime), 50.0000, 5)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (8, N'Corn Flour', N'Grain', CAST(N'2023-08-16T00:00:00.000' AS DateTime), 50.0000, 5)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (9, N'Flour', N'Grain', CAST(N'2023-06-13T00:00:00.000' AS DateTime), 40.0000, 5)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (10, N'Potato', N'Vegetable', CAST(N'2023-02-06T00:00:00.000' AS DateTime), 50.0000, 1)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (11, N'Chicken', N'Meat', CAST(N'2023-05-12T00:00:00.000' AS DateTime), 60.0000, 1)
INSERT [dbo].[Products] ([ProductId], [Pname], [Ptype], [Pdate], [Price], [UserId]) VALUES (12, N'Cheese', N'Dairy', CAST(N'2023-05-10T00:00:00.000' AS DateTime), 120.0000, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FullName], [Email], [PhoneNumber], [Farmer], [UserPassword]) VALUES (1, N'Alex Johnson', N'alexjohnson789@example.com', N'0152369845', N'Yes', N'$2a$11$p6rIHsN2LVBW0BtPLAg59OecH0a94WSmpHHc4MiPA2uhCxjgLk93a')
INSERT [dbo].[Users] ([UserId], [FullName], [Email], [PhoneNumber], [Farmer], [UserPassword]) VALUES (2, N'John Doe', N'johndoe123@example.com', N'0316978264', N'No', N'$2a$11$f2h2EOTpbfcLY8J6FAKpAee43O0oRzeUBWFZaGlt0U.iM.7dIrykm')
INSERT [dbo].[Users] ([UserId], [FullName], [Email], [PhoneNumber], [Farmer], [UserPassword]) VALUES (3, N'Emily Jones', N'emilyjones234@example.com', N'0123698754', N'Yes', N'$2a$11$5tLD5H35Piw7A.3bWQgQeeNXOsmNzKz4pxJEjOiX8reXQqVmo9FM2')
INSERT [dbo].[Users] ([UserId], [FullName], [Email], [PhoneNumber], [Farmer], [UserPassword]) VALUES (4, N'Mark Thompson', N'markthompson567@example.com', N'0546987621', N'Yes', N'$2a$11$9XMALSBs4CT2gt5fHgHHcuKX0YS.5u7X0Sg.scNoLPsBBec9HBHg6')
INSERT [dbo].[Users] ([UserId], [FullName], [Email], [PhoneNumber], [Farmer], [UserPassword]) VALUES (5, N'Jen Brown', N'jenniferbrown890@example.com', N'0369542368', N'Yes', N'$2a$11$6Sqhfe2FSGGnxmkoh95by.f.G2YI1gAZvXdfCVLblIKdFb0.Hcbqm')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
