USE [master]
GO

/****** Object:  Database [btlsl]    Script Date: 7/24/2020 8:52:56 PM ******/
CREATE DATABASE [btlsl]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'btlsl', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\btlsl.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'btlsl_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\btlsl_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [btlsl] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [btlsl].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [btlsl] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [btlsl] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [btlsl] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [btlsl] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [btlsl] SET ARITHABORT OFF 
GO

ALTER DATABASE [btlsl] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [btlsl] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [btlsl] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [btlsl] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [btlsl] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [btlsl] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [btlsl] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [btlsl] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [btlsl] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [btlsl] SET  DISABLE_BROKER 
GO

ALTER DATABASE [btlsl] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [btlsl] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [btlsl] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [btlsl] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [btlsl] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [btlsl] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [btlsl] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [btlsl] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [btlsl] SET  MULTI_USER 
GO

ALTER DATABASE [btlsl] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [btlsl] SET DB_CHAINING OFF 
GO

ALTER DATABASE [btlsl] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [btlsl] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [btlsl] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [btlsl] SET  READ_WRITE 
GO
