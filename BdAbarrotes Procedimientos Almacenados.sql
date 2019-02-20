use BdAbarrotes
----------------------------------------------------------------------------------------
-------------------- CREACION DE PROCEDIMIENTOS ALMACENADOS TUsuario -------------------
----------------------------------------------------------------------------------------

-- // Procedimiento almacenado que verifica usuario y contraseña

if exists (select * from dbo.sysobjects where name = 'spuTUsuario_Consulta')
	drop procedure spuTUsuario_Consulta
go
create procedure spuTUsuario_Consulta
	@Usuario varchar(20),
	@Contraseña varchar(20)
as
begin 
	select * from TUsuario where IdUsuario = @Usuario and Contraseña = @Contraseña
end
go

-- // Insertar un Usuario

if exists (select * from dbo.sysobjects where name = 'spuTUsuario_Insertar')
	drop procedure spuTUsuario_Insertar
go
create procedure spuTUsuario_Insertar
	@Usuario varchar(20),
	@Nombres varchar(50),
	@Contraseña varchar(20),
	@NivelAcceso int,
	@Habilitado varchar(2)
as
begin 
	insert into TUsuario values (@Usuario, @Nombres, @Contraseña, @NivelAcceso, @Habilitado)
	-- Confirmar operacion
	select CodError = 0, Mensaje = 'Registro insertado exitosamente.'
end
go

-- // Actualizar un Usuario

if exists (select * from dbo.sysobjects where name = 'spuTUsuario_Actualizar')
	drop procedure spuTUsuario_Actualizar
go
create procedure spuTUsuario_Actualizar
	@Usuario varchar(20),
	@Nombres varchar(50),
	@Contraseña varchar(20),
	@NivelAcceso int,
	@Habilitado varchar(2)
as
begin 
	update TUsuario set Nombres = @Nombres, Contraseña = @Contraseña, NivelAcceso = @NivelAcceso, Habilitado = @Habilitado where IdUsuario = @Usuario
	-- Confirmar operacion
	select CodError = 0, Mensaje = 'Registro actualizado exitosamente.'
end
go

-- // Registro de un Usuario

if exists (select * from dbo.sysobjects where name = 'spuTUsuario_Registro')
	drop procedure spuTUsuario_Registro
go
create procedure spuTUsuario_Registro
	@Usuario varchar(20)
as
begin 
	select * from TUsuario where IdUsuario = @Usuario
end
go

-- // Listado de Usuarios -----------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTUsuario_ListadoGeneral')
	drop procedure spuTUsuario_ListadoGeneral
go
create procedure spuTUsuario_ListadoGeneral
as
begin
	select * from TUsuario where NivelAcceso = 1
end
go

----------------------------------------------------------------------------------------
-------------------- CREACION DE PROCEDIMIENTOS ALMACENADOS TProducto ------------------
----------------------------------------------------------------------------------------

-- // Insertar un Producto

if exists (select * from dbo.sysobjects where name = 'spuTProducto_Insertar')
	drop procedure spuTProducto_Insertar
go
create procedure spuTProducto_Insertar
	@CodProducto varchar(10),
	@Descripcion varchar(50),
	@Unidad varchar(20),
	@Marca varchar(20),
	@Stock int,
	@Precio float
as
begin 
	insert into TProducto values(@CodProducto, @Descripcion, @Unidad, @Marca, @Stock, @Precio)
	-- Confirmar operacion
	select CodError = 0, Mensaje = 'Registro insertado exitosamente.'
end
go

-- // Actualizar un Producto

if exists (select * from dbo.sysobjects where name = 'spuTProducto_Actualizar')
	drop procedure spuTProducto_Actualizar
go
create procedure spuTProducto_Actualizar
	@CodProducto varchar(10),
	@Descripcion varchar(50),
	@Unidad varchar(20),
	@Marca varchar(20),
	@Stock int,
	@Precio float
as
begin 
	update TProducto set Descripcion = @Descripcion, Marca = @Marca, Unidad = @Unidad, Precio = @Precio, Stock = @Stock where CodProducto = @CodProducto
	-- Confirmar operacion
	select CodError = 0, Mensaje = 'Registro actualizado exitosamente.'
end
go

-- // Registro de un Producto

if exists (select * from dbo.sysobjects where name = 'spuTProducto_Registro')
	drop procedure spuTProducto_Registro
go
create procedure spuTProducto_Registro
	@CodProducto varchar(10)
as
begin 
	select * from TProducto where CodProducto = @CodProducto
end
go

-- // Listado de Productos -----------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTProducto_ListadoGeneral')
	drop procedure spuTProducto_ListadoGeneral
go
create procedure spuTProducto_ListadoGeneral
as
begin
	select * from TProducto
end
go

-- // Listado simple de Productos -----------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTProducto_ListaSimple')
	drop procedure spuTProducto_ListaSimple
go
create procedure spuTProducto_ListaSimple
as
begin
	select CodProducto,Descripcion,Marca from TProducto
end
go

--------------------------------------------------------------------------------------------------------
-------------------- CREACION DE PROCEDIMIENTOS ALMACENADOS TBOLETA Y TDETALLEBOLETA ------------------
--------------------------------------------------------------------------------------------------------

-- // Insertar una Boleta --------------------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTBoleta_Insertar')
	drop procedure spuTBoleta_Insertar
go
create procedure spuTBoleta_Insertar
	@NroBoleta varchar(10),
	@Cliente varchar(50),
	@Fecha varchar(10),
	@IdUsuario varchar(20)
as
begin 
	insert into TBoleta values (@NroBoleta, @Cliente, @Fecha, @IdUsuario)
	-- Confirmar operacion
	select CodError = 0, Mensaje = 'Registro insertado exitosamente.'
end
go

-- // Insertar un Detalle de Boleta ----------------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTDetalleBoleta_Insertar')
	drop procedure spuTDetalleBoleta_Insertar
go
create procedure spuTDetalleBoleta_Insertar
	@NroBoleta varchar(10),
	@CodProducto varchar(10),
	@Cantidad int,
	@Precio float
as
begin 
	insert into TDetalleBoleta values (@NroBoleta, @CodProducto, @Cantidad, @Precio)
	-- Confirmar operacion
	select CodError = 0, Mensaje = 'Registro insertado exitosamente.'
end
go

-- // Recuperar la ultima boleta ----------------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTBoleta_UltimaBoleta')
	drop procedure spuTBoleta_UltimaBoleta
go
create procedure spuTBoleta_UltimaBoleta
as
begin 
	select top 1 NroBoleta from TBoleta order by NroBoleta desc
end
go

-- // Productos mas vendidos ----------------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTProducto_ProductosMasVendidos')
	drop procedure spuTProducto_ProductosMasVendidos
go
create procedure spuTProducto_ProductosMasVendidos
as
begin 
	select CodProducto, Precio, sum(Cantidad) as Cantidad, sum(Cantidad*Precio) as VentaTotal from TDetalleBoleta group by CodProducto, Precio order by sum(Cantidad*Precio) desc
end
go

-- // Productos stock bajo ----------------------------------------------------------------------

if exists (select * from dbo.sysobjects where name = 'spuTProducto_ProductosStockBajo')
	drop procedure spuTProducto_ProductosStockBajo
go
create procedure spuTProducto_ProductosStockBajo
as
begin 
	select CodProducto, Descripcion, Marca, Stock from TProducto where Stock <= 10 order by Stock
end
go

-- // Reporte de ganancias por dia

if exists (select * from dbo.sysobjects where name = 'spuTBoleta_GananciasPorDia')
	drop procedure spuTBoleta_GananciasPorDia
go
create procedure spuTBoleta_GananciasPorDia
	@Fecha varchar(10)
as
begin 
	select B.NroBoleta, sum(Cantidad*Precio) as TotalVentas 
		from TBoleta B inner join TDetalleBoleta D on (B.NroBoleta = D.NroBoleta)
		where B.Fecha = @Fecha
		group by B.NroBoleta
end
go
