USE [DBSISTEMA_GESTION]
GO
/****** Object:  Table [dbo].[Arreglo]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arreglo](
	[IdArreglo] [int] IDENTITY(1,1) NOT NULL,
	[TipoArreglo] [nvarchar](50) NULL,
	[Costo] [decimal](18, 2) NULL,
	[IdContrato] [int] NULL,
 CONSTRAINT [PK_Arreglo] PRIMARY KEY CLUSTERED 
(
	[IdArreglo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contrato]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contrato](
	[IdContrato] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
	[Monto] [decimal](18, 2) NULL,
	[IdInquilino] [int] NULL,
 CONSTRAINT [PK_Contrato] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Garante]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Garante](
	[IdGarante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[IdInquilino] [int] NULL,
 CONSTRAINT [PK_Garante] PRIMARY KEY CLUSTERED 
(
	[IdGarante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inquilino]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquilino](
	[IdInquilino] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NULL,
	[Apellido] [nchar](10) NULL,
	[Telefono] [nchar](25) NULL,
	[DNI] [nchar](10) NULL,
 CONSTRAINT [PK_Inquilino] PRIMARY KEY CLUSTERED 
(
	[IdInquilino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[IdServicio] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NULL,
	[Costo] [decimal](18, 2) NULL,
	[IdContrato] [int] NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[IdServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Arreglo]  WITH CHECK ADD  CONSTRAINT [FK_Arreglo_Contrato] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contrato] ([IdContrato])
GO
ALTER TABLE [dbo].[Arreglo] CHECK CONSTRAINT [FK_Arreglo_Contrato]
GO
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_Inquilino] FOREIGN KEY([IdInquilino])
REFERENCES [dbo].[Inquilino] ([IdInquilino])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [FK_Contrato_Inquilino]
GO
ALTER TABLE [dbo].[Garante]  WITH CHECK ADD  CONSTRAINT [FK_Garante_Inquilino] FOREIGN KEY([IdInquilino])
REFERENCES [dbo].[Inquilino] ([IdInquilino])
GO
ALTER TABLE [dbo].[Garante] CHECK CONSTRAINT [FK_Garante_Inquilino]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Contrato] FOREIGN KEY([IdContrato])
REFERENCES [dbo].[Contrato] ([IdContrato])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Contrato]
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARARREGLO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_EDITARARREGLO] (							/*CORRECCION DE VALIDACIONES PARA PODER CONDICIONAR EDICION Y GUARDADO DE SERVICIOS*/
@idArreglo int,
@tipo varchar(50),	
@costo decimal(18, 2),
@idContrato int,	
@Resultado bit output,
@Mensaje varchar(500) output	
)
AS
BEGIN
    SET @Resultado = 1

   /* Verificar si el mismo tipo de arreglo ya existe en el mismo contrato, excluyendo el arreglo que se está editando*/
    IF EXISTS (
        SELECT 1 FROM Arreglo 
        WHERE IdContrato = @idContrato 
        AND TipoArreglo = @tipo 
        AND IdArreglo <> @idArreglo
    )
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'No puede existir un contrato con el mismo tipo de arreglo registrado.'
    END
    ELSE
    BEGIN
        /*Verificar si el arreglo a editar realmente existe*/
        IF EXISTS (SELECT 1 FROM Arreglo WHERE IdArreglo = @idArreglo)
        BEGIN
            UPDATE Arreglo 
            SET TipoArreglo = @tipo, Costo = @costo, IdContrato = @idContrato
            WHERE IdArreglo = @idArreglo
        END
        ELSE
        BEGIN
            SET @Resultado = 0
            SET @Mensaje = 'El arreglo especificado no existe.'
        END
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARCONTRATO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARCONTRATO](
    @idContrato INT,
    @fechaInicio DATETIME,
    @fechaFin DATETIME,	
    @montoContrato DECIMAL(18,2),
    @idInquilino INT,	
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT	
)
AS
BEGIN 
    SET @Resultado = 0
    SET @Mensaje = ''  -- Asegura que el mensaje no tenga valores previos

    -- Verificar si el inquilino ya tiene otro contrato distinto al actual
    IF EXISTS (SELECT 1 FROM Contrato WHERE IdInquilino = @idInquilino AND IdContrato != @idContrato)
    BEGIN
        SET @Mensaje = 'No puede existir un inquilino con más de un contrato registrado'
        RETURN
    END

    -- Actualizar contrato
    UPDATE Contrato 
    SET FechaInicio = @fechaInicio, 
        FechaFin = @fechaFin, 
        Monto = @montoContrato, 
        IdInquilino = @idInquilino
    WHERE IdContrato = @idContrato

    -- Confirmar éxito de la operación
    SET @Resultado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARGARANTE]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARGARANTE](

@idGarante int,
@nombreGarante varchar(50),
@apellidoGarante varchar(50),	/*parametros de entrada*/
@telefonoGarante varchar(50),
@mailGarante varchar(50),
@direccionGarante varchar(50),																/*EN VEZ DE ID BUSCAR INQUILINO POR APELLIDO NO SERIA MEJOR??????*/
@idInquilino int,
@Resultado bit output,
@Mensaje varchar(500) output	/*parametros de resultado de operacion*/

)
as
begin 
	set @Resultado = 1

	if not exists(select * from Garante where Mail = @mailGarante and IdGarante != @idGarante)
		update Garante set Nombre = @nombreGarante, Apellido = @apellidoGarante, 
		Telefono = @telefonoGarante, Mail = @mailGarante, Direccion = @direccionGarante, IdInquilino = @idInquilino
		where IdGarante = @idGarante
	ELSE
	begin
		set @Resultado = 0
		set @Mensaje = 'No se puede repetir el mail de un garante'
	end

