USE [master]
GO
/****** Object:  Database [CoreCoffee]    Script Date: 9/15/2020 8:42:03 AM ******/
CREATE DATABASE [CoreCoffee]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoreCoffee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoreCoffee.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoreCoffee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoreCoffee_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CoreCoffee] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoreCoffee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoreCoffee] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoreCoffee] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoreCoffee] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoreCoffee] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoreCoffee] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoreCoffee] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoreCoffee] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoreCoffee] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoreCoffee] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoreCoffee] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoreCoffee] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoreCoffee] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoreCoffee] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoreCoffee] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoreCoffee] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoreCoffee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoreCoffee] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoreCoffee] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoreCoffee] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoreCoffee] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoreCoffee] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoreCoffee] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoreCoffee] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoreCoffee] SET  MULTI_USER 
GO
ALTER DATABASE [CoreCoffee] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoreCoffee] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoreCoffee] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoreCoffee] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoreCoffee] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoreCoffee] SET QUERY_STORE = OFF
GO
USE [CoreCoffee]
GO
/****** Object:  User [csharp]    Script Date: 9/15/2020 8:42:04 AM ******/
CREATE USER [csharp] FOR LOGIN [csharp] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [csharp]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [csharp]
GO
/****** Object:  Table [dbo].[CoffeeProduct]    Script Date: 9/15/2020 8:42:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoffeeProduct](
	[Product_id] [int] IDENTITY(1,1) NOT NULL,
	[Product_category] [varchar](15) NULL,
	[Product_name] [varchar](25) NULL,
	[Product_description] [varchar](50) NULL,
	[Product_price] [smallmoney] NULL,
 CONSTRAINT [PK_CoffeeProduct] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CoffeeProduct] ON 

INSERT [dbo].[CoffeeProduct] ([Product_id], [Product_category], [Product_name], [Product_description], [Product_price]) VALUES (1, N'Drink', N'Espresso', N'This is an espresso', 4.9900)
INSERT [dbo].[CoffeeProduct] ([Product_id], [Product_category], [Product_name], [Product_description], [Product_price]) VALUES (2, N'Drink', N'Dark Roast Coffee', N'Coffee, Black Coffee', 2.5000)
INSERT [dbo].[CoffeeProduct] ([Product_id], [Product_category], [Product_name], [Product_description], [Product_price]) VALUES (3, N'Drink', N'Cappuccino', N'Italian Coffee', 3.2500)
INSERT [dbo].[CoffeeProduct] ([Product_id], [Product_category], [Product_name], [Product_description], [Product_price]) VALUES (4, N'Food', N'Brownie', N'Chocolate Chip Fudge Brownie', 2.0000)
SET IDENTITY_INSERT [dbo].[CoffeeProduct] OFF
GO
USE [master]
GO
ALTER DATABASE [CoreCoffee] SET  READ_WRITE 
GO
