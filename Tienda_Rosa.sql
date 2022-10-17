USE [master]
GO
/****** Object:  Database [Tienda_Rosa]    Script Date: 16/10/2022 05:27:33 ******/
CREATE DATABASE [Tienda_Rosa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tienda_Rosa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tienda_Rosa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tienda_Rosa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tienda_Rosa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Tienda_Rosa] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tienda_Rosa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tienda_Rosa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Tienda_Rosa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tienda_Rosa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tienda_Rosa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Tienda_Rosa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tienda_Rosa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tienda_Rosa] SET  MULTI_USER 
GO
ALTER DATABASE [Tienda_Rosa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tienda_Rosa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tienda_Rosa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tienda_Rosa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tienda_Rosa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tienda_Rosa] SET QUERY_STORE = OFF
GO
USE [Tienda_Rosa]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellidos] [nvarchar](50) NULL,
	[telefono] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra_Detalles]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra_Detalles](
	[idcompra] [int] NULL,
	[idproducto] [int] NULL,
	[importe] [decimal](18, 2) NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[idcompra] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[idtipocomprobante] [int] NULL,
	[idfactura] [nvarchar](50) NULL,
	[idproveedor] [int] NULL,
	[importe_total] [decimal](18, 2) NULL,
	[retencion] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[contraseña] [nvarchar](255) NULL,
	[idrol] [int] NULL,
	[usuario] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[idpagos] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NULL,
	[monto] [decimal](18, 2) NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idpagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[idcategoria] [int] NULL,
	[precio] [decimal](18, 2) NULL,
	[stock] [int] NULL,
	[idproveedor] [int] NULL,
	[foto] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[RUC] [nvarchar](12) NULL,
	[representante] [nvarchar](150) NULL,
	[direccion] [nvarchar](60) NULL,
	[Telefono] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_venta]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_venta](
	[idtipoventa] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtipoventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NULL,
	[idempleado] [int] NULL,
	[fecha] [datetime] NULL,
	[idtipoventa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta_Detalle]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta_Detalle](
	[idventa] [int] NULL,
	[idproducto] [int] NULL,
	[precio] [decimal](18, 2) NULL,
	[cantidad] [int] NULL,
	[importe] [decimal](18, 2) NULL,
	[montopagado] [decimal](18, 2) NULL,
	[cancelado] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compra_Detalles]  WITH CHECK ADD  CONSTRAINT [fk_Compra_Detalles_Compras] FOREIGN KEY([idcompra])
REFERENCES [dbo].[Compras] ([idcompra])
GO
ALTER TABLE [dbo].[Compra_Detalles] CHECK CONSTRAINT [fk_Compra_Detalles_Compras]
GO
ALTER TABLE [dbo].[Compra_Detalles]  WITH CHECK ADD  CONSTRAINT [fk_Compra_Detalles_Producto] FOREIGN KEY([idproducto])
REFERENCES [dbo].[Producto] ([idproducto])
GO
ALTER TABLE [dbo].[Compra_Detalles] CHECK CONSTRAINT [fk_Compra_Detalles_Producto]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [fk_Compras_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[Proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [fk_Compras_proveedor]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [fk_Pagos_Cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[Cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [fk_Pagos_Cliente]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_Producto_Categoria] FOREIGN KEY([idcategoria])
REFERENCES [dbo].[Categoria] ([idcategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_Producto_Proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[Proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_Producto_Proveedor]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [fk_Venta_Cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[Cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [fk_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [fk_Venta_Empleado] FOREIGN KEY([idempleado])
REFERENCES [dbo].[Empleado] ([idempleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [fk_Venta_Empleado]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [fk_venta_idtipoventa] FOREIGN KEY([idtipoventa])
REFERENCES [dbo].[Tipo_venta] ([idtipoventa])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [fk_venta_idtipoventa]
GO
ALTER TABLE [dbo].[Venta_Detalle]  WITH CHECK ADD  CONSTRAINT [fk_Venta_detalle_producto] FOREIGN KEY([idproducto])
REFERENCES [dbo].[Producto] ([idproducto])
GO
ALTER TABLE [dbo].[Venta_Detalle] CHECK CONSTRAINT [fk_Venta_detalle_producto]
GO
ALTER TABLE [dbo].[Venta_Detalle]  WITH CHECK ADD  CONSTRAINT [fk_Venta_detalle_Venta] FOREIGN KEY([idventa])
REFERENCES [dbo].[Venta] ([idventa])
GO
ALTER TABLE [dbo].[Venta_Detalle] CHECK CONSTRAINT [fk_Venta_detalle_Venta]
GO
/****** Object:  StoredProcedure [dbo].[actualizastock]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[actualizastock]
@stock int,
@idproducto int
as
update producto set stock=@stock where idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[agregarcompra]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[agregarcompra]
@idtipocomprobante int,
@idfactura nvarchar(50),
@idproveedor int,
@importe_total decimal(18,2),
@retencion decimal(18,2),
@fecha as nvarchar(25)
as
insert into Compras(fecha,idtipocomprobante,idfactura,idproveedor,importe_total,retencion)
values(@fecha,@idtipocomprobante,@idfactura,@idproveedor,@importe_total,@retencion)
GO
/****** Object:  StoredProcedure [dbo].[maxproductos]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[maxproductos]
as
declare @correcto int
 
 select @correcto=count(*) from Producto
 
RETURN @correcto
GO
/****** Object:  StoredProcedure [dbo].[mostrartodoproveedores]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[mostrartodoproveedores]
as
select idproveedor,nombre,RUC,representante,direccion,telefono from Proveedor
GO
/****** Object:  StoredProcedure [dbo].[p_actualiventadetalle]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_actualiventadetalle]
@idventa int,
@idproducto int,
@cancelado int,
@montopagado decimal(18,2)
as
update Venta_Detalle set cancelado=@cancelado , montopagado=montopagado+@montopagado
where idventa=@idventa and idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[p_actualizasotckcompra]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_actualizasotckcompra]
@stock int,
@idproducto int
as
update producto set stock=(stock+@stock) where idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[p_buscacategoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_buscacategoria]
@nombre nvarchar(255)
as
select idcategoria,nombre,descripcion from Categoria where nombre like '%'+@nombre+'%'
GO
/****** Object:  StoredProcedure [dbo].[p_buscacliente]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_buscacliente]
@nombre nvarchar(150)
as
 select idcliente,nombre,apellidos,telefono from cliente where nombre +' '+ apellidos like '%'+ @nombre +'%'
GO
/****** Object:  StoredProcedure [dbo].[p_buscaproducto]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_buscaproducto]
@nombre nvarchar(255),
@idcategoria int
as
select idproducto,nombre,precio,stock from producto where idcategoria=@idcategoria and nombre like '%'+@nombre+'%'
GO
/****** Object:  StoredProcedure [dbo].[p_buscaproveedor]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_buscaproveedor]
@nombre nvarchar(150)
as
 select idproveedor,nombre,RUC,representante, direccion,Telefono from Proveedor where nombre +' '+ RUC like '%'+ @nombre +'%'
GO
/****** Object:  StoredProcedure [dbo].[p_buscarnomycat]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_buscarnomycat]
@nombre nvarchar(255),
@idcategoria int
as
select idproducto,nombre,idcategoria,precio,stock,foto,idproveedor from Producto where nombre like '%'+ @nombre+ '%'
and idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[p_buscartodoproducto]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_buscartodoproducto]
@nombre nvarchar(255)
as
select idproducto,nombre,idcategoria,precio,stock,foto,idproveedor from Producto where nombre like '%'+ @nombre+ '%'
GO
/****** Object:  StoredProcedure [dbo].[p_calcularus]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_calcularus]
@fecha as nvarchar(10)
as
select SUM(importe_total-retencion),SUM(retencion) from Compras 
where datepart(month,fecha) = datepart(month,@fecha) and DATEPART(YEAR,fecha)=DATEPART(YEAR,@fecha)
GO
/****** Object:  StoredProcedure [dbo].[p_cliente]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_cliente]
as
select idcliente,nombre + ' ' + apellidos from cliente
GO
/****** Object:  StoredProcedure [dbo].[p_contarnomycate]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_contarnomycate]
@nombre nvarchar(255),
@idcategoria int
as
declare @correcto int
select @correcto=COUNT(*) from producto where nombre like '%' +@nombre+'%' and idcategoria=@idcategoria
RETURN @correcto 
GO
/****** Object:  StoredProcedure [dbo].[p_contarproductosporcategoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_contarproductosporcategoria]
@idcategoria int
as
declare @correcto int
select @correcto=COUNT(*) from producto where idcategoria=@idcategoria
return @correcto
GO
/****** Object:  StoredProcedure [dbo].[p_contarproductosporfiltro]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_contarproductosporfiltro]
@nombre nvarchar(255)
as
declare @correcto int
select @correcto=COUNT(*) from producto where nombre like '%' +@nombre+'%'
RETURN @correcto
GO
/****** Object:  StoredProcedure [dbo].[p_eliminarcategoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_eliminarcategoria]
@idcategoria BIGINT 
AS
BEGIN 
DELETE FROM Categoria WHERE idcategoria=@idcategoria
END 
GO
/****** Object:  StoredProcedure [dbo].[p_eliminarproveedor]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_eliminarproveedor]
@idproveedor BIGINT 
AS
BEGIN 
DELETE FROM Proveedor WHERE idproveedor=@idproveedor
END 
GO
/****** Object:  StoredProcedure [dbo].[p_idempleado]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_idempleado]
@usuario nvarchar(255)
as
select idempleado from Empleado where @usuario=usuario
GO
/****** Object:  StoredProcedure [dbo].[p_insertarpagos]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_insertarpagos]
@idcliente int,
@monto decimal(18,2),
@fecha nvarchar(20)
as
insert Pagos (idcliente,monto,fecha)
values(@idcliente,@monto,@fecha)
GO
/****** Object:  StoredProcedure [dbo].[p_listardeuda1]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_listardeuda1]
@idcliente int
as
select  vd.idventa,vd.idproducto,(vd.importe-vd.montopagado) from Venta v
inner join Venta_Detalle vd on v.idventa=vd.idventa
where v.idcliente=@idcliente and vd.cancelado=0
GO
/****** Object:  StoredProcedure [dbo].[p_modificarcategoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_modificarcategoria]
@nombre nvarchar(255),
@descripcion nvarchar(255),
@idcategoria int
as
update Categoria set nombre=@nombre ,descripcion=@descripcion 
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[p_modificarcliente]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_modificarcliente]
@nombre nvarchar(100),
@apellido nvarchar(100),
@telefono nvarchar(15),
@idcliente int
as
update Cliente set nombre=@nombre,apellidos=@apellido,telefono=@telefono
where idcliente=@idcliente
GO
/****** Object:  StoredProcedure [dbo].[p_modificarproducto]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[p_modificarproducto]
@idproducto int,
@nombre nvarchar(100),
@idcategoria int,
@precio decimal(18,2),
@stock int,
@idproveedor int,
@foto nvarchar(255)
as
update Producto set nombre=@nombre,idcategoria=@idcategoria,precio=@precio,
stock=@stock,idproveedor=@idproveedor,foto=@foto where idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[p_modificarproveedor]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_modificarproveedor]
@idproveedor int,
@nombre nvarchar(255),
@ruc nvarchar(12),
@representante nvarchar(150),
@direccion nvarchar(60),
@telefono nvarchar(50)
as
update Proveedor set nombre=@nombre,RUC=@ruc,representante=@representante,direccion=@direccion,telefono=@telefono
where idproveedor=@idproveedor
GO
/****** Object:  StoredProcedure [dbo].[p_mostrarcategoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_mostrarcategoria]
as
select idcategoria,nombre,descripcion from Categoria
GO
/****** Object:  StoredProcedure [dbo].[p_mostrarcuenta]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_mostrarcuenta]
@idcliente int
as
select  c.nombre+' '+ c.apellidos as 'cliente',p.nombre,vd.precio,vd.cantidad,(vd.importe-vd.montopagado) as 'importe',v.fecha from Venta v
inner join Venta_Detalle vd on v.idventa=vd.idventa
inner join Producto p on p.idproducto=vd.idproducto
inner join Cliente c on c.idcliente =v.idcliente
where v.idcliente=@idcliente and vd.cancelado=0
GO
/****** Object:  StoredProcedure [dbo].[p_mostrartodocliente]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_mostrartodocliente]
as
select idcliente,nombre,apellidos,telefono from cliente
GO
/****** Object:  StoredProcedure [dbo].[p_mostrartodoproductos]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_mostrartodoproductos]
as
select idproducto,nombre,idcategoria,precio,stock,foto,idproveedor from Producto
GO
/****** Object:  StoredProcedure [dbo].[p_nuevacategoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_nuevacategoria]
@nombre nvarchar(255),
@descripcion nvarchar(255)
as
insert into Categoria (nombre,descripcion)
values (@nombre,@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[p_nuevocliente]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_nuevocliente]
@nombre nvarchar(100),
@apellido nvarchar(100),
@telefono nvarchar(15)
as
insert into Cliente (nombre,apellidos,telefono)
values(@nombre,@apellido,@telefono)
GO
/****** Object:  StoredProcedure [dbo].[p_nuevoproducto]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_nuevoproducto]
@nombre nvarchar(100),
@idcategoria int,
@precio decimal(18,2),
@stock int,
@idproveedor int,
@foto nvarchar(255)
as
insert into Producto(nombre,idcategoria,precio,stock,idproveedor,foto)
values(@nombre,@idcategoria,@precio,@stock,@idproveedor,@foto)
GO
/****** Object:  StoredProcedure [dbo].[p_nuevoproveedor]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_nuevoproveedor]
@nombre nvarchar(255),
@ruc nvarchar(12),
@representante nvarchar(150),
@direccion nvarchar(60),
@telefono nvarchar(50)
as
insert into Proveedor (nombre,RUC,representante,direccion,telefono)
values(@nombre,@ruc,@representante,@direccion,@telefono)
GO
/****** Object:  StoredProcedure [dbo].[p_preciostock]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_preciostock]
@idproducto int
as
select precio,stock from producto where idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[p_producto]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_producto]
@idcategoria int
as
select idproducto,nombre,idcategoria,precio,stock,foto,idproveedor from Producto where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[p_registrarcompradetalle]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_registrarcompradetalle]
@idproducto int,
@importe decimal(18,2),
@cantidad int
as
declare @idcompra integer
--agregamos el idpara ventadetalle lo obtenemos del maximo de compras
select @idcompra=MAX(idcompra) from Compras
--insertamos en venta detalle       
insert into Compra_Detalles(idcompra,idproducto,importe,cantidad)
values (@idcompra,@idproducto,@importe,@cantidad)
GO
/****** Object:  StoredProcedure [dbo].[p_regitrarventadetalle]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_regitrarventadetalle]
@idproducto int,
@precio decimal(18,2),
@cantidad int,
@cancelado int
as
declare @idventa integer
--agregamos el idpara ventadetalle
select @idventa=MAX(idventa) from venta
--insertamos en venta detalle       
insert into Venta_Detalle(idventa,idproducto,precio,cantidad,importe,cancelado,montopagado)
values (@idventa,@idproducto,@precio,@cantidad,@precio*@cantidad,@cancelado,0)
GO
/****** Object:  StoredProcedure [dbo].[p_validar]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[p_validar]
@usuario nvarchar(255),
@clave nvarchar(255)
AS

declare @correcto int
if exists( select idempleado from Empleado
where  (usuario=@usuario)and(contraseña=@clave))
	set @correcto=1
else
	set @correcto=-1
RETURN @correcto
GO
/****** Object:  StoredProcedure [dbo].[p_venta]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[p_venta]
@idcliente int,
@idempleado int,
@idtipoventa int,
@fecha nvarchar(30)
as
insert into Venta (idcliente,idempleado,fecha,idtipoventa)
values (@idcliente,@idempleado,@fecha,@idtipoventa)
GO
/****** Object:  StoredProcedure [dbo].[productos_pa_comprar]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[productos_pa_comprar]
as 
select nombre,stock,foto from Producto where stock <= 3
GO
/****** Object:  StoredProcedure [dbo].[sp_categoria]    Script Date: 16/10/2022 05:27:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_categoria]
as
select idcategoria,nombre from categoria
GO
USE [master]
GO
ALTER DATABASE [Tienda_Rosa] SET  READ_WRITE 
GO
