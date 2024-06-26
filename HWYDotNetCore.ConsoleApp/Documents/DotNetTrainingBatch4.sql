USE [master]
GO
/****** Object:  Database [HWYDotNetCore]    Script Date: 4/28/2024 2:42:55 PM ******/
CREATE DATABASE [HWYDotNetCore] ON  PRIMARY 
( NAME = N'HWYDotNetCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER2012\MSSQL\DATA\HWYDotNetCore.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HWYDotNetCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER2012\MSSQL\DATA\HWYDotNetCore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HWYDotNetCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HWYDotNetCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HWYDotNetCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HWYDotNetCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HWYDotNetCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HWYDotNetCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HWYDotNetCore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HWYDotNetCore] SET  MULTI_USER 
GO
ALTER DATABASE [HWYDotNetCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HWYDotNetCore] SET DB_CHAINING OFF 
GO
USE [HWYDotNetCore]
GO
/****** Object:  Table [dbo].[Tbl_Blog]    Script Date: 4/28/2024 2:42:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Blog](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[BlogTitle] [varchar](50) NOT NULL,
	[BlogAuthor] [varchar](50) NOT NULL,
	[BlogContent] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Blog] ON 

INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (1, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (2, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (3, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (4, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (5, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (6, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (7, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (8, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (9, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (10, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (11, N'title', N'author', N'content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (12, N'title', N'author', N'content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (1002, N'Dap title', N'Dap author', N'Dap content')
SET IDENTITY_INSERT [dbo].[Tbl_Blog] OFF
USE [master]
GO
ALTER DATABASE [HWYDotNetCore] SET  READ_WRITE 
GO
