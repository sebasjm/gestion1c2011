USE gd1c2011
GO
CREATE SCHEMA [EL_GRUPO] AUTHORIZATION [gd]
GO
CREATE TABLE [EL_GRUPO].[Provincia](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[provincia_id] [tinyint] NULL ,
    [activo] [bit] NOT NULL DEFAULT 1,
	primary key (dni),
    foreign key (provincia_id) references [EL_GRUPO].[Provincia](id),
--	unique (mail)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[TipoEmpleado](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Marca](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[TipoSucursal](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](20) NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Sucursal](
	[id] [tinyint] NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[tipoSucursal_id] [tinyint] NOT NULL,
	[provincia_id] [tinyint] NOT NULL,
	primary key (id),
    foreign key (tipoSucursal_id) references [EL_GRUPO].[TipoSucursal](id),
    foreign key (provincia_id) references [EL_GRUPO].[Provincia](id),
	unique (direccion),
	unique (telefono)
) ON [PRIMARY]
CREATE TABLE [EL_GRUPO].[Empleado](
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
    foreign key (tipoEmpleado_id) references [EL_GRUPO].[TipoEmpleado](id),
    foreign key (sucursal_id) references [EL_GRUPO].[Sucursal](id),
--	unique (mail),
--	unique (usuario_id)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[password] [varchar](64) NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
	[empleado_dni] [int] NOT NULL DEFAULT NULL,
	[intentos] [tinyint] NOT NULL DEFAULT 0,
	foreign key (empleado_dni) references [EL_GRUPO].[Empleado](dni),
	primary key (id),
	unique (username)
) ON [PRIMARY]


CREATE TABLE [EL_GRUPO].[Categoria](
	[id] [smallint] NOT NULL,
	[categoria_padre] [smallint] NULL,
	[nombre] [varchar](30) NOT NULL,
--	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
    foreign key (categoria_padre) references [EL_GRUPO].[Categoria](id)
--	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Producto](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](70) NOT NULL, -- max 38
	[descripcion] [varchar](200) NULL,
	[precio] [float] NOT NULL,
	[marca_id] [smallint] NOT NULL,
	[categoria_id] [smallint] NOT NULL,
    [activo] [bit] NOT NULL DEFAULT 1,
	primary key (codigo),
    foreign key (marca_id) references [EL_GRUPO].[Marca](id),
    foreign key (categoria_id) references [EL_GRUPO].[Categoria](id),
--	unique (nombre,marca_id)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Factura](
	[numero] [int] IDENTITY(1,1) NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [tinyint] NOT NULL,
	[cliente_dni] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL,
	[cuotas_pagas] [tinyint] NOT NULL,
	primary key (numero),
    foreign key (cliente_dni) references [EL_GRUPO].[Cliente](dni),
    foreign key (empleado_dni) references [EL_GRUPO].[Empleado](dni)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Stock](
	[sucursal_id] [tinyint] NOT NULL,
	[producto_codigo] [int] NOT NULL,
	[stock] [int] NOT NULL,
	primary key (sucursal_id,producto_codigo),
    foreign key (sucursal_id) references [EL_GRUPO].[Sucursal](id),
    foreign key (producto_codigo) references [EL_GRUPO].[Producto](codigo)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[IngresoStock](
	[sucursal_id] [tinyint] NOT NULL,
	[producto_codigo] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[stock] [int] NOT NULL,
	primary key (sucursal_id,producto_codigo,fecha),
    foreign key (sucursal_id) references [EL_GRUPO].[Sucursal](id),
    foreign key (empleado_dni) references [EL_GRUPO].[Empleado](dni),
    foreign key (producto_codigo) references [EL_GRUPO].[Producto](codigo)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Pago](
	[factura_numero] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[cuotas] [int] NOT NULL,
	[empleado_dni] [int] NOT NULL,
	primary key (factura_numero,fecha),
    foreign key (empleado_dni) references [EL_GRUPO].[Empleado](dni),
    foreign key (factura_numero) references [EL_GRUPO].[Factura](numero)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Rol](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[activo] [bit] NOT NULL DEFAULT 1,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[Funcionalidad](
	[id] [tinyint] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	primary key (id),
	unique (nombre)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[UsuarioRol](
	[usuario_id] [int] NOT NULL,
	[rol_id] [tinyint] NOT NULL,
	primary key (usuario_id,rol_id),
    foreign key (usuario_id) references [EL_GRUPO].[Usuario](id),
    foreign key (rol_id) references [EL_GRUPO].[Rol](id)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[RolFuncionalidad](
	[rol_id] [tinyint] NOT NULL,
	[funcionalidad_id] [tinyint] NOT NULL,
	primary key (rol_id,funcionalidad_id),
    foreign key (rol_id) references [EL_GRUPO].[Rol](id),
    foreign key (funcionalidad_id) references [EL_GRUPO].[Funcionalidad](id)
) ON [PRIMARY]

CREATE TABLE [EL_GRUPO].[ItemFactura](
	[factura_numero] [int] NOT NULL,
	[producto_codigo] [int] NOT NULL,
	[producto_precio] [int] NOT NULL,	
	[cantidad] [int] NOT NULL,
	primary key (factura_numero,producto_codigo),
    foreign key (factura_numero) references [EL_GRUPO].[Factura](numero),
    foreign key (producto_codigo) references [EL_GRUPO].[Producto](codigo)
) ON [PRIMARY]

GO

-----------------------------------------
-- Funciones
-----------------------------------------

create function EL_GRUPO.categoria_id_collection(  @id as int ) 
returns @cats_id table ( id int ) as
begin
	if ( @id is null ) return;
	insert @cats_id values( @id );
	insert @cats_id 
		select * from EL_GRUPO.categoria_id_collection( 
			(select categoria_padre from EL_GRUPO.categoria where id = @id )
		);
	return;
end
go
create function EL_GRUPO.categoria_root(  @id as int ) 
returns int 
begin
	declare @parent as int, @cat_id as int
	select @cat_id = id, @parent = categoria_padre from EL_GRUPO.Categoria where id = @id;
	if ( @parent is null ) 
		return @cat_id;
	return EL_GRUPO.categoria_root( @parent );
end
go
create function EL_GRUPO.split(  @str as varchar(200), @delimiter as char, @index as int ) 
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

create function EL_GRUPO.back_split(  @str as varchar(200), @delimiter as char, @index as int ) 
returns varchar(200)
begin
	declare @pos as int
	set @pos = 0
	while ( EL_GRUPO.split(@str, @delimiter, @pos) is not null )
	begin
		set @pos = @pos + 1
	end
	if ( @pos > @index ) return EL_GRUPO.split(@str, @delimiter, @pos - @index  -1 )
	return null
end
go

create function EL_GRUPO.get_categoria_fullname(  @categoria as smallint ) 
returns varchar(200)
begin
	declare @fullname as varchar(200)
	declare @parent as smallint

	select 
		@fullname = nombre,
		@parent = categoria_padre 
	from EL_GRUPO.Categoria 
	where id = @categoria;

	while @parent is not null
	begin
		select 
			@fullname = nombre + '¦' + @fullname,
			@parent = categoria_padre 
		from EL_GRUPO.Categoria 
		where id = @parent
	end
	
	return @fullname;
end
go

create function EL_GRUPO.get_categoria_id(  @categoria as varchar(200) ) 
returns smallint
begin
	declare @fullname as varchar(200)
	declare @parent as smallint
	declare @id as smallint
	declare @name as varchar(200)

	select @name = parsename(replace(@categoria,'¦','.'),1)

	declare CURSORITO cursor for 
		select categoria_padre, id from EL_GRUPO.Categoria where nombre = @name
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
			from EL_GRUPO.Categoria 
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

CREATE FUNCTION EL_GRUPO.stock_a_la_fecha(@sucursal as int, @producto as int, @fecha as datetime)
RETURNS int
BEGIN
	DECLARE @stock int;

	SELECT @stock = sum(ins.stock)
	FROM EL_GRUPO.IngresoStock as ins
	WHERE sucursal_id  = @sucursal and ins.producto_codigo = @producto and
		fecha < @fecha;

	SELECT @stock = @stock - sum(itf.cantidad)
	FROM EL_GRUPO.ItemFactura as itf
	JOIN EL_GRUPO.Factura as f ON itf.factura_numero = f.numero
	JOIN EL_GRUPO.Empleado as e ON e.dni = f.empleado_dni
	WHERE sucursal_id = @sucursal and itf.producto_codigo = @producto and
		fecha < @fecha;

	return @stock;
END
go
-----------------------------------------
-- Stored procedures
-----------------------------------------
CREATE PROCEDURE EL_GRUPO.dias_sin_stock(@suc as int, @anio as varchar(10), @out_prod as int output, @out_dias as int output)
AS
BEGIN
	DECLARE @inicio as datetime;
	DECLARE @fin as datetime;

	SELECT @inicio = CAST(@anio+'-01-01 00:00:00.0' AS datetime);
	SELECT @fin = CAST(@anio+'-12-31 23:59:59.9' AS datetime);

	DECLARE movimiento CURSOR FOR 
			SELECT f.fecha as fecha, itf.producto_codigo as prod, -1*itf.cantidad as cant
				FROM EL_GRUPO.ItemFactura as itf
				JOIN EL_GRUPO.Factura as f ON itf.factura_numero = f.numero
				JOIN EL_GRUPO.Empleado as e ON e.dni = f.empleado_dni
				WHERE sucursal_id = @suc and f.fecha > @inicio AND f.fecha < @fin
			UNION
			SELECT ins.fecha as fecha, ins.producto_codigo as prod, ins.stock
				FROM EL_GRUPO.IngresoStock as ins
				WHERE sucursal_id = @suc and ins.fecha > @inicio AND ins.fecha < @fin
			ORDER BY prod,fecha;


	DECLARE @fecha as datetime, @producto as int, @cant as int;
	DECLARE @ant_fecha as datetime, @ant_prod as int;
	DECLARE @dias int;
	DECLARE @stock int;

	OPEN movimiento;
	FETCH NEXT FROM movimiento INTO @fecha, @producto, @cant;

	SELECT @out_prod = 0;
	SELECT @out_dias = 0;
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		SELECT @dias = 0;
		SELECT @stock = EL_GRUPO.stock_a_la_fecha(@suc, @producto, @inicio);

		SELECT @ant_prod = @producto;
		WHILE (@@FETCH_STATUS = 0 AND @producto = @ant_prod)
		BEGIN
			IF (@stock < 1) BEGIN
				SELECT @dias = @dias + datediff(d,@ant_fecha,@fecha);
				IF(@out_dias < @dias) BEGIN
					SELECT @out_dias = @dias;
					SELECT @out_prod = @producto;
				END	
			END ELSE BEGIN
				SELECT @ant_fecha = @fecha;
			END

			SELECT @stock = @stock + @cant;

			FETCH NEXT FROM movimiento INTO @fecha, @producto, @cant;
		END

	END

	CLOSE movimiento;
	DEALLOCATE movimiento;
END;
go
-----------------------------------------
-- Carga de datos
-----------------------------------------

-- 2 
INSERT INTO [EL_GRUPO].[TipoSucursal] 
SELECT 
	row_number() OVER (ORDER BY suc_tipo) AS id, 
	suc_tipo
FROM gd_esquema.Maestra
GROUP BY suc_tipo
ORDER BY suc_tipo

-- 140
INSERT INTO [EL_GRUPO].[Cliente] 
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
INSERT INTO [EL_GRUPO].[Marca] 
SELECT 
	producto_marca as marca,
	1 as activo
FROM gd_esquema.Maestra 
WHERE producto_marca is not null
GROUP BY 
	producto_marca
ORDER BY producto_marca

-- 24
INSERT INTO [EL_GRUPO].[Provincia] 
SELECT 
	row_number() OVER (ORDER BY suc_provincia) AS id, 
	suc_provincia as nombre
FROM gd_esquema.Maestra 
WHERE suc_provincia is not null
GROUP BY 
	suc_provincia
ORDER BY suc_provincia

-- 24
INSERT INTO [EL_GRUPO].[Sucursal] 
SELECT 
	row_number() OVER (ORDER BY suc_dir) AS id, 
	suc_dir as direccion,
	suc_tel as telefono,
	ts.id as tipo,
	p.id as provincia
FROM gd_esquema.Maestra 
JOIN EL_GRUPO.TipoSucursal as ts ON suc_tipo = ts.nombre
JOIN EL_GRUPO.Provincia as p ON suc_provincia = p.nombre
WHERE suc_dir is not null
GROUP BY 
	suc_dir,
	suc_tel,
	ts.id,
	p.id
ORDER BY suc_dir

-- 2
INSERT INTO [EL_GRUPO].[TipoEmpleado] 
SELECT 
	row_number() OVER (ORDER BY empleado_tipo) AS id, 
    empleado_tipo
FROM gd_esquema.Maestra 
WHERE empleado_tipo is not null
GROUP BY 
	empleado_tipo
ORDER BY empleado_tipo

-- 53
INSERT INTO [EL_GRUPO].[Empleado] 
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
JOIN EL_GRUPO.TipoEmpleado as te ON empleado_tipo = te.nombre
JOIN EL_GRUPO.Provincia as p ON empleado_provincia = p.nombre
JOIN EL_GRUPO.Sucursal as s ON p.id = s.provincia_id
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
INSERT INTO [EL_GRUPO].[Factura]
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
INSERT INTO [EL_GRUPO].[Pago] 
SELECT 
	factura_nro as factura,
	pago_fecha as fecha,	
	0.001 + f.cuotas * pago_monto / (f.total * (1-f.descuento)) as cuotas,
	f.empleado_dni as empleado
FROM gd_esquema.Maestra 
JOIN EL_GRUPO.Factura as f ON factura_nro = f.numero
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
insert into EL_GRUPO.Categoria
select 
	row_number() OVER (ORDER BY EL_GRUPO.split(producto_cate,'¦',0)) AS id, 
	NULL as categoria_padre,
	EL_GRUPO.split(producto_cate,'¦',0) as nombre
from gd_esquema.Maestra
where producto_cate is not null
and EL_GRUPO.split(producto_cate,'¦',0) <> ''
group by EL_GRUPO.split(producto_cate,'¦',0)
order by EL_GRUPO.split(producto_cate,'¦',0)

-- 30
insert into EL_GRUPO.Categoria
select 
	row_number() OVER (order by cat.id, EL_GRUPO.split(producto_cate,'¦',1)) + 8 AS id, 
	cat.id,
	EL_GRUPO.split(producto_cate,'¦',1) as nombreT
from gd_esquema.Maestra
join EL_GRUPO.Categoria as cat on cat.nombre = EL_GRUPO.split(producto_cate,'¦',0)
where producto_cate is not null
and EL_GRUPO.split(producto_cate,'¦',1) <> ''
group by cat.id, EL_GRUPO.split(producto_cate,'¦',1)
order by cat.id, EL_GRUPO.split(producto_cate,'¦',1)


-- 31
insert into EL_GRUPO.Categoria
select 
	row_number() OVER (order by cat.id, EL_GRUPO.split(producto_cate,'¦',2)) + 38 AS id, 
	cat.id,
	EL_GRUPO.split(producto_cate,'¦',2)
from gd_esquema.Maestra
join EL_GRUPO.Categoria as cat on cat.nombre = EL_GRUPO.split(producto_cate,'¦',1)
where producto_cate is not null
and EL_GRUPO.split(producto_cate,'¦',2) <> ''
group by cat.id, EL_GRUPO.split(producto_cate,'¦',2)
order by cat.id, EL_GRUPO.split(producto_cate,'¦',2)

-- 24
insert into EL_GRUPO.Categoria
select 
	row_number() OVER (order by cat.id, EL_GRUPO.split(producto_cate,'¦',3)) + 69 AS id, 
	cat.id,
	EL_GRUPO.split(producto_cate,'¦',3)
from gd_esquema.Maestra
join EL_GRUPO.Categoria as cat on cat.nombre = EL_GRUPO.split(producto_cate,'¦',2)
where producto_cate is not null
and EL_GRUPO.split(producto_cate,'¦',3) <> ''
group by cat.id, EL_GRUPO.split(producto_cate,'¦',3)
order by cat.id, EL_GRUPO.split(producto_cate,'¦',3)

-- 99
INSERT INTO [EL_GRUPO].[Producto] 
SELECT 
	EL_GRUPO.back_split(producto_nombre,' ',0) AS codigo, 
    substring(producto_nombre,0,len(producto_nombre) - len(EL_GRUPO.back_split(producto_nombre,' ',0))) as nombre,
	producto_desc as descripcion,
	producto_precio as precio,
	m.id as marca_id,
    cat.id as categoria_id ,
	1 as activo
FROM gd_esquema.Maestra 
JOIN EL_GRUPO.Categoria as cat ON EL_GRUPO.get_categoria_id( producto_cate ) = cat.id
JOIN EL_GRUPO.Marca as m ON m.nombre = producto_marca
WHERE producto_nombre is not null and producto_precio <> 0
GROUP BY 
    producto_nombre,
	producto_desc,
	producto_precio,
	m.id,
    cat.id
ORDER BY producto_nombre

-- 179238
INSERT INTO [EL_GRUPO].[ItemFactura] 
SELECT 
	f.numero as factura_numero, 
    p.codigo as producto_codigo,
	producto_precio as producto_precio,
	producto_cant
FROM gd_esquema.Maestra 
JOIN EL_GRUPO.Factura as f ON f.numero = factura_nro
JOIN EL_GRUPO.Producto as p ON p.codigo = EL_GRUPO.back_split(producto_nombre,' ',0)
WHERE factura_nro is not null
GROUP BY 
	f.numero, 
    p.codigo,
	producto_precio,
	producto_cant
ORDER BY f.numero

-- 174424
insert into EL_GRUPO.IngresoStock
select 
	s.id as sucursal_id, 
	p.codigo as producto_codigo, 
	empleado_dni as empleado_dni,
	llegada_stock_fecha as fecha, 
	llegada_stock_cant as stock
from gd_esquema.Maestra
join EL_GRUPO.Sucursal as s on s.direccion = suc_dir
join EL_GRUPO.Producto as p on p.codigo = EL_GRUPO.back_split(producto_nombre,' ',0)
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
insert into EL_GRUPO.Stock 
select s.sucursal_id, s.producto_codigo, sum(stock)  - isnull((
	select sum(cantidad) as vendido
	from (EL_GRUPO.ItemFactura as i
	join EL_GRUPO.Factura as f on i.factura_numero = f.numero)
	join EL_GRUPO.Empleado as e on f.empleado_dni = e.dni
	where e.sucursal_id = s.sucursal_id and i.producto_codigo = s.producto_codigo 
), 0) as stock
from EL_GRUPO.IngresoStock as s
group by sucursal_id, producto_codigo
order by sucursal_id, producto_codigo


----------------
-- Tablas de Facturas
-- coutas pagadas de cada factura
----------------
-- 26855
update EL_GRUPO.Factura 
set cuotas_pagas = 
	(select sum(p.cuotas) from EL_GRUPO.Pago as p where numero = p.factura_numero)

----------------
-- Tablas de usuario
----------------
insert into EL_GRUPO.Usuario ( username , password, empleado_dni ) values ('admin','E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7',352287)
----------------

----------------
-- Funcionalidades del sistema.
----------------
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (1,'ABM de Empleado','ABM de Empleado')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (2,'ABM de Rol','ABM de Rol')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (3,'ABM de Usuario','ABM de Usuario')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (4,'ABM de Cliente','ABM de Cliente')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (5,'ABM de Producto','ABM de Producto')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (6,'Asignación de stock','Asignación de stock')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (7,'Facturación','Facturación')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (8,'Efectuar Pago','Efectuar Pago')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (9,'Tablero de Control','Tablero de Control')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (10,'Mejores Categorías','Mejores Categorías')
insert into EL_GRUPO.funcionalidad ( id , nombre , descripcion ) values (11,'Cliente Premium','Cliente Premium')
----------------

-- Se agregaron los insert de las Funcionalidades del Admin.
insert into EL_GRUPO.Rol (nombre,descripcion,activo) values ('Admin', 'Rol administrador',1)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 1)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 2)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 3)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 4)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 5)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 6)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 7)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 8)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 9)
insert into EL_GRUPO.RolFuncionalidad ( rol_id , funcionalidad_id ) values (1 , 10)

insert into EL_GRUPO.UsuarioRol values ( 1, 1 )