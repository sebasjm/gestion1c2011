USE gd1c2011
GO
CREATE SCHEMA [la_huerta] AUTHORIZATION [gd]
GO
CREATE TABLE [la_huerta].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	primary key (dni)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[TipoEmpleado](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Marca](
	[id] [smallint] NOT NULL,
	[nombre] [varchar](20) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Empleado](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[tipoEmpleado_id] [int] NOT NULL,
	[sucursal_id] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Usuario](
	[empleado_dni] [int] NOT NULL,
	[username] [varchar](10) NOT NULL,
	[password] [varchar](10) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Sucursal](
	[id] [int] NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[tipoSucursal_id] [smallint] NOT NULL,
	[provincia_id] [tinyint] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Producto](
	[id] [int] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [float] NOT NULL,
	[marca_id] [smallint] NOT NULL,
	[categoria_id] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Factura](
	[numero] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [tinyint] NOT NULL,
	[cliente] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Stock](
	[sucursal_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[stock] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[IngresoStock](
	[sucursal_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[stock] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Pago](
	[factura_numero] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[UsuarioRol](
	[usuario_empleado_dni] [int] NOT NULL,
	[rol_id] [tinyint] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Rol](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[RolFuncionalidad](
	[rol_id] [tinyint] NOT NULL,
	[funcionalidad_id] [tinyint] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Funcionalidad](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Categoria](
	[id] [smallint] NOT NULL,
	[categoria_padre] [smallint] NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[ItemFactura](
	[factura_numero] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Provincia](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](60) NOT NULL
) ON [PRIMARY]

CREATE TABLE [la_huerta].[TipoSucursal](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](20) NULL
) ON [PRIMARY]
