USE gd1c2011
GO

DROP PROCEDURE EL_GRUPO.dias_sin_stock;

GO

DROP FUNCTION EL_GRUPO.get_categoria_fullname;
DROP FUNCTION EL_GRUPO.get_categoria_id;
drop function EL_GRUPO.split;
drop function EL_GRUPO.back_split;
drop function EL_GRUPO.categoria_id_collection;
drop function EL_GRUPO.stock_a_la_fecha;

GO

DROP TABLE [EL_GRUPO].[ItemFactura]
DROP TABLE [EL_GRUPO].[RolFuncionalidad]
DROP TABLE [EL_GRUPO].[UsuarioRol]
DROP TABLE [EL_GRUPO].[Funcionalidad]
DROP TABLE [EL_GRUPO].[Rol]
DROP TABLE [EL_GRUPO].[Pago]
DROP TABLE [EL_GRUPO].[IngresoStock]
DROP TABLE [EL_GRUPO].[Stock]
DROP TABLE [EL_GRUPO].[Factura]
DROP TABLE [EL_GRUPO].[Producto]
DROP TABLE [EL_GRUPO].[Categoria]
DROP TABLE [EL_GRUPO].[Usuario]
DROP TABLE [EL_GRUPO].[Empleado]
DROP TABLE [EL_GRUPO].[Sucursal]
DROP TABLE [EL_GRUPO].[TipoSucursal]
DROP TABLE [EL_GRUPO].[Marca]
DROP TABLE [EL_GRUPO].[TipoEmpleado]
DROP TABLE [EL_GRUPO].[Cliente]
DROP TABLE [EL_GRUPO].[Provincia]

GO
DROP SCHEMA [EL_GRUPO]
GO