end

GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARINQUILINO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_EDITARINQUILINO](

@idInquilino int,
@nombreInquilino varchar(50),
@apellidoInquilino varchar(50),	/*parametros de entrada*/
@telefonoInquilino varchar(50),
@dniInquilino varchar(50),
@Respuesta bit output, /*la respuesta sera 1 o 0*/
@Mensaje varchar(500) output	/*parametros de resultado de operacion*/

)
as
begin 
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists(select * from Inquilino where DNI = @dniInquilino and IdInquilino != @idInquilino)
	begin
		update inquilino set Nombre = @nombreInquilino, Apellido = @apellidoInquilino, Telefono = @telefonoInquilino, DNI = @dniInquilino
		where IdInquilino = @idInquilino

		set @Respuesta = 1

	end 
	else 
		set @Mensaje = 'No se puede repetir el DNI para mas de un inquilino'


end
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARSERVICIO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARSERVICIO] (
    @idServicio INT,
    @tipo VARCHAR(50),    
    @costo DECIMAL(18, 2),
    @idContrato INT,    
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    -- Verificar si el mismo tipo de servicio ya existe en el mismo contrato, excluyendo el servicio que se está editando
    IF EXISTS (
        SELECT 1 FROM Servicio 
        WHERE IdContrato = @idContrato 
        AND Tipo = @tipo 
        AND IdServicio <> @idServicio
    )
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'No puede existir un contrato con el mismo tipo de servicio registrado.'
    END
    ELSE
    BEGIN
        -- Verificar si el servicio a editar realmente existe
        IF EXISTS (SELECT 1 FROM Servicio WHERE IdServicio = @idServicio)
        BEGIN
            UPDATE Servicio 
            SET Tipo = @tipo, Costo = @costo, IdContrato = @idContrato
            WHERE IdServicio = @idServicio
        END
        ELSE
        BEGIN
            SET @Resultado = 0
            SET @Mensaje = 'El servicio especificado no existe.'
        END
    END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARARREGLO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SP_ELIMINARARREGLO](
    @idArreglo INT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    -- Intentar eliminar el arreglo
    DELETE FROM Arreglo WHERE IdArreglo = @idArreglo

    -- Verificar si se eliminó correctamente
    IF @@ROWCOUNT = 0
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'El arreglo no existe o ya fue eliminado'
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARCONTRATO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARCONTRATO](
    @idContrato INT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN 
    SET @Resultado = 0
    SET @Mensaje = ''  -- Asegura que el mensaje no tenga valores previos

    -- Verificar si el contrato existe antes de eliminar
    IF NOT EXISTS (SELECT 1 FROM Contrato WHERE IdContrato = @idContrato)
    BEGIN
        SET @Mensaje = 'El contrato no existe'
        RETURN
    END

    -- Eliminar el contrato
    DELETE FROM Contrato WHERE IdContrato = @idContrato

    -- Confirmar éxito de la operación
    SET @Resultado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARGARANTE]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARGARANTE](

@idGarante int,
@Resultado bit output,
@Mensaje varchar(500) output	/*parametros de resultado de operacion*/

)
AS
BEGIN 
    SET @Resultado = 0
    SET @Mensaje = '' 

    -- Verificar si el contrato existe antes de eliminar
    IF NOT EXISTS (SELECT 1 FROM Garante WHERE IdGarante = @idGarante)
    BEGIN
        SET @Mensaje = 'El garante no existe'
        RETURN
    END

    -- Eliminar el contrato
    DELETE FROM Garante WHERE IdGarante = @idGarante

    -- Confirmar éxito de la operación
    SET @Resultado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARINQUILINO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_ELIMINARINQUILINO](

@idInquilino int,  /*omitimos parametros de entrada porque solo necesitamos id para eliminar*/
@Respuesta bit output, /*la respuesta sera 1 o 0*/
@Mensaje varchar(500) output	/*parametros de resultado de operacion*/

)
as
begin 
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	/*VALIDACIONES ANTES DE ELIMINAR*/

	/*seleccion de todo contrato relacionado con el inquilino */
	if exists (select * from  Contrato C
	INNER JOIN Inquilino I ON I.IdInquilino = C.IdInquilino
	WHERE I.IdInquilino = @idInquilino
	) 
	begin 
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar al inquilino, debe eliminar su contrato\n'

	end


	/*seleccion de todo garante relacionado con el inquilino */
	if exists (select * from  Garante G
	INNER JOIN Inquilino I ON I.IdInquilino = G.IdInquilino
	WHERE I.IdInquilino = @idInquilino
	) 
	begin 
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = 'No se puede eliminar al inquilino, debe eliminar a sus garantes'

	end


	/*VALIDACION FINAL*/

	if(@pasoreglas = 1) 
	begin 
	delete from Inquilino where IdInquilino = @idInquilino
	set @Respuesta = 1	 /*eliminacion de inquilino fue correcta*/
	end

	


