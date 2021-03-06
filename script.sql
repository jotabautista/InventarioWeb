USE [master]
GO
/****** Object:  Database [InventarioDB]    Script Date: 07/10/2019 10:27:38 a.m. ******/
CREATE DATABASE [InventarioDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventarioDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\InventarioDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventarioDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\InventarioDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InventarioDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventarioDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventarioDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventarioDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventarioDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventarioDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventarioDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventarioDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InventarioDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventarioDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventarioDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventarioDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventarioDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventarioDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventarioDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventarioDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventarioDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InventarioDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventarioDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventarioDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventarioDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventarioDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventarioDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventarioDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventarioDB] SET RECOVERY FULL 
GO
ALTER DATABASE [InventarioDB] SET  MULTI_USER 
GO
ALTER DATABASE [InventarioDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventarioDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventarioDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventarioDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventarioDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'InventarioDB', N'ON'
GO
ALTER DATABASE [InventarioDB] SET QUERY_STORE = OFF
GO
USE [InventarioDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [InventarioDB]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[IdAlmacen] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Ubicacion] [varchar](300) NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[IdAlmacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[IdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Referencia] [varchar](20) NULL,
	[Descripcion] [varchar](100) NULL,
	[Minimo] [int] NOT NULL,
	[Maximo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[IdInventario] [int] IDENTITY(1,1) NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Tipo] [varchar](5) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Documento] [int] NOT NULL,
	[Precio] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimiento](
	[IdMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Movimiento] PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovimientoDet]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimientoDet](
	[IdMovimientoDet] [int] IDENTITY(1,1) NOT NULL,
	[IdMovimiento] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_MovimientoDet] PRIMARY KEY CLUSTERED 
(
	[IdMovimientoDet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Almacen] ADD  CONSTRAINT [DF_Almacen_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_Minimo]  DEFAULT ((0)) FOR [Minimo]
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_Maximo]  DEFAULT ((0)) FOR [Maximo]
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Inventario] ADD  CONSTRAINT [DF_Inventario_Cantidad]  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[Movimiento] ADD  CONSTRAINT [DF_Movimiento_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[MovimientoDet] ADD  CONSTRAINT [DF_MovimientoDet_Precio]  DEFAULT ((0)) FOR [Precio]
GO
/****** Object:  Trigger [dbo].[trInventarioDel]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trInventarioDel] 
   ON  [dbo].[MovimientoDet]
   AFTER Delete
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

	   Declare
		@Documento int

		SELECT
			@Documento = IdMovimientoDet
		FROM
		   deleted 		

	Delete From
	[dbo].[Inventario] where documento = @Documento

END
GO
ALTER TABLE [dbo].[MovimientoDet] ENABLE TRIGGER [trInventarioDel]
GO
/****** Object:  Trigger [dbo].[trInventarioIns]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trInventarioIns] 
   ON  [dbo].[MovimientoDet]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

	   Declare
		@IdAlmacen int,
        @IdArticulo int,
        @Tipo varchar(5),
        @Fecha datetime,
        @Cantidad int,
		@IdMovimiento int,
		@Precio Numeric(18,2),
		@Documento int

		SELECT
			@IdAlmacen = IdAlmacen,
			@IdArticulo = IdArticulo,
			@Cantidad = Cantidad,
			@IdMovimiento = IdMovimiento,
			@Precio = Precio,
			@Documento = IdMovimientoDet
		FROM
		   inserted 

		Select 
			@Tipo = Tipo,
			@Fecha = Fecha
		From
			Movimiento
		Where 
			IdMovimiento = @IdMovimiento

	if (@Tipo = 2) SET @Cantidad = @Cantidad * -1
			

	INSERT INTO
	[dbo].[Inventario]
			   ([IdAlmacen]
			   ,[IdArticulo]
			   ,[Tipo]
			   ,[Fecha]
			   ,[Cantidad]
			   ,[Documento]
			   ,[Precio])
	Values(@IdAlmacen,@IdArticulo,@Tipo,@Fecha,@Cantidad,@Documento,@Precio)

END
GO
ALTER TABLE [dbo].[MovimientoDet] ENABLE TRIGGER [trInventarioIns]
GO
/****** Object:  Trigger [dbo].[trInventarioUpd]    Script Date: 07/10/2019 10:27:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trInventarioUpd] 
   ON  [dbo].[MovimientoDet]
   AFTER UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	   Declare
		@DocumentoOld int

		SELECT
			@DocumentoOld = IdMovimientoDet
		FROM
		   deleted 		

	Delete From
	[dbo].[Inventario] where documento = @DocumentoOld


	   Declare
		@IdAlmacen int,
        @IdArticulo int,
        @Tipo varchar(5),
        @Fecha datetime,
        @Cantidad int,
		@IdMovimiento int,
		@Precio Numeric(18,2),
		@Documento int

		SELECT
			@IdAlmacen = IdAlmacen,
			@IdArticulo = IdArticulo,
			@Cantidad = Cantidad,
			@IdMovimiento = IdMovimiento,
			@Precio = Precio,
			@Documento = IdMovimientoDet
		FROM
		   inserted 

		Select 
			@Tipo = Tipo,
			@Fecha = Fecha
		From
			Movimiento
		Where 
			IdMovimiento = @IdMovimiento

	if (@Tipo = 2) SET @Cantidad = @Cantidad * -1

			

	INSERT INTO
	[dbo].[Inventario]
			   ([IdAlmacen]
			   ,[IdArticulo]
			   ,[Tipo]
			   ,[Fecha]
			   ,[Cantidad]
			   ,[Documento]
			   ,[Precio])
	Values(@IdAlmacen,@IdArticulo,@Tipo,@Fecha,@Cantidad,@Documento,@Precio)

END
GO
ALTER TABLE [dbo].[MovimientoDet] ENABLE TRIGGER [trInventarioUpd]
GO
USE [master]
GO
ALTER DATABASE [InventarioDB] SET  READ_WRITE 
GO
