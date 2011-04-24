CREATE TABLE [gd_esquema].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[TipoEmpleado](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Marca](
	[id] [smallint] NOT NULL,
	[nombre] [varchar](20) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Empleado](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[tipoEmpleado_id] [int] NOT NULL,
	[sucursal_id] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Usuario](
	[empleado_dni] [int] NOT NULL,
	[username] [varchar](10) NOT NULL,
	[password] [varchar](10) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Sucursal](
	[id] [int] NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[tipoSucursal_id] [smallint] NOT NULL,
	[provincia_id] [tinyint] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Producto](
	[id] [int] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [float] NOT NULL,
	[marca_id] [smallint](10) NOT NULL,
	[categoria_id] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Factura](
	[numero] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [tinyint] NOT NULL,
	[cliente] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Stock](
	[sucursal_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[stock] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[IngresoStock](
	[sucursal_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[stock] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Pago](
	[factura_numero] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[UsuarioRol](
	[usuario_empleado_dni] [int] NOT NULL,
	[rol_id] [tinyint] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Rol](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[RolFuncionalidad](
	[rol_id] [tinyint] NOT NULL,
	[funcionalidad_id] [tinyint] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Funcionalidad](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Categoria](
	[id] [smallint] NOT NULL,
	[categoria_padre] [smallint] NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[ItemFactura](
	[factura_numero] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [gd_esquema].[Provincia](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](60) NOT NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[TipoSucursal](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](20) NULL
) ON [PRIMARY]
