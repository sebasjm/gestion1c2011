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
--	unique (mail)
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
    [usuario_id] [int] NULL DEFAULT NULL,
	primary key (dni),
    foreign key (tipoEmpleado_id) references [la_huerta].[TipoEmpleado](id),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
    foreign key (usuario_id) references [la_huerta].[Usuario](id)
--	unique (mail),
--	unique (usuario_id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Categoria](
	[id] [smallint] NOT NULL,
	[categoria_padre] [smallint] NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
    foreign key (categoria_padre) references [la_huerta].[Categoria](id)
--	unique (nombre)
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

-----------------------------------------
-- Carga de datos
-----------------------------------------

-- 2 
INSERT INTO [la_huerta].[TipoSucursal] 
SELECT 
	row_number() OVER (ORDER BY suc_tipo) AS id, 
	suc_tipo
FROM gd_esquema.Maestra
GROUP BY suc_tipo
ORDER BY suc_tipo

-- 140
INSERT INTO [la_huerta].[Cliente] 
SELECT 
	cli_dni as dni, 
	cli_nombre as nombre,
	cli_apellido as apellido,
	cli_mail as mail
FROM gd_esquema.Maestra
WHERE cli_dni is not null
GROUP BY cli_dni, cli_nombre, cli_apellido, cli_mail
ORDER BY cli_dni

-- 26855
INSERT INTO [la_huerta].[Factura] 
SELECT 
	factura_nro as numero,
	factura_descuento as descuento,
	factura_total as total,
	factura_fecha as fecha,
	factura_cant_coutas as cuotas,
	cli_dni as cliente_dni
FROM gd_esquema.Maestra 
WHERE cli_dni is not null
GROUP BY 
	factura_nro,
	factura_descuento,
	factura_total,
	factura_fecha,
	factura_cant_coutas,
	cli_dni

-- 11
INSERT INTO [la_huerta].[Marca] 
SELECT 
	row_number() OVER (ORDER BY producto_marca) AS id, 
	producto_marca as marca
FROM gd_esquema.Maestra 
WHERE producto_marca is not null
GROUP BY 
	producto_marca
ORDER BY producto_marca

-- 24
INSERT INTO [la_huerta].[Provincia] 
SELECT 
	row_number() OVER (ORDER BY suc_provincia) AS id, 
	suc_provincia as nombre
FROM gd_esquema.Maestra 
WHERE suc_provincia is not null
GROUP BY 
	suc_provincia
ORDER BY suc_provincia

-- 24
INSERT INTO [la_huerta].[Sucursal] 
SELECT 
	row_number() OVER (ORDER BY suc_dir) AS id, 
	suc_dir as direccion,
	suc_tel as telefono,
	ts.id as tipo,
	p.id as provincia
FROM gd_esquema.Maestra 
JOIN la_huerta.TipoSucursal as ts ON suc_tipo = ts.nombre
JOIN la_huerta.Provincia as p ON suc_provincia = p.nombre
WHERE suc_dir is not null
GROUP BY 
	suc_dir,
	suc_tel,
	ts.id,
	p.id
ORDER BY suc_dir

-- 2
INSERT INTO [la_huerta].[TipoEmpleado] 
SELECT 
	row_number() OVER (ORDER BY empleado_tipo) AS id, 
    empleado_tipo
FROM gd_esquema.Maestra 
WHERE empleado_tipo is not null
GROUP BY 
	empleado_tipo
ORDER BY empleado_tipo

-- 53
INSERT INTO [la_huerta].[Empleado] 
SELECT 
	empleado_dni as dni,
    empleado_nombre as nombre,
	empleado_apellido as apellido,
	empleado_mail as mail,
	empleado_dir as direccion,
	te.id as tipoEmpleado_id,
	s.id as sucursal_id,
	1 as activo,
	NULL as usuario_id
FROM gd_esquema.Maestra 
JOIN la_huerta.TipoEmpleado as te ON empleado_tipo = te.nombre
JOIN la_huerta.Provincia as p ON empleado_provincia = p.nombre
JOIN la_huerta.Sucursal as s ON p.id = s.provincia_id
WHERE empleado_dni is not null
GROUP BY 
	empleado_dni,
    empleado_nombre,
	empleado_apellido,
	empleado_mail,
	empleado_dir,
	te.id,
	s.id
ORDER BY empleado_dni

-- 118338
INSERT INTO [la_huerta].[Pago] 
SELECT 
	factura_nro as factura,
	pago_fecha as fecha,
	f.cuotas * pago_monto / (f.total * (1-f.descuento)) as cuotas,
	empleado_dni as empleado
FROM gd_esquema.Maestra 
JOIN la_huerta.Factura as f ON factura_nro = f.numero
WHERE pago_fecha is not null
GROUP BY 
	pago_fecha,
    pago_monto,
	f.total,
	f.descuento,
	empleado_dni,
	f.cuotas,
	factura_nro
ORDER BY pago_fecha

--------------------------------
-- Categorias (revisar se hay otra manera mejor de hacerlo)
--------------------------------

-- todas las categorias ordenadas
select producto_cate
from gd_esquema.Maestra
where producto_cate is not null
group by producto_cate
order by producto_cate

-- maxima cantidad de categorias
-- son 4 niveles de categoria
-- con esto se que hay que hacer union de 4 selects
select top 1 * from (
select max( LEN(producto_cate) - LEN(REPLACE(producto_cate, '¦', '')) ) as max_col
from gd_esquema.Maestra
where producto_cate is not null
group by LEN(producto_cate) - LEN(REPLACE(producto_cate, '¦', ''))
) tabla 
order by  max_col desc


-- consulta
-- un select por cada nivel

select * 
from (
	select substring(producto_cate,0,charindex('¦',producto_cate)) as nombre,
	NULL as padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
where nombre <> ''

union

select * 
from (
select 
	substring(
		producto_cate + '¦',
		charindex('¦',producto_cate + '¦')+1,
		charindex('¦',producto_cate + '¦',charindex('¦',producto_cate + '¦')+1) - charindex('¦',producto_cate + '¦')-1
	) as nombre,
	substring(producto_cate,0,charindex('¦',producto_cate)) as padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
where nombre <> ''

union

select * 
from (
select 
	substring(
		producto_cate + '¦¦',
		charindex('¦',producto_cate + '¦¦',charindex('¦',producto_cate + '¦¦')+1)+1,
		charindex('¦',producto_cate + '¦¦',charindex('¦',producto_cate + '¦¦',charindex('¦',producto_cate + '¦¦')+1)+1) - charindex('¦',producto_cate + '¦¦',charindex('¦',producto_cate + '¦¦')+1) -1
	) as nombre,
	substring(
		producto_cate + '¦',
		charindex('¦',producto_cate + '¦')+1,
		charindex('¦',producto_cate + '¦',charindex('¦',producto_cate + '¦')+1) - charindex('¦',producto_cate + '¦')-1
	) as padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
where nombre <> ''

union

select * 
from (
select 
	substring(
		producto_cate + '¦¦¦',
		charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦')+1)+1) +1,
		charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦')+1)+1)+1) - charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦')+1)+1) -1
	) as nombre,
	substring(
		producto_cate + '¦¦',
		charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦')+1)+1,
		charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦')+1)+1) - charindex('¦',producto_cate + '¦¦¦',charindex('¦',producto_cate + '¦¦¦')+1) -1
	) as padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
where nombre <> ''

order by padre,nombre


GO









-- preguntas

-- como hacer un unique cuando la columna puede tener nulos?

-- resultado raro
/*
SELECT cuotas, count(*)
FROM (
SELECT 
	pago_fecha as fecha,
    pago_monto,
	f.total,
	f.cuotas * pago_monto / (f.total * (1-f.descuento)) as cuotas,
	empleado_dni as empleado,
	f.cuotas as cant_cuotas,
	factura_nro as factura
FROM gd_esquema.Maestra 
JOIN la_huerta.Factura as f ON factura_nro = f.numero
WHERE pago_fecha is not null
GROUP BY 
	pago_fecha,
    pago_monto,
	f.total,
	f.descuento,
	empleado_dni,
	f.cuotas,
	factura_nro
--ORDER BY empleado_dni
)pepe
group by cuotas
*/