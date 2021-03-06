USE [master]
GO
/****** Object:  Database [SistemaPizza ]    Script Date: 04/06/2017 21:12:37 ******/
CREATE DATABASE [SistemaPizza ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaPizza', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SistemaPizza .mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SistemaPizza _log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SistemaPizza _log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SistemaPizza ] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaPizza ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaPizza ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaPizza ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaPizza ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaPizza ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaPizza ] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaPizza ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaPizza ] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaPizza ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaPizza ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaPizza ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaPizza ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaPizza ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaPizza ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaPizza ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaPizza ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaPizza ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaPizza ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaPizza ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaPizza ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaPizza ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaPizza ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaPizza ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaPizza ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaPizza ] SET RECOVERY FULL 
GO
ALTER DATABASE [SistemaPizza ] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaPizza ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaPizza ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaPizza ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaPizza ] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaPizza ', N'ON'
GO
USE [SistemaPizza ]
GO
/****** Object:  Table [dbo].[tbl_cliente]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[numero] [varchar](20) NOT NULL,
	[complemento] [varchar](30) NULL,
	[bairro] [varchar](30) NOT NULL,
	[idendereco] [int] NULL,
 CONSTRAINT [PK_tbl_cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_endereco]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_endereco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[complemento] [varchar](50) NOT NULL,
	[numero] [varchar](25) NOT NULL,
	[rua] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_endereco] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ingrediente]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ingrediente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[valor] [numeric](8, 2) NOT NULL,
 CONSTRAINT [PK_tbl_ingrediente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pedido]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pedido](
	[numpedido] [int] IDENTITY(1,1) NOT NULL,
	[data] [date] NOT NULL,
	[precototal] [money] NOT NULL,
	[descricao] [varchar](20) NOT NULL,
	[idpizza] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
 CONSTRAINT [PK_tbl_pedido] PRIMARY KEY CLUSTERED 
(
	[numpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pizza]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pizza](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [date] NOT NULL,
	[precototal] [numeric](8, 2) NOT NULL,
	[idingrediente] [int] NOT NULL,
	[idsabor1] [int] NOT NULL,
	[idsabor2] [int] NULL,
	[idsabor3] [int] NULL,
	[tamanho] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_pizza] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_sabor]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_sabor](
	[idsabor] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_sabor] PRIMARY KEY CLUSTERED 
(
	[idsabor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_usuario]    Script Date: 04/06/2017 21:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](20) NOT NULL,
	[senha] [varchar](20) NOT NULL,
	[cep] [varchar](20) NULL,
	[rua] [varchar](50) NOT NULL,
	[numero] [varchar](20) NULL,
	[telefone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_cliente]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cliente_tbl_endereco] FOREIGN KEY([idendereco])
REFERENCES [dbo].[tbl_endereco] ([id])
GO
ALTER TABLE [dbo].[tbl_cliente] CHECK CONSTRAINT [FK_tbl_cliente_tbl_endereco]
GO
ALTER TABLE [dbo].[tbl_pedido]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pedido_tbl_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[tbl_cliente] ([id])
GO
ALTER TABLE [dbo].[tbl_pedido] CHECK CONSTRAINT [FK_tbl_pedido_tbl_cliente]
GO
ALTER TABLE [dbo].[tbl_pedido]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pedido_tbl_pizza] FOREIGN KEY([idpizza])
REFERENCES [dbo].[tbl_pizza] ([id])
GO
ALTER TABLE [dbo].[tbl_pedido] CHECK CONSTRAINT [FK_tbl_pedido_tbl_pizza]
GO
ALTER TABLE [dbo].[tbl_pedido]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pedido_tbl_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[tbl_usuario] ([id])
GO
ALTER TABLE [dbo].[tbl_pedido] CHECK CONSTRAINT [FK_tbl_pedido_tbl_usuario]
GO
ALTER TABLE [dbo].[tbl_pizza]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pizza_tbl_ingrediente] FOREIGN KEY([idingrediente])
REFERENCES [dbo].[tbl_ingrediente] ([id])
GO
ALTER TABLE [dbo].[tbl_pizza] CHECK CONSTRAINT [FK_tbl_pizza_tbl_ingrediente]
GO
ALTER TABLE [dbo].[tbl_pizza]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pizza_tbl_sabor] FOREIGN KEY([idsabor1])
REFERENCES [dbo].[tbl_sabor] ([idsabor])
GO
ALTER TABLE [dbo].[tbl_pizza] CHECK CONSTRAINT [FK_tbl_pizza_tbl_sabor]
GO
ALTER TABLE [dbo].[tbl_pizza]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pizza_tbl_sabor1] FOREIGN KEY([idsabor2])
REFERENCES [dbo].[tbl_sabor] ([idsabor])
GO
ALTER TABLE [dbo].[tbl_pizza] CHECK CONSTRAINT [FK_tbl_pizza_tbl_sabor1]
GO
ALTER TABLE [dbo].[tbl_pizza]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pizza_tbl_sabor2] FOREIGN KEY([idsabor3])
REFERENCES [dbo].[tbl_sabor] ([idsabor])
GO
ALTER TABLE [dbo].[tbl_pizza] CHECK CONSTRAINT [FK_tbl_pizza_tbl_sabor2]
GO
USE [master]
GO
ALTER DATABASE [SistemaPizza ] SET  READ_WRITE 
GO
