USE gd1c2011
GO
CREATE SCHEMA [la_huerta] AUTHORIZATION [gd]
GO
CREATE TABLE [la_huerta].[Provincia](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[provincia_id] [tinyint] NULL ,
    [activo] [bit] NOT NULL DEFAULT 1,
	primary key (dni),
    foreign key (provincia_id) references [la_huerta].[Provincia](id),
--	unique (mail)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[TipoEmpleado](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Marca](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
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
	[id] [tinyint] NOT NULL,
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
CREATE TABLE [la_huerta].[Empleado](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[tipoEmpleado_id] [tinyint] NOT NULL,
	[sucursal_id] [tinyint] NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
	primary key (dni),
    foreign key (tipoEmpleado_id) references [la_huerta].[TipoEmpleado](id),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
--	unique (mail),
--	unique (usuario_id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[password] [varchar](64) NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
	[empleado_dni] [int] NOT NULL DEFAULT NULL,
	foreign key (empleado_dni) references [la_huerta].[Empleado](dni),
	primary key (id),
	unique (username)
) ON [PRIMARY]


CREATE TABLE [la_huerta].[Categoria](
	[id] [smallint] NOT NULL,
	[categoria_padre] [smallint] NULL,
	[nombre] [varchar](30) NOT NULL,
--	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
    foreign key (categoria_padre) references [la_huerta].[Categoria](id)
--	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Producto](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](70) NOT NULL, -- max 38
	[descripcion] [varchar](200) NULL,
	[precio] [float] NOT NULL,
	[marca_id] [smallint] NOT NULL,
	[categoria_id] [smallint] NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
	primary key (codigo),
    foreign key (marca_id) references [la_huerta].[Marca](id),
    foreign key (categoria_id) references [la_huerta].[Categoria](id),
--	unique (nombre,marca_id)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Factura](
	[numero] [int] IDENTITY(1,1) NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [tinyint] NOT NULL,
	[cliente_dni] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL,
	[cuotas_pagas] [tinyint] NOT NULL,
	primary key (numero),
    foreign key (cliente_dni) references [la_huerta].[Cliente](dni),
    foreign key (empleado_dni) references [la_huerta].[Empleado](dni)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Stock](
	[sucursal_id] [tinyint] NOT NULL,
	[producto_codigo] [int] NOT NULL,
	[stock] [int] NOT NULL,
	primary key (sucursal_id,producto_codigo),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
    foreign key (producto_codigo) references [la_huerta].[Producto](codigo)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[IngresoStock](
	[sucursal_id] [tinyint] NOT NULL,
	[producto_codigo] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[stock] [int] NOT NULL,
	primary key (sucursal_id,producto_codigo,fecha),
    foreign key (sucursal_id) references [la_huerta].[Sucursal](id),
    foreign key (empleado_dni) references [la_huerta].[Empleado](dni),
    foreign key (producto_codigo) references [la_huerta].[Producto](codigo)
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
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[activo] [bit] NOT NULL DEFAULT 1,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [la_huerta].[Funcionalidad](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
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
	[producto_codigo] [int] NOT NULL,
	[producto_precio] [int] NOT NULL,	
	[cantidad] [int] NOT NULL,
	primary key (factura_numero,producto_codigo),
    foreign key (factura_numero) references [la_huerta].[Factura](numero),
    foreign key (producto_codigo) references [la_huerta].[Producto](codigo)
) ON [PRIMARY]

GO

-----------------------------------------
-- Funciones
-----------------------------------------

create function la_huerta.categoria_id_collection(  @id as int ) 
returns @cats_id table ( id int ) as
begin
	if ( @id is null ) return;
	insert @cats_id values( @id );
	insert @cats_id 
		select * from la_huerta.categoria_id_collection( 
			(select categoria_padre from la_huerta.categoria where id = @id )
		);
	return;
end
go
create function la_huerta.split(  @str as varchar(200), @delimiter as char, @index as int ) 
returns varchar(200)
begin
	declare @pos as int
	declare @endpos as int
	set @pos = 1
	declare @sub as varchar(200)
	set @endpos = charindex(@delimiter, @str, @pos) - @pos
	while( @pos < len(@str) and @endpos > 0 )
	begin
		set @sub = substring(@str,@pos, @endpos ) 
		set @pos = @pos + len(@sub) + 1
		set @index = @index - 1
		if ( @index < 0 ) return @sub
		set @endpos = charindex(@delimiter, @str, @pos) - @pos
	end
	if (@index = 0) return  substring(@str,@pos,len(@str))
	return null
end
go

create function la_huerta.back_split(  @str as varchar(200), @delimiter as char, @index as int ) 
returns varchar(200)
begin
	declare @pos as int
	set @pos = 0
	while ( la_huerta.split(@str, @delimiter, @pos) is not null )
	begin
		set @pos = @pos + 1
	end
	if ( @pos > @index ) return la_huerta.split(@str, @delimiter, @pos - @index  -1 )
	return null
end
go

create function la_huerta.get_categoria_fullname(  @categoria as varchar(200) ) 
returns varchar(200)
begin
	declare @fullname as varchar(200)
	declare @parent as smallint
	declare @id as smallint
	declare @name as varchar(200)

	select @name = parsename(replace(@categoria,'¦','.'),1)

	declare CURSORITO cursor for 
		select categoria_padre, id from la_huerta.Categoria where nombre = @name
	open CURSORITO

	fetch next from CURSORITO into @parent, @id

	while @@fetch_status = 0
	begin
		set @fullname = @name
		while @parent is not null
		begin
			select 
				@fullname = nombre + '¦' + @fullname,
				@parent = categoria_padre 
			from la_huerta.Categoria 
			where id = @parent
		end
		if @fullname = @categoria return @id
		fetch next from CURSORITO into @parent, @id
	end
	close CURSORITO
	deallocate CURSORITO
	return null
end
go

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
	cli_mail as mail ,
    '' as telefono,
    '' as direccion,
	null as provincia_id,
	1 as activo
FROM gd_esquema.Maestra
WHERE cli_dni is not null
GROUP BY cli_dni, cli_nombre, cli_apellido, cli_mail
ORDER BY cli_dni

-- 11
INSERT INTO [la_huerta].[Marca] 
SELECT 
	producto_marca as marca,
	1 as activo
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
    '' as telefono,
	empleado_dir as direccion,
	te.id as tipoEmpleado_id,
	s.id as sucursal_id,
	1 as activo
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

-- 26855
INSERT INTO [la_huerta].[Factura]
SELECT 
--	factura_nro as numero,
	factura_descuento as descuento,
	factura_total as total,
	factura_fecha as fecha,
	factura_cant_coutas as cuotas,
	cli_dni as cliente_dni,
    m.empleado_dni as empleado_dni,
	0 as cuotas_pagas
FROM gd_esquema.Maestra as m
WHERE cli_dni is not null
GROUP BY 
	factura_nro,
	factura_descuento,
	factura_total,
	factura_fecha,
	factura_cant_coutas,
	cli_dni,
    empleado_dni
ORDER BY
	factura_nro

-- 118338
INSERT INTO [la_huerta].[Pago] 
SELECT 
	factura_nro as factura,
	pago_fecha as fecha,
	f.cuotas * pago_monto / (f.total * (1-f.descuento)) as cuotas,
	f.empleado_dni as empleado
FROM gd_esquema.Maestra 
JOIN la_huerta.Factura as f ON factura_nro = f.numero
WHERE pago_fecha is not null
GROUP BY 
	pago_fecha,
    pago_monto,
	f.total,
	f.descuento,
	f.empleado_dni,
	f.cuotas,
	factura_nro
ORDER BY pago_fecha

-- 8
insert into la_huerta.Categoria
select 
	row_number() OVER (ORDER BY nombre) AS id, 
	NULL as categoria_padre,
	nombre
from (
	select
	la_huerta.split(producto_cate,'¦',0) as nombre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
where nombre <> ''
group by nombre
order by nombre

-- 30
insert into la_huerta.Categoria
select 
	row_number() OVER (order by cat.id, tabla.nombre) + 8 AS id, 
	cat.id,
	tabla.nombre
from (
select 
	la_huerta.split(producto_cate,'¦',1) as nombre,
	la_huerta.split(producto_cate,'¦',0) as categoria_padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
join la_huerta.Categoria as cat on cat.nombre = tabla.categoria_padre
where tabla.nombre <> ''
group by cat.id, tabla.nombre
order by cat.id, tabla.nombre


-- 31
insert into la_huerta.Categoria
select 
	row_number() OVER (order by cat.id, tabla.nombre) + 38 AS id, 
	cat.id,
	tabla.nombre
from (
select 
	la_huerta.split(producto_cate,'¦',2) as nombre,
	la_huerta.split(producto_cate,'¦',1) as categoria_padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
join la_huerta.Categoria as cat on cat.nombre = tabla.categoria_padre
where tabla.nombre <> ''
group by cat.id, tabla.nombre
order by cat.id, tabla.nombre

-- 24
insert into la_huerta.Categoria
select 
	row_number() OVER (order by cat.id, tabla.nombre) + 69 AS id, 
	cat.id,
	tabla.nombre
from (
select 
	la_huerta.split(producto_cate,'¦',3) as nombre,
	la_huerta.split(producto_cate,'¦',2) as categoria_padre
	from gd_esquema.Maestra
	where producto_cate is not null
	group by producto_cate
) tabla
join la_huerta.Categoria as cat on cat.nombre = tabla.categoria_padre
where tabla.nombre <> ''
group by cat.id, tabla.nombre
order by cat.id, tabla.nombre

-- 99
INSERT INTO [la_huerta].[Producto] 
SELECT 
	la_huerta.back_split(producto_nombre,' ',0) AS codigo, 
    substring(producto_nombre,0,len(producto_nombre) - len(la_huerta.back_split(producto_nombre,' ',0))) as nombre,
	producto_desc as descripcion,
	producto_precio as precio,
	m.id as marca_id,
    cat.id as categoria_id ,
	1 as activo
FROM gd_esquema.Maestra 
JOIN la_huerta.Categoria as cat ON la_huerta.get_categoria_fullname( producto_cate ) = cat.id
JOIN la_huerta.Marca as m ON m.nombre = producto_marca
WHERE producto_nombre is not null and producto_precio <> 0
GROUP BY 
    producto_nombre,
	producto_desc,
	producto_precio,
	m.id,
    cat.id
ORDER BY producto_nombre

-- 179238
INSERT INTO [la_huerta].[ItemFactura] 
SELECT 
	f.numero as factura_numero, 
    p.codigo as producto_codigo,
	producto_precio as producto_precio,
	producto_cant
FROM gd_esquema.Maestra 
JOIN la_huerta.Factura as f ON f.numero = factura_nro
JOIN la_huerta.Producto as p ON p.codigo = la_huerta.back_split(producto_nombre,' ',0)
WHERE factura_nro is not null
GROUP BY 
	f.numero, 
    p.codigo,
	producto_precio,
	producto_cant
ORDER BY f.numero

-- 174424
insert into la_huerta.IngresoStock
select 
	s.id as sucursal_id, 
	p.codigo as producto_codigo, 
	empleado_dni as empleado_dni,
	llegada_stock_fecha as fecha, 
	llegada_stock_cant as stock
from gd_esquema.Maestra
join la_huerta.Sucursal as s on s.direccion = suc_dir
join la_huerta.Producto as p on p.codigo = la_huerta.back_split(producto_nombre,' ',0)
where llegada_stock_fecha is not null
group by
	s.id, 
	p.codigo, 
	empleado_dni,
	llegada_stock_fecha, 
	llegada_stock_cant
order by 
	s.id, 
	empleado_dni,
	llegada_stock_fecha, 
	p.codigo, 
	llegada_stock_cant


-- 2376
insert into la_huerta.Stock 
select s.sucursal_id, s.producto_codigo, sum(stock)  - isnull((
	select sum(cantidad) as vendido
	from (la_huerta.ItemFactura as i
	join la_huerta.Factura as f on i.factura_numero = f.numero)
	join la_huerta.Empleado as e on f.empleado_dni = e.dni
	where e.sucursal_id = s.sucursal_id and i.producto_codigo = s.producto_codigo 
), 0) as stock
from la_huerta.IngresoStock as s
group by sucursal_id, producto_codigo
order by sucursal_id, producto_codigo


----------------
-- Tablas de Facturas
-- coutas pagadas de cada factura
----------------
-- 26855
update la_huerta.Factura 
set cuotas_pagas = 
	(select sum(p.cuotas) from la_huerta.Pago as p where numero = p.factura_numero)

----------------
-- Tablas de usuario
----------------
insert into la_huerta.Usuario ( username , password, empleado_dni ) values ('admin','E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7',352287)
----------------

----------------
-- Funcionalidades del sistema.
----------------
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (1,'ABM de Empleado','ABM de Empleado')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (2,'ABM de Rol','ABM de Rol')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (3,'ABM de Usuario','ABM de Usuario')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (4,'ABM de Cliente','ABM de Cliente')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (5,'ABM de Producto','ABM de Producto')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (6,'Asignación de stock','Asignación de stock')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (7,'Facturación','Facturación')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (8,'Efectuar Pago','Efectuar Pago')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (9,'Tablero de Control','Tablero de Control')
insert into la_huerta.funcionalidad ( id , nombre , descripcion ) values (10,'Mejores Categorías','Mejores Categorías')
----------------
