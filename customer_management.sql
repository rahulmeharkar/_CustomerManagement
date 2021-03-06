USE [master]
GO
/****** Object:  Database [customer_management]    Script Date: 6/26/2022 9:36:45 PM ******/
CREATE DATABASE [customer_management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'customer_management', FILENAME = N'I:\Microsoft SQL Server 2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\customer_management.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'customer_management_log', FILENAME = N'I:\Microsoft SQL Server 2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\customer_management_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [customer_management] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [customer_management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [customer_management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [customer_management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [customer_management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [customer_management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [customer_management] SET ARITHABORT OFF 
GO
ALTER DATABASE [customer_management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [customer_management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [customer_management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [customer_management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [customer_management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [customer_management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [customer_management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [customer_management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [customer_management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [customer_management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [customer_management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [customer_management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [customer_management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [customer_management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [customer_management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [customer_management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [customer_management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [customer_management] SET RECOVERY FULL 
GO
ALTER DATABASE [customer_management] SET  MULTI_USER 
GO
ALTER DATABASE [customer_management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [customer_management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [customer_management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [customer_management] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [customer_management] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'customer_management', N'ON'
GO
ALTER DATABASE [customer_management] SET QUERY_STORE = OFF
GO
USE [customer_management]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 6/26/2022 9:36:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_name] [nchar](50) NOT NULL,
	[customer_phone] [nchar](14) NOT NULL,
	[customer_address] [varchar](100) NOT NULL,
	[customer_dob] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 6/26/2022 9:36:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nchar](50) NOT NULL,
	[user_email] [nchar](50) NOT NULL,
	[user_password] [nchar](16) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [customer_management] SET  READ_WRITE 
GO