end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARSERVICIO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARSERVICIO](
    @idServicio INT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    -- Intentar eliminar el servicio
    DELETE FROM Servicio WHERE IdServicio = @idServicio

    -- Verificar si se eliminó correctamente
    IF @@ROWCOUNT = 0
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'El servicio no existe o ya fue eliminado'
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARARREGLO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_REGISTRARARREGLO] 
(
    @tipo VARCHAR(50),
    @costo DECIMAL(18,2),
    @idContrato INT,  
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;

    IF NOT EXISTS (SELECT * FROM Arreglo WHERE TipoArreglo = @tipo AND IdContrato = @idContrato)
    BEGIN
        INSERT INTO Arreglo (TipoArreglo, Costo, IdContrato)
        VALUES (@tipo, @costo, @idContrato);

        SET @Resultado = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se puede repetir un arreglo ya registrado para cierto contrato.';
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARCONTRATO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARCONTRATO](
    @fechaInicio DATETIME,
    @fechaFin DATETIME,	
    @montoContrato DECIMAL(18,2),
    @idInquilino INT,		
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT	
)
AS
BEGIN 
    SET @Resultado = 0
    SET @Mensaje = ''  -- Asegura que el mensaje no tenga valores previos

    -- Verificar si el inquilino ya tiene un contrato
    IF EXISTS (SELECT 1 FROM Contrato WHERE IdInquilino = @idInquilino)
    BEGIN
        SET @Mensaje = 'No puede existir un inquilino con más de un contrato registrado'
        RETURN
    END

    -- Insertar nuevo contrato
    INSERT INTO Contrato(FechaInicio, FechaFin, Monto, IdInquilino)
    VALUES (@fechaInicio, @fechaFin, @montoContrato, @idInquilino)

    -- Obtener el ID del contrato recién insertado
    SET @Resultado = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARGARANTE]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARGARANTE](

@nombreGarante varchar(50),
@apellidoGarante varchar(50),	/*parametros de entrada*/
@telefonoGarante varchar(50),
@mailGarante varchar(50),
@direccionGarante varchar(50),
@idInquilino int,																					/*en caso de querer modificar un proced --> alter*/
@Resultado int output,
@Mensaje varchar(500) output	/*parametros de resultado de operacion*/

)
as
begin 
	set @Resultado = 0

	if not exists(select * from Garante where Mail = @mailGarante)
	begin
		insert into Garante(Nombre, Apellido, Telefono, Mail, Direccion, IdInquilino)
		values (@nombreGarante, @apellidoGarante, @telefonoGarante, @mailGarante, @direccionGarante, @idInquilino)

		set @Resultado = SCOPE_IDENTITY()

	end 
	else 
		set @Mensaje = 'No se puede repetir el mail para mas de un garante'


end

GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARINQUILINO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARINQUILINO](

@nombreInquilino varchar(50),
@apellidoInquilino varchar(50),	/*parametros de entrada*/
@telefonoInquilino varchar(50),
@dniInquilino varchar(50),
@idInquilinoResultado int output,
@Mensaje varchar(500) output	/*parametros de resultado de operacion*/

)
as
begin 
	set @idInquilinoResultado = 0
	set @Mensaje = ''

	if not exists(select * from Inquilino where DNI = @dniInquilino)
	begin
		insert into inquilino(Nombre, Apellido, Telefono, DNI)
		values (@nombreInquilino, @apellidoInquilino, @telefonoInquilino, @dniInquilino)

		set @idInquilinoResultado = SCOPE_IDENTITY()

	end 
	else 
		set @Mensaje = 'No se puede repetir el DNI para mas de un inquilino'


end
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARSERVICIO]    Script Date: 7/3/2025 19:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARSERVICIO](
    @tipo VARCHAR(50),
    @costo DECIMAL(18,2),
    @idContrato INT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    -- Verificar si ya existe un servicio con el mismo tipo para el mismo contrato
    IF EXISTS (
        SELECT * FROM Servicio 
        WHERE Tipo = @tipo AND IdContrato = @idContrato
    )
    BEGIN
        SET @Mensaje = 'No se puede repetir un servicio ya registrado para cierto contrato/inquilino'
    END
    ELSE
    BEGIN
        -- Insertar nuevo servicio si no hay duplicados
        INSERT INTO Servicio (Tipo, Costo, IdContrato)
        VALUES (@tipo, @costo, @idContrato)

        -- Retornar el ID generado
        SET @Resultado = SCOPE_IDENTITY()
    END
END
GO
