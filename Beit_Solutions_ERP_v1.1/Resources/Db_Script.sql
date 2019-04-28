USE [master]
GO

/****** Object:  Database [Beit_Solutions_WF]    Script Date: 28-Apr-19 4:50:06 PM ******/
DROP DATABASE [Beit_Solutions_WF]
GO

/****** Object:  Database [Beit_Solutions_WF]    Script Date: 28-Apr-19 4:50:06 PM ******/
CREATE DATABASE [Beit_Solutions_WF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Beit_Solutions_WF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Beit_Solutions_WF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Beit_Solutions_WF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Beit_Solutions_WF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Beit_Solutions_WF] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Beit_Solutions_WF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Beit_Solutions_WF] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET ARITHABORT OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Beit_Solutions_WF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Beit_Solutions_WF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Beit_Solutions_WF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Beit_Solutions_WF] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET RECOVERY FULL 
GO

ALTER DATABASE [Beit_Solutions_WF] SET  MULTI_USER 
GO

ALTER DATABASE [Beit_Solutions_WF] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Beit_Solutions_WF] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Beit_Solutions_WF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Beit_Solutions_WF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Beit_Solutions_WF] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Beit_Solutions_WF] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Beit_Solutions_WF] SET  READ_WRITE 
GO

