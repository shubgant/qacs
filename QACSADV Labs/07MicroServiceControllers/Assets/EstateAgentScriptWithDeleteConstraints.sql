USE [master]
GO

/****** Object:  Database [estateagent]    Script Date: 25/07/2024 16:12:48 ******/
DROP DATABASE [estateagent]
GO

/****** Object:  Database [estateagent]    Script Date: 25/07/2024 16:12:48 ******/
CREATE DATABASE [estateagent]
GO

USE [estateagent]
GO
ALTER TABLE [dbo].[property] DROP CONSTRAINT [FK_property_seller]
GO
ALTER TABLE [dbo].[property] DROP CONSTRAINT [FK_property_buyer]
GO
ALTER TABLE [dbo].[booking] DROP CONSTRAINT [FK_booking_property]
GO
ALTER TABLE [dbo].[booking] DROP CONSTRAINT [FK_booking_buyer]
GO
/****** Object:  Table [dbo].[seller]    Script Date: 25/07/2024 15:07:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[seller]') AND type in (N'U'))
DROP TABLE [dbo].[seller]
GO
/****** Object:  Table [dbo].[property]    Script Date: 25/07/2024 15:07:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[property]') AND type in (N'U'))
DROP TABLE [dbo].[property]
GO
/****** Object:  Table [dbo].[buyer]    Script Date: 25/07/2024 15:07:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[buyer]') AND type in (N'U'))
DROP TABLE [dbo].[buyer]
GO
/****** Object:  Table [dbo].[booking]    Script Date: 25/07/2024 15:07:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[booking]') AND type in (N'U'))
DROP TABLE [dbo].[booking]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 25/07/2024 15:07:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type in (N'U'))
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 25/07/2024 15:07:38 ******/
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
/****** Object:  Table [dbo].[booking]    Script Date: 25/07/2024 15:07:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booking](
	[BOOKING_ID] [int] IDENTITY(1,1) NOT NULL,
	[BUYER_ID] [int] NOT NULL,
	[PROPERTY_ID] [int] NOT NULL,
	[TIME] [datetime2](7) NULL,
 CONSTRAINT [PK_booking] PRIMARY KEY CLUSTERED 
(
	[BOOKING_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buyer]    Script Date: 25/07/2024 15:07:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buyer](
	[BUYER_ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nvarchar](max) NULL,
	[SURNAME] [nvarchar](max) NULL,
	[ADDRESS] [nvarchar](max) NULL,
	[POSTCODE] [nvarchar](max) NULL,
	[PHONE] [nvarchar](max) NULL,
 CONSTRAINT [PK_buyer] PRIMARY KEY CLUSTERED 
(
	[BUYER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[property]    Script Date: 25/07/2024 15:07:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[property](
	[PROPERTY_ID] [int] IDENTITY(1,1) NOT NULL,
	[ADDRESS] [nvarchar](255) NOT NULL,
	[POSTCODE] [nvarchar](255) NOT NULL,
	[TYPE] [nvarchar](9) NOT NULL,
	[NUMBER_OF_BEDROOMS] [int] NOT NULL,
	[NUMBER_OF_BATHROOMS] [int] NOT NULL,
	[GARDEN] [bit] NOT NULL,
	[PRICE] [decimal](18, 2) NULL,
	[STATUS] [nvarchar](9) NOT NULL,
	[SELLER_ID] [int] NOT NULL,
	[BUYER_ID] [int] NULL,
 CONSTRAINT [PK_property] PRIMARY KEY CLUSTERED 
(
	[PROPERTY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seller]    Script Date: 25/07/2024 15:07:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seller](
	[SELLER_ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nvarchar](255) NOT NULL,
	[SURNAME] [nvarchar](255) NOT NULL,
	[ADDRESS] [nvarchar](255) NOT NULL,
	[POSTCODE] [nvarchar](255) NOT NULL,
	[PHONE] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_seller] PRIMARY KEY CLUSTERED 
(
	[SELLER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240620144158_Initial', N'8.0.6')
GO
SET IDENTITY_INSERT [dbo].[booking] ON 
GO
INSERT [dbo].[booking] ([BOOKING_ID], [BUYER_ID], [PROPERTY_ID], [TIME]) VALUES (1, 2, 2, CAST(N'2024-06-27T15:41:56.6464916' AS DateTime2))
GO
INSERT [dbo].[booking] ([BOOKING_ID], [BUYER_ID], [PROPERTY_ID], [TIME]) VALUES (2, 3, 3, CAST(N'2024-07-04T15:41:56.6464966' AS DateTime2))
GO
INSERT [dbo].[booking] ([BOOKING_ID], [BUYER_ID], [PROPERTY_ID], [TIME]) VALUES (3, 1, 4, CAST(N'2024-06-28T15:41:56.6464969' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[booking] OFF
GO
SET IDENTITY_INSERT [dbo].[buyer] ON 
GO
INSERT [dbo].[buyer] ([BUYER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (1, N'Patel', N'Sadia', N'1 the High Street', N'AV1 1VA', N'08700456789')
GO
INSERT [dbo].[buyer] ([BUYER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (2, N'Kamran', N'Liaqat', N'2 the Low Street', N'AV2 2VA', N'08700123654')
GO
INSERT [dbo].[buyer] ([BUYER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (3, N'Saeed', N'Mirza', N'5 the Round Street', N'AV5 5VA', N'08700555555')
GO
INSERT [dbo].[buyer] ([BUYER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (1001, N'Bob', N'Bob', N'Bob', N'Bob', N'1234456')
GO
SET IDENTITY_INSERT [dbo].[buyer] OFF
GO
SET IDENTITY_INSERT [dbo].[property] ON 
GO
INSERT [dbo].[property] ([PROPERTY_ID], [ADDRESS], [POSTCODE], [TYPE], [NUMBER_OF_BEDROOMS], [NUMBER_OF_BATHROOMS], [GARDEN], [PRICE], [STATUS], [SELLER_ID], [BUYER_ID]) VALUES (1, N'3 the Avenue', N'TA1 1AT', N'HOUSE', 4, 0, 1, CAST(450000.00 AS Decimal(18, 2)), N'FORSALE', 1, NULL)
GO
INSERT [dbo].[property] ([PROPERTY_ID], [ADDRESS], [POSTCODE], [TYPE], [NUMBER_OF_BEDROOMS], [NUMBER_OF_BATHROOMS], [GARDEN], [PRICE], [STATUS], [SELLER_ID], [BUYER_ID]) VALUES (2, N'Flat 4, the Avenue', N'TA2 2AT', N'FLAT', 2, 0, 0, CAST(300000.00 AS Decimal(18, 2)), N'FORSALE', 2, NULL)
GO
INSERT [dbo].[property] ([PROPERTY_ID], [ADDRESS], [POSTCODE], [TYPE], [NUMBER_OF_BEDROOMS], [NUMBER_OF_BATHROOMS], [GARDEN], [PRICE], [STATUS], [SELLER_ID], [BUYER_ID]) VALUES (3, N'5 the Road', N'TA2 2AT', N'BUNGALOW', 3, 0, 1, CAST(350000.00 AS Decimal(18, 2)), N'FORSALE', 3, NULL)
GO
INSERT [dbo].[property] ([PROPERTY_ID], [ADDRESS], [POSTCODE], [TYPE], [NUMBER_OF_BEDROOMS], [NUMBER_OF_BATHROOMS], [GARDEN], [PRICE], [STATUS], [SELLER_ID], [BUYER_ID]) VALUES (4, N'7 the Road', N'TA2 2AT', N'HOUSE', 4, 0, 1, CAST(500000.00 AS Decimal(18, 2)), N'FORSALE', 4, NULL)
GO
SET IDENTITY_INSERT [dbo].[property] OFF
GO
SET IDENTITY_INSERT [dbo].[seller] ON 
GO
INSERT [dbo].[seller] ([SELLER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (1, N'Dilpreet', N'Baradaran', N'3 the Long Street', N'AV3 3VA', N'08700333333')
GO
INSERT [dbo].[seller] ([SELLER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (2, N'Kofi', N'Dhillon', N'2 the Short Street', N'AV4 4VA', N'087004444444')
GO
INSERT [dbo].[seller] ([SELLER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (3, N'Banana', N'man', N'string', N'string', N'string')
GO
INSERT [dbo].[seller] ([SELLER_ID], [FIRST_NAME], [SURNAME], [ADDRESS], [POSTCODE], [PHONE]) VALUES (4, N'Banana', N'Man', N'cfazsc', N'strzxcxzcing', N'strzxczxing')
GO
SET IDENTITY_INSERT [dbo].[seller] OFF
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_buyer] FOREIGN KEY([BUYER_ID])
REFERENCES [dbo].[buyer] ([BUYER_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_buyer]
GO
ALTER TABLE [dbo].[booking]  WITH CHECK ADD  CONSTRAINT [FK_booking_property] FOREIGN KEY([PROPERTY_ID])
REFERENCES [dbo].[property] ([PROPERTY_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[booking] CHECK CONSTRAINT [FK_booking_property]
GO
ALTER TABLE [dbo].[property]  WITH CHECK ADD  CONSTRAINT [FK_property_buyer] FOREIGN KEY([BUYER_ID])
REFERENCES [dbo].[buyer] ([BUYER_ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[property] CHECK CONSTRAINT [FK_property_buyer]
GO
ALTER TABLE [dbo].[property]  WITH CHECK ADD  CONSTRAINT [FK_property_seller] FOREIGN KEY([SELLER_ID])
REFERENCES [dbo].[seller] ([SELLER_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[property] CHECK CONSTRAINT [FK_property_seller]
GO
