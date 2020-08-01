USE [PaymentsDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/31/2020 9:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 7/31/2020 9:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Concept] [nvarchar](250) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Amount] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200731001300_InitialModel', N'3.1.6')
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (1, N'pago inicial', CAST(N'2020-07-30T00:00:00.0000000' AS DateTime2), CAST(1321.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (2, N'nuevo pago', CAST(N'2020-07-29T00:00:00.0000000' AS DateTime2), CAST(1500.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (3, N'abono mensual', CAST(N'2020-07-28T00:00:00.0000000' AS DateTime2), CAST(150.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (5, N'Nuevo abono', CAST(N'2020-07-30T00:00:00.0000000' AS DateTime2), CAST(321.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (6, N'Nombre Pago', CAST(N'2020-07-31T00:00:00.0000000' AS DateTime2), CAST(321.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (7, N'Nuevo Pago', CAST(N'2020-07-31T00:00:00.0000000' AS DateTime2), CAST(984.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Payments] ([Id], [Concept], [Date], [Amount]) VALUES (10, N'Pago Telefono', CAST(N'2019-02-08T00:00:00.0000000' AS DateTime2), CAST(389.0000 AS Decimal(18, 4)))
GO
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
