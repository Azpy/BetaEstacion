USE [master]
GO
/****** Object:  Database [DBEstacionamiento]    Script Date: 04/13/2018 19:09:43 ******/
CREATE DATABASE [DBEstacionamiento] ON  PRIMARY 
( NAME = N'DBEstacionamiento', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DBEstacionamiento.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBEstacionamiento_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DBEstacionamiento_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBEstacionamiento] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBEstacionamiento].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DBEstacionamiento] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DBEstacionamiento] SET ARITHABORT OFF
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DBEstacionamiento] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DBEstacionamiento] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DBEstacionamiento] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DBEstacionamiento] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DBEstacionamiento] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DBEstacionamiento] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DBEstacionamiento] SET  DISABLE_BROKER
GO
ALTER DATABASE [DBEstacionamiento] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DBEstacionamiento] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DBEstacionamiento] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DBEstacionamiento] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DBEstacionamiento] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DBEstacionamiento] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DBEstacionamiento] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DBEstacionamiento] SET  READ_WRITE
GO
ALTER DATABASE [DBEstacionamiento] SET RECOVERY FULL
GO
ALTER DATABASE [DBEstacionamiento] SET  MULTI_USER
GO
ALTER DATABASE [DBEstacionamiento] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DBEstacionamiento] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBEstacionamiento', N'ON'
GO
USE [DBEstacionamiento]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 04/13/2018 19:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] NOT NULL,
	[mat_usuario] [varchar](8) NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[cajon_asignado] [int] NOT NULL,
	[status_usuario] [tinyint] NOT NULL,
	[preferencia] [int] NOT NULL,
	[invitado] [tinyint] NOT NULL,
	[hora_ent] [varchar](4) NOT NULL,
	[hora_sal] [varchar](4) NOT NULL,
	[idcajon] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cajones]    Script Date: 04/13/2018 19:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cajones](
	[idcajon] [int] NOT NULL,
	[status_cajon] [tinyint] NOT NULL,
	[seccion] [varchar](3) NOT NULL,
	[tipo_cajon] [varchar](10) NOT NULL,
	[idauto] [int] NOT NULL,
 CONSTRAINT [PK_cajones] PRIMARY KEY CLUSTERED 
(
	[idcajon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[autos]    Script Date: 04/13/2018 19:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[autos](
	[idauto] [int] NOT NULL,
	[modelo_auto] [varchar](15) NOT NULL,
	[matricula_auto] [varchar](12) NOT NULL,
	[idusuario] [int] NOT NULL,
 CONSTRAINT [PK_autos] PRIMARY KEY CLUSTERED 
(
	[idauto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_usuario_cajones]    Script Date: 04/13/2018 19:09:44 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_cajones] FOREIGN KEY([idcajon])
REFERENCES [dbo].[cajones] ([idcajon])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_cajones]
GO
/****** Object:  ForeignKey [FK_cajones_autos]    Script Date: 04/13/2018 19:09:44 ******/
ALTER TABLE [dbo].[cajones]  WITH CHECK ADD  CONSTRAINT [FK_cajones_autos] FOREIGN KEY([idauto])
REFERENCES [dbo].[autos] ([idauto])
GO
ALTER TABLE [dbo].[cajones] CHECK CONSTRAINT [FK_cajones_autos]
GO
/****** Object:  ForeignKey [FK_autos_usuario]    Script Date: 04/13/2018 19:09:44 ******/
ALTER TABLE [dbo].[autos]  WITH CHECK ADD  CONSTRAINT [FK_autos_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[autos] CHECK CONSTRAINT [FK_autos_usuario]
GO
