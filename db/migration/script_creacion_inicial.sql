USE gd1c2011
GO
CREATE SCHEMA [la_huerta] AUTHORIZATION [gd]
GO
CREATE TABLE [la_huerta].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	primary key (dni),
	unique (mail)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[TipoEmpleado](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Marca](
	[id] [smallint] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Provincia](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[TipoSucursal](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](20) NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Sucursal](
	[id] [int] NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[tipoSucursal_id] [tinyint] NOT NULL,
	[provincia_id] [tinyint] NOT NULL,
	primary key (id),
    foreign key (tipoSucursal_id) references [la_huerta].[TipoSucursal](id),
    foreign key (provincia_id) references [la_huerta].[Provincia](id),
	unique (direccion),
	unique (telefono)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Usuario](
	[id] [int] NOT NULL,
	[username] [varchar](10) NOT NULL,
	[password] [varchar](64) NOT NULL,
	primary key (id),
	unique (username)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Empleado](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[tipoEmpleado_id] [tinyint] NOT NULL,
	[sucursal_id] [int] NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
    [usuario_id] [int] NOT NULL,
	primary key (dni),
    foreign key (tipoEmpleado_id) references [la_huerta].[TipoEmpleado](id),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
    foreign key (usuario_id) references [la_huerta].[Usuario](id),
	unique (mail),
	unique (usuario_id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Categoria](
	[id] [smallint] NOT NULL,
	[categoria_padre] [smallint] NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
    foreign key (categoria_padre) references [la_huerta].[Categoria](id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Producto](
	[id] [int] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [float] NOT NULL,
	[marca_id] [smallint] NOT NULL,
	[categoria_id] [smallint] NOT NULL,
	primary key (id),
    foreign key (marca_id) references [la_huerta].[Marca](id),
    foreign key (categoria_id) references [la_huerta].[Categoria](id),
	unique (nombre,marca_id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Factura](
	[numero] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [tinyint] NOT NULL,
	[cliente_dni] [int] NOT NULL,
	primary key (numero),
    foreign key (cliente_dni) references [la_huerta].[Cliente](dni),
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Stock](
	[sucursal_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[stock] [int] NOT NULL,
	primary key (sucursal_id,producto_id),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
    foreign key (producto_id) references [la_huerta].[Producto](id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[IngresoStock](
	[sucursal_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[stock] [int] NOT NULL,
	primary key (sucursal_id,producto_id,fecha),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
    foreign key (producto_id) references [la_huerta].[Producto](id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Pago](
	[factura_numero] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL,
	primary key (factura_numero,fecha),
    foreign key (empleado_dni) references [la_huerta].[Empleado](dni),
    foreign key (factura_numero) references [la_huerta].[Factura](numero)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Rol](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Funcionalidad](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[UsuarioRol](
	[usuario_id] [int] NOT NULL,
	[rol_id] [tinyint] NOT NULL,
	primary key (usuario_id,rol_id),
    foreign key (usuario_id) references [la_huerta].[Usuario](id),
    foreign key (rol_id) references [la_huerta].[Rol](id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[RolFuncionalidad](
	[rol_id] [tinyint] NOT NULL,
	[funcionalidad_id] [tinyint] NOT NULL,
	primary key (rol_id,funcionalidad_id),
    foreign key (rol_id) references [la_huerta].[Rol](id),
    foreign key (funcionalidad_id) references [la_huerta].[Funcionalidad](id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[ItemFactura](
	[factura_numero] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[producto_precio] [int] NOT NULL,	
	[cantidad] [int] NOT NULL,
	primary key (factura_numero,producto_id),
    foreign key (factura_numero) references [la_huerta].[Factura](numero),
    foreign key (producto_id) references [la_huerta].[Producto](id)
) ON [PRIMARY]

GO
-- Carga de datos

INSERT INTO [la_huerta].[TipoSucursal] 
SELECT 
	row_number() OVER (ORDER BY suc_tipo) AS id, 
	suc_tipo
FROM gd_esquema.Maestra
GROUP BY suc_tipo
ORDER BY suc_tipo

GO