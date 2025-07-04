USE [ISProyecto]
GO
/****** Object:  UserDefinedTableType [dbo].[ComandaProductoType]    Script Date: 21/11/2024 13:51:04 ******/
CREATE TYPE [dbo].[ComandaProductoType] AS TABLE(
	[comanda_id] [int] NULL,
	[producto_id] [int] NULL,
	[estado_producto] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [decimal](10, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ProductoFacturaType]    Script Date: 21/11/2024 13:51:04 ******/
CREATE TYPE [dbo].[ProductoFacturaType] AS TABLE(
	[ProductoId] [int] NULL,
	[NombreProducto] [nvarchar](100) NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [decimal](18, 2) NULL
)
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Email] [varchar](150) NULL,
	[Telefono] [varchar](15) NULL,
	[Direccion] [varchar](250) NULL,
	[NumeroTarjetaUltimos4] [varchar](4) NULL,
	[TipoTarjeta] [varchar](20) NULL,
	[FechaExpiracion] [date] NULL,
	[BancoEmisor] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comanda]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comanda](
	[comanda_id] [int] IDENTITY(1,1) NOT NULL,
	[mesa_id] [int] NULL,
	[fecha_hora_creacion] [datetime] NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[comanda_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comandaProducto]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comandaProducto](
	[comanda_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[estado_producto] [int] NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[subtotal]  AS ([cantidad]*[precio_unitario]),
	[comanda_producto_id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[comanda_producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[etiqueta]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[etiqueta](
	[nombre] [varchar](50) NULL,
	[etiqueta_id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[etiqueta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[FacturaId] [int] IDENTITY(1,1) NOT NULL,
	[NumeroFactura] [varchar](50) NOT NULL,
	[FechaEmision] [datetime] NOT NULL,
	[MesaId] [int] NOT NULL,
	[ComandaId] [int] NOT NULL,
	[ClienteId] [int] NULL,
	[SubtotalGeneral] [decimal](18, 2) NOT NULL,
	[DescuentoTotal] [decimal](18, 2) NOT NULL,
	[ImpuestoTotal] [decimal](18, 2) NOT NULL,
	[Propina] [decimal](18, 2) NOT NULL,
	[TotalFinal] [decimal](18, 2) NOT NULL,
	[EstadoPago] [int] NOT NULL,
	[MontoPagado] [decimal](18, 2) NOT NULL,
	[Cambio] [decimal](18, 2) NOT NULL,
	[Notas] [text] NULL,
	[FechaCierre] [datetime] NOT NULL,
	[DivisionPago] [bit] NOT NULL,
	[MetodoPagoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[idioma]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[idioma](
	[idioma_id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[habilitado] [tinyint] NULL,
 CONSTRAINT [PK_idioma] PRIMARY KEY CLUSTERED 
(
	[idioma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediosDePago]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediosDePago](
	[MedioDePagoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MedioDePagoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mesa]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mesa](
	[mesa_id] [int] NOT NULL,
	[capacidadMaxima] [int] NOT NULL,
	[estado_mesa] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mesa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notificaciones]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notificaciones](
	[notificacion_id] [int] IDENTITY(1,1) NOT NULL,
	[comanda_id] [int] NOT NULL,
	[mesa_id] [int] NOT NULL,
	[visto] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[notificacion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[nombre] [varchar](100) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permiso] [varchar](50) NULL,
	[es_rol] [bit] NULL,
	[habilitado] [bit] NULL,
 CONSTRAINT [PK_permiso_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[producto_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NOT NULL,
	[descripcion] [nvarchar](500) NULL,
	[precio] [decimal](18, 2) NOT NULL,
	[tiempo_preparacion] [int] NULL,
	[disponible] [bit] NOT NULL,
	[es_postre] [bit] NOT NULL,
	[categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[producto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoFactura]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoFactura](
	[ProductoFacturaId] [int] IDENTITY(1,1) NOT NULL,
	[FacturaId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[NombreProducto] [nvarchar](100) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductoFacturaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[traduccion]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[traduccion](
	[idioma_id] [int] NOT NULL,
	[etiqueta_id] [int] NOT NULL,
	[texto] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[PasswordHash] [varchar](256) NULL,
	[FechaCreacion] [date] NULL,
	[idioma_id] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL,
 CONSTRAINT [PK_usuarios_permisos] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[comandaProducto] ADD  DEFAULT ((0)) FOR [estado_producto]
GO
ALTER TABLE [dbo].[idioma] ADD  DEFAULT ((1)) FOR [habilitado]
GO
ALTER TABLE [dbo].[MediosDePago] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[notificaciones] ADD  DEFAULT ((0)) FOR [visto]
GO
ALTER TABLE [dbo].[permiso] ADD  DEFAULT ((0)) FOR [es_rol]
GO
ALTER TABLE [dbo].[permiso] ADD  DEFAULT ((1)) FOR [habilitado]
GO
ALTER TABLE [dbo].[traduccion] ADD  DEFAULT (NULL) FOR [texto]
GO
ALTER TABLE [dbo].[comandaProducto]  WITH CHECK ADD  CONSTRAINT [FK_comanda_producto_producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[producto] ([producto_id])
GO
ALTER TABLE [dbo].[comandaProducto] CHECK CONSTRAINT [FK_comanda_producto_producto]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[cliente] ([ClienteId])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Comanda] FOREIGN KEY([ComandaId])
REFERENCES [dbo].[comanda] ([comanda_id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_Factura_Comanda]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_MediosDePago] FOREIGN KEY([MetodoPagoId])
REFERENCES [dbo].[MediosDePago] ([MedioDePagoId])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_MediosDePago]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Mesa] FOREIGN KEY([MesaId])
REFERENCES [dbo].[mesa] ([mesa_id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_Factura_Mesa]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_permiso_permiso] FOREIGN KEY([id_permiso_padre])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_permiso_permiso_permiso]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_permiso_permiso1] FOREIGN KEY([id_permiso_hijo])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_permiso_permiso_permiso1]
GO
ALTER TABLE [dbo].[ProductoFactura]  WITH CHECK ADD  CONSTRAINT [FK_ProductoFactura_Factura] FOREIGN KEY([FacturaId])
REFERENCES [dbo].[factura] ([FacturaId])
GO
ALTER TABLE [dbo].[ProductoFactura] CHECK CONSTRAINT [FK_ProductoFactura_Factura]
GO
ALTER TABLE [dbo].[ProductoFactura]  WITH CHECK ADD  CONSTRAINT [FK_ProductoFactura_Producto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[producto] ([producto_id])
GO
ALTER TABLE [dbo].[ProductoFactura] CHECK CONSTRAINT [FK_ProductoFactura_Producto]
GO
ALTER TABLE [dbo].[traduccion]  WITH CHECK ADD  CONSTRAINT [FK_traduccion_etiqueta] FOREIGN KEY([etiqueta_id])
REFERENCES [dbo].[etiqueta] ([etiqueta_id])
GO
ALTER TABLE [dbo].[traduccion] CHECK CONSTRAINT [FK_traduccion_etiqueta]
GO
ALTER TABLE [dbo].[traduccion]  WITH CHECK ADD  CONSTRAINT [fk_traduccion_idioma] FOREIGN KEY([idioma_id])
REFERENCES [dbo].[idioma] ([idioma_id])
GO
ALTER TABLE [dbo].[traduccion] CHECK CONSTRAINT [fk_traduccion_idioma]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [fk_usuario_idioma] FOREIGN KEY([idioma_id])
REFERENCES [dbo].[idioma] ([idioma_id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [fk_usuario_idioma]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_permiso]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_usuarios]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstadoComandaProducto]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarEstadoComandaProducto]
    @ComandaProductos ComandaProductoType READONLY,
    @NuevoEstado INT
AS
BEGIN
    UPDATE cp
    SET cp.estado_producto = @NuevoEstado
    FROM comandaProducto cp
    INNER JOIN @ComandaProductos cpInput
        ON cp.comanda_id = cpInput.comanda_id
        AND cp.producto_id = cpInput.producto_id
    WHERE cp.estado_producto != @NuevoEstado; 
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarEtiqueta]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AgregarEtiqueta]
    @Nombre NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar la nueva etiqueta en la tabla etiqueta
    INSERT INTO [dbo].[etiqueta] (nombre)
    VALUES (@Nombre);

    -- Devolver el ID de la etiqueta insertada
    SELECT SCOPE_IDENTITY() AS etiqueta_id;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarPermiso]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarPermiso]
    @nombre NVARCHAR(100),
    @descripcion NVARCHAR(255),
    @habilitado BIT,
    @es_rol BIT,
    @id_permiso_padre INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar el nuevo permiso
        DECLARE @nuevo_permiso_id INT;

        INSERT INTO [dbo].[permiso] ([nombre], [permiso], [habilitado], [es_rol])
        VALUES (@nombre, @descripcion, @habilitado, @es_rol);

        -- Obtener el ID del nuevo permiso
        SET @nuevo_permiso_id = SCOPE_IDENTITY();

        -- Si se especifica un permiso padre, insertar en permiso_permiso
        IF @id_permiso_padre IS NOT NULL
        BEGIN
            INSERT INTO [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo])
            VALUES (@id_permiso_padre, @nuevo_permiso_id);
        END

        COMMIT TRANSACTION;
        PRINT 'Permiso agregado correctamente con ID: ' + CAST(@nuevo_permiso_id AS NVARCHAR);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al agregar el permiso: ' + ERROR_MESSAGE();
    END CATCH
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarProducto]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarProducto]
    @Nombre NVARCHAR(255),
    @Descripcion NVARCHAR(500),
    @Precio DECIMAL(18, 2),
    @Categoria INT, 
    @TiempoPreparacion INT,
    @Disponible BIT,
    @EsPostre BIT
AS
BEGIN
    INSERT INTO producto (nombre, descripcion, precio, categoria, tiempo_preparacion, disponible, es_postre)
    VALUES (@Nombre, @Descripcion, @Precio, @Categoria, @TiempoPreparacion, @Disponible, @EsPostre);

    SELECT SCOPE_IDENTITY() AS ProductoId;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AsignarMesa]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AsignarMesa]
    @mesa_id INT,
	@numero_estado_asignado int
AS
BEGIN
    IF EXISTS (SELECT 1 FROM [ISProyecto].[dbo].[mesa]
               WHERE mesa_id = @mesa_id AND estado_mesa = @numero_estado_asignado)
    BEGIN
        RETURN 1 -- Retornar 1 si la mesa ya está reservada
    END

    UPDATE [ISProyecto].[dbo].[mesa]
    SET estado_mesa = @numero_estado_asignado       
    WHERE mesa_id = @mesa_id;

    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AsignarPermiso]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AsignarPermiso]
    @usuario_id INT,
    @permiso_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @es_rol BIT;

    SELECT @es_rol = es_rol 
    FROM [dbo].[permiso] 
    WHERE [id] = @permiso_id;

    IF EXISTS (SELECT 1 FROM [dbo].[permiso] WHERE [id] = @permiso_id AND [habilitado] = 1)
    BEGIN
        IF @es_rol = 1
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
            BEGIN
                INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
                VALUES (@usuario_id, @permiso_id);
            END

            ;WITH PermisosRecursivos AS (
                SELECT pp.id_permiso_hijo AS id
                FROM [dbo].[permiso_permiso] pp
                WHERE pp.id_permiso_padre = @permiso_id

                UNION ALL

                SELECT pp.id_permiso_hijo
                FROM [dbo].[permiso_permiso] pp
                INNER JOIN PermisosRecursivos pr ON pp.id_permiso_padre = pr.id
            )
            INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
            SELECT @usuario_id, pr.id
            FROM PermisosRecursivos pr
            WHERE NOT EXISTS (
                SELECT 1 FROM [dbo].[usuarios_permisos]
                WHERE id_usuario = @usuario_id AND id_permiso = pr.id
            );

            PRINT 'Permiso de rol y permisos hijos asignados correctamente.';
        END
        ELSE
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
            BEGIN
                INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
                VALUES (@usuario_id, @permiso_id);

                PRINT 'Permiso asignado correctamente.';
            END
            ELSE
            BEGIN
                PRINT 'El permiso ya está asignado a este usuario.';
            END
        END
    END
    ELSE
    BEGIN
        PRINT 'El permiso especificado no está habilitado y no se puede asignar.';
    END

    SELECT id_usuario, id_permiso FROM [dbo].[usuarios_permisos]
    WHERE [id_usuario] = @usuario_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_AsignarPermisoPorCod]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AsignarPermisoPorCod]
    @usuario_nombre NVARCHAR(50), 
    @cod_permiso NVARCHAR(50)  
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @es_rol BIT;
    DECLARE @permiso_id INT;
    DECLARE @usuario_id INT;

    SELECT @permiso_id = id
    FROM [dbo].[permiso] 
    WHERE [permiso] = @cod_permiso;

    IF @permiso_id IS NULL
    BEGIN
        PRINT 'El permiso especificado no existe.';
        RETURN;
    END

    SELECT @usuario_id = id_usuario
    FROM [dbo].[usuarios] 
    WHERE [username] = @usuario_nombre;
    IF @usuario_id IS NULL
    BEGIN
        PRINT 'El usuario especificado no existe.';
        RETURN;
    END

    SELECT @es_rol = es_rol 
    FROM [dbo].[permiso] 
    WHERE [id] = @permiso_id;

    IF EXISTS (SELECT 1 FROM [dbo].[permiso] WHERE [id] = @permiso_id AND [habilitado] = 1)
    BEGIN
        IF @es_rol = 1
        BEGIN

            IF NOT EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
            BEGIN
                INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
                VALUES (@usuario_id, @permiso_id);
            END

            ;WITH PermisosRecursivos AS (
                SELECT pp.id_permiso_hijo AS id
                FROM [dbo].[permiso_permiso] pp
                WHERE pp.id_permiso_padre = @permiso_id

                UNION ALL

                SELECT pp.id_permiso_hijo
                FROM [dbo].[permiso_permiso] pp
                INNER JOIN PermisosRecursivos pr ON pp.id_permiso_padre = pr.id
            )
            INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
            SELECT @usuario_id, pr.id
            FROM PermisosRecursivos pr
            WHERE NOT EXISTS (
                SELECT 1 FROM [dbo].[usuarios_permisos]
                WHERE id_usuario = @usuario_id AND id_permiso = pr.id
            );

            PRINT 'Permiso de rol y permisos hijos asignados correctamente.';
        END
        ELSE
        BEGIN
           
            IF NOT EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
            BEGIN
                INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
                VALUES (@usuario_id, @permiso_id);

                PRINT 'Permiso asignado correctamente.';
            END
            ELSE
            BEGIN
                PRINT 'El permiso ya está asignado a este usuario.';
            END
        END
    END
    ELSE
    BEGIN
        PRINT 'El permiso especificado no está habilitado y no se puede asignar.';
    END

    SELECT id_usuario, id_permiso FROM [dbo].[usuarios_permisos]
    WHERE [id_usuario] = @usuario_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_AsignarTraduccion]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AsignarTraduccion]
    @idiomaId INT,
    @etiqueta_id INT,
    @texto NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verifica si ya existe una traducción para el idioma y etiqueta especificados
    IF EXISTS (
        SELECT 1
        FROM [ISProyecto].[dbo].[traduccion]
        WHERE idioma_id = @idiomaId AND etiqueta_id = @etiqueta_id
    )
    BEGIN
        -- Si existe, actualiza el texto de la traducción
        UPDATE [ISProyecto].[dbo].[traduccion]
        SET texto = @texto
        WHERE idioma_id = @idiomaId AND etiqueta_id = @etiqueta_id;
    END
    ELSE
    BEGIN
        -- Si no existe, inserta una nueva traducción
        INSERT INTO [ISProyecto].[dbo].[traduccion] (idioma_id, etiqueta_id, texto)
        VALUES (@idiomaId, @etiqueta_id, @texto);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CambiarEstadoComandaCerrada]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CambiarEstadoComandaCerrada]
    @comanda_id INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM comanda WHERE comanda_id = @comanda_id)
    BEGIN
        UPDATE comanda
        SET estado = 1
        WHERE comanda_id = @comanda_id;
    END
    ELSE
    BEGIN
        PRINT 'La comanda con el ID especificado no existe.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CambiarEstadoFactura]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CambiarEstadoFactura]
    @FacturaId INT,
    @NuevoEstado INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.factura
    SET EstadoPago = @NuevoEstado
    WHERE FacturaId = @FacturaId;

    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('No se encontró ninguna factura con el id especificado.', 16, 1);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CambiarEstadoMesa]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CambiarEstadoMesa]
    @MesaId INT,
    @EstadoMesa INT
AS
BEGIN
  
    UPDATE [dbo].[mesa]
    SET [estado_mesa] = @EstadoMesa
    WHERE [mesa_id] = @MesaId;

    IF @@ROWCOUNT = 0
    BEGIN
        PRINT 'No se encontró la mesa con el ID proporcionado';
    END
    ELSE
    BEGIN
        PRINT 'Estado de la mesa actualizado';
    END
END

GO
/****** Object:  StoredProcedure [dbo].[sp_CambiarEstadoMesaCerrada]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CambiarEstadoMesaCerrada]
    @mesa_id INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM mesa WHERE mesa_id = @mesa_id)
    BEGIN
        UPDATE mesa
        SET estado_mesa = 2
        WHERE mesa_id = @mesa_id;
    END
    ELSE
    BEGIN
        PRINT 'La mesa con el ID especificado no existe.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_DesasignarPermiso]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DesasignarPermiso]
    @usuario_id INT,
    @permiso_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @es_rol BIT;

    -- Verifica si el permiso es un rol
    SELECT @es_rol = es_rol 
    FROM [dbo].[permiso] 
    WHERE [id] = @permiso_id;

    -- Verifica si el permiso está asignado al usuario
    IF EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
    BEGIN
        -- Si es un rol, desasigna el permiso y todos sus permisos hijos
        IF @es_rol = 1
        BEGIN
            -- Primero, desasignamos todos los permisos hijos
            ;WITH PermisosRecursivos AS (
                SELECT pp.id_permiso_hijo AS id
                FROM [dbo].[permiso_permiso] pp
                WHERE pp.id_permiso_padre = @permiso_id

                UNION ALL

                SELECT pp.id_permiso_hijo
                FROM [dbo].[permiso_permiso] pp
                INNER JOIN PermisosRecursivos pr ON pp.id_permiso_padre = pr.id
            )
            DELETE FROM [dbo].[usuarios_permisos]
            WHERE id_usuario = @usuario_id AND id_permiso IN (
                SELECT id FROM PermisosRecursivos
            );

            -- Luego, desasignamos el permiso de rol principal
            DELETE FROM [dbo].[usuarios_permisos]
            WHERE id_usuario = @usuario_id AND id_permiso = @permiso_id;

            PRINT 'Permiso de rol y permisos hijos desasignados correctamente.';
        END
        ELSE
        BEGIN
            -- Si no es un rol, solo desasignamos el permiso
            DELETE FROM [dbo].[usuarios_permisos]
            WHERE id_usuario = @usuario_id AND id_permiso = @permiso_id;

            PRINT 'Permiso desasignado correctamente.';
        END
    END
    ELSE
    BEGIN
        PRINT 'El permiso especificado no está asignado a este usuario.';
    END

    -- Retorna la tabla usuarios_permisos
    SELECT id_usuario, id_permiso FROM [dbo].[usuarios_permisos]
    WHERE [id_usuario] = @usuario_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarMesa]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarMesa]
	@mesa_id INT
AS
BEGIN
	DELETE
		mesa
	WHERE
		mesa_id = @mesa_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarPermiso]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarPermiso]
    @permiso_id INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Eliminar relaciones en usuarios_permisos
        DELETE FROM [dbo].[usuarios_permisos]
        WHERE [id_permiso] = @permiso_id;

        -- Eliminar relaciones en permiso_permiso (si hay permisos hijos)
        DELETE FROM [dbo].[permiso_permiso]
        WHERE [id_permiso_padre] = @permiso_id OR [id_permiso_hijo] = @permiso_id;

        -- Eliminar el permiso
        DELETE FROM [dbo].[permiso]
        WHERE [id] = @permiso_id;

        COMMIT TRANSACTION;
        PRINT 'Permiso eliminado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el permiso: ' + ERROR_MESSAGE();
    END CATCH
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarUsuario]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarUsuario]
    @usuario_id INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verifica si el usuario existe
    IF EXISTS (SELECT 1 FROM [dbo].[usuarios] WHERE [id_usuario] = @usuario_id)
    BEGIN
        -- Elimina las relaciones en usuarios_permisos
        DELETE FROM [dbo].[usuarios_permisos]
        WHERE [id_usuario] = @usuario_id;

        -- Elimina el usuario
        DELETE FROM [dbo].[usuarios]
        WHERE [id_usuario] = @usuario_id;

        PRINT 'Usuario eliminado correctamente.';
    END
    ELSE
    BEGIN
        PRINT 'El usuario especificado no existe.';
    END
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarFactura]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GuardarFactura]
    @NumeroFactura NVARCHAR(50),
    @FechaEmision DATETIME,
    @MesaId INT,
    @ClienteId INT,
    @ComandaId INT,
    @SubtotalGeneral DECIMAL(18,2),
    @DescuentoTotal DECIMAL(18,2),
    @ImpuestoTotal DECIMAL(18,2),
    @Propina DECIMAL(18,2),
    @TotalFinal DECIMAL(18,2),
    @MetodoPagoId INT, 
    @EstadoPago INT,
    @MontoPagado DECIMAL(18,2),
    @Cambio DECIMAL(18,2),
    @Notas NVARCHAR(255),
    @DivisionPago BIT
AS
BEGIN
    INSERT INTO factura
    (
        [NumeroFactura],
        [FechaEmision],
        [MesaId],
        [ClienteId],
        [ComandaId],  
        [SubtotalGeneral],
        [DescuentoTotal],
        [ImpuestoTotal],
        [Propina],
        [TotalFinal],
        [MetodoPagoId],
        [EstadoPago],
        [MontoPagado],
        [Cambio],
        [Notas],
        [FechaCierre],
        [DivisionPago]
    )
    VALUES
    (
        @NumeroFactura,
        @FechaEmision,
        @MesaId,
        @ClienteId,   
        @ComandaId,   
        @SubtotalGeneral,
        @DescuentoTotal,
        @ImpuestoTotal,
        @Propina,
        @TotalFinal,
        @MetodoPagoId,
        @EstadoPago,
        @MontoPagado,
        @Cambio,
        @Notas,
        GETDATE(), 
        @DivisionPago
    );
    
    SELECT SCOPE_IDENTITY() AS FacturaId;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarMesa]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GuardarMesa]
    @mesa_id INT,
    @capacidadMaxima INT,
    @estado_mesa INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM mesa WHERE mesa_id = @mesa_id)
    BEGIN
        UPDATE mesa
        SET capacidadMaxima = @capacidadMaxima,
            estado_mesa = @estado_mesa
        WHERE mesa_id = @mesa_id;
        
        SELECT 'Registro actualizado correctamente' AS Mensaje;
    END
    ELSE
    BEGIN
        INSERT INTO mesa (mesa_id, capacidadMaxima, estado_mesa)
        VALUES (@mesa_id, @capacidadMaxima, @estado_mesa);
        
        SELECT 'Registro insertado correctamente' AS Mensaje;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarProductosFactura]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GuardarProductosFactura]
    @FacturaId INT,
    @ProductoFactura dbo.ProductoFacturaType READONLY
AS
BEGIN
    INSERT INTO ProductoFactura
    (
        FacturaId,
        ProductoId,
        NombreProducto,
        Cantidad,
        PrecioUnitario
    )
    SELECT 
        @FacturaId, 
        ProductoId,
        NombreProducto,
        Cantidad,
        PrecioUnitario
    FROM @ProductoFactura; 

END;

GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarUsuario]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GuardarUsuario]
    @IdUsuario INT,
    @Username NVARCHAR(50),
    @PasswordHash NVARCHAR(255),
    @FechaCreacion DATETIME,
    @idioma_id INT  -- Nuevo parámetro agregado
AS
BEGIN
    INSERT INTO usuarios (id_usuario, Username, PasswordHash, FechaCreacion, idioma_id)  -- Incluye idioma_id en la inserción
    VALUES (@IdUsuario, @Username, @PasswordHash, @FechaCreacion, @idioma_id);
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarCliente]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarCliente]
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Direccion NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO cliente (Nombre, Apellido, Email, Telefono, Direccion)
    VALUES (@Nombre, @Apellido, @Email, @Telefono, @Direccion);

    SELECT SCOPE_IDENTITY() AS ClienteId;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarClienteConDatosBancarios]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_InsertarClienteConDatosBancarios]
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Direccion NVARCHAR(200),
    @NumeroTarjetaUltimos4 VARCHAR(4) = NULL,   
    @TipoTarjeta VARCHAR(20) = NULL,            
    @FechaExpiracion DATE = NULL,               
    @BancoEmisor VARCHAR(100) = NULL            
AS
BEGIN
    SET NOCOUNT ON;

    
    INSERT INTO cliente (Nombre, Apellido, Email, Telefono, Direccion, 
                         NumeroTarjetaUltimos4, TipoTarjeta, FechaExpiracion, BancoEmisor)
    VALUES (@Nombre, @Apellido, @Email, @Telefono, @Direccion, 
            @NumeroTarjetaUltimos4, @TipoTarjeta, @FechaExpiracion, @BancoEmisor);

    SELECT SCOPE_IDENTITY() AS ClienteId;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarComanda]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarComanda]
    @mesa_id INT,
    @fecha_hora_creacion DATETIME
AS
BEGIN
    DECLARE @comanda_id INT;
    INSERT INTO [ISProyecto].[dbo].[comanda] (mesa_id, fecha_hora_creacion, estado)
    VALUES (@mesa_id, @fecha_hora_creacion, 0);  

    SET @comanda_id = SCOPE_IDENTITY();  

    SELECT @comanda_id AS comanda_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarComandaProductos]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarComandaProductos]
    @ComandaProductos ComandaProductoType READONLY
AS
BEGIN
    INSERT INTO comandaProducto (comanda_id, producto_id, estado_producto, cantidad, precio_unitario)
    SELECT 
        comanda_id, 
        producto_id, 
        estado_producto, 
        cantidad, 
        precio_unitario
    FROM @ComandaProductos;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarEtiqueta]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarEtiqueta]
    @EtiquetaId INT,
    @Nombre NVARCHAR(255)
AS
BEGIN
     SET NOCOUNT ON;

    -- Verificar si el nombre de la etiqueta ya existe
    IF NOT EXISTS (SELECT 1 FROM etiqueta WHERE etiqueta_id = @EtiquetaId)
    BEGIN
        SET IDENTITY_INSERT etiqueta ON;

        INSERT INTO etiqueta (etiqueta_id, nombre)
        VALUES (@EtiquetaId, @nombre);

        SET IDENTITY_INSERT etiqueta OFF;
    END
    ELSE
    BEGIN
        PRINT 'El nombre de la etiqueta ya existe.';
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarNotificacion]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarNotificacion]
    @comanda_id INT,
    @mesa_id INT
AS
BEGIN
    INSERT INTO notificaciones (comanda_id, mesa_id, visto)
    VALUES (@comanda_id, @mesa_id, 0);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_MarcarComandaProductosComoEntregados]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MarcarComandaProductosComoEntregados]
    @notificacion_id INT
AS
BEGIN
    UPDATE comandaProducto
    SET estado_producto = 4
    WHERE estado_producto = 3
      AND comanda_id = (SELECT comanda_id FROM notificaciones WHERE notificacion_id = @notificacion_id);

    UPDATE notificaciones
    SET visto = 1
    WHERE notificacion_id = @notificacion_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarMesa]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarMesa]
    @mesa_id INT,
    @capacidadMaxima INT,
    @estado_mesa INT
AS
BEGIN
    -- Comprobamos si existe la mesa que se desea modificar
    IF EXISTS (SELECT 1 FROM mesa WHERE mesa_id = @mesa_id)
    BEGIN
        -- Realizamos la actualización de la mesa
        UPDATE mesa
        SET
            mesa_id = @mesa_id,
            capacidadMaxima = @capacidadMaxima,
            estado_mesa = @estado_mesa
        WHERE
            mesa_id = @mesa_id;

        PRINT 'Mesa actualizada correctamente.';
    END
    ELSE
    BEGIN
        PRINT 'La mesa especificada no existe.';
    END
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerComandaProductoPorComandaId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerComandaProductoPorComandaId]
    @comanda_id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        cp.comanda_producto_id,
        cp.comanda_id,
        cp.producto_id,
        p.nombre,
        p.descripcion,
        p.categoria,
        cp.estado_producto,
        cp.cantidad,
        cp.precio_unitario,
        cp.subtotal
    FROM [ISProyecto].[dbo].[comandaProducto] cp
    INNER JOIN [ISProyecto].[dbo].[comanda] c ON cp.comanda_id = c.comanda_id
    INNER JOIN [ISProyecto].[dbo].[producto] p ON cp.producto_id = p.producto_id
    WHERE c.comanda_id = @comanda_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerComandaProductoPorMesaId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerComandaProductoPorMesaId]
    @mesa_id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        cp.comanda_producto_id,
        cp.comanda_id,
        cp.producto_id,
        p.nombre,  
        p.descripcion,  
        p.categoria, 
        cp.estado_producto,
        cp.cantidad,
        cp.precio_unitario,
        cp.subtotal
    FROM [ISProyecto].[dbo].[comandaProducto] cp
    INNER JOIN [ISProyecto].[dbo].[comanda] c ON cp.comanda_id = c.comanda_id
    INNER JOIN [ISProyecto].[dbo].[producto] p ON cp.producto_id = p.producto_id
    WHERE c.mesa_id = @mesa_id
      AND c.comanda_id = (
          SELECT TOP 1 comanda_id
          FROM [ISProyecto].[dbo].[comanda]
          WHERE mesa_id = @mesa_id
          ORDER BY fecha_hora_creacion asc
      );
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerComandaProductoProductoPorComandaId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerComandaProductoProductoPorComandaId]
    @comanda_id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        cp.comanda_producto_id,
        cp.comanda_id,
        cp.producto_id,
        p.nombre ,
        p.descripcion ,
        p.categoria,
        cp.estado_producto,
        cp.cantidad,
        cp.precio_unitario,
        cp.subtotal
    FROM [ISProyecto].[dbo].[comandaProducto] cp
    INNER JOIN [ISProyecto].[dbo].[comanda] c ON cp.comanda_id = c.comanda_id
    INNER JOIN [ISProyecto].[dbo].[producto] p ON cp.producto_id = p.producto_id
    WHERE c.comanda_id = @comanda_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerComandaProductosPendientes]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerComandaProductosPendientes]
    @mesa_id INT,
    @comanda_id INT
AS
BEGIN
    SELECT DISTINCT 
        cp.comanda_producto_id,
        cp.comanda_id,
        cp.producto_id,
        p.nombre,
        p.descripcion ,
        p.categoria,
        cp.estado_producto,
        cp.cantidad,
        cp.precio_unitario,
        cp.subtotal,
        c.mesa_id,    
        c.fecha_hora_creacion 
    FROM comandaProducto cp
    INNER JOIN comanda c ON cp.comanda_id = c.comanda_id
    INNER JOIN producto p ON cp.producto_id = p.producto_id
    WHERE c.mesa_id = @mesa_id
        AND cp.comanda_id = @comanda_id
        AND cp.estado_producto < 3 
    ORDER BY cp.producto_id; 
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerComandasPendientes]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerComandasPendientes]
AS
BEGIN
    SELECT DISTINCT c.comanda_id, c.mesa_id, fecha_hora_creacion, estado
    FROM comanda c
    INNER JOIN comandaProducto cp ON c.comanda_id = cp.comanda_id
    WHERE cp.estado_producto NOT IN (3, 4) AND estado <> 1 
    ORDER BY c.comanda_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerComandasPorMesaId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerComandasPorMesaId]
    @mesa_id INT
AS
BEGIN
    SELECT DISTINCT c.comanda_id, c.mesa_id, fecha_hora_creacion, estado
    FROM comanda c
    INNER JOIN comandaProducto cp ON c.comanda_id = cp.comanda_id
    WHERE c.mesa_id = @mesa_id
    AND c.estado = 0 
    ORDER BY c.comanda_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerEtiquetasConTraduccion]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerEtiquetasConTraduccion]
    @idioma_id INT
AS
BEGIN
    SELECT e.nombre AS nombre,
           e.etiqueta_id,
           i.idioma_id,
           i.nombre AS IdiomaNombre,
           t.texto AS Texto
    FROM etiqueta e
    INNER JOIN traduccion t ON e.etiqueta_id = t.etiqueta_id
    INNER JOIN idioma i ON t.idioma_id = i.idioma_id
    WHERE i.idioma_id = @idioma_id
    ORDER BY e.nombre;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerEtiquetasSinTraduccion]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerEtiquetasSinTraduccion]
  @idioma_id INT
AS
BEGIN
    SELECT e.nombre AS nombre,
           e.etiqueta_id
    FROM etiqueta e
    LEFT JOIN traduccion t ON e.etiqueta_id = t.etiqueta_id AND t.idioma_id = @idioma_id
    WHERE t.etiqueta_id IS NULL
    ORDER BY e.nombre;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerFacturaPorId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerFacturaPorId]
    @FacturaId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
	    FacturaId,
        NumeroFactura,
        FechaEmision,
        MesaId,
        ComandaId,
        ClienteId,
        SubtotalGeneral,
        DescuentoTotal,
        ImpuestoTotal,
        Propina,
        TotalFinal,
        EstadoPago,
        MontoPagado,
        Cambio,
        Notas,
        FechaCierre,
        DivisionPago,
        MetodoPagoId
    FROM 
        dbo.factura
    WHERE 
        FacturaId = @FacturaId;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerFacturaPorMesaYComanda]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerFacturaPorMesaYComanda]
    @MesaId INT,
    @ComandaId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        FacturaId,
        NumeroFactura,
        FechaEmision,
        MesaId,
        ComandaId,
        ClienteId,
        SubtotalGeneral,
        DescuentoTotal,
        ImpuestoTotal,
        Propina,
        TotalFinal,
        EstadoPago,
        MontoPagado,
        Cambio,
        Notas,
        FechaCierre,
        DivisionPago,
        MetodoPagoId
    FROM 
        dbo.factura
    WHERE 
        MesaId = @MesaId AND 
        ComandaId = @ComandaId AND
		EstadoPago = 2;

END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerFacturasPorEstado]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerFacturasPorEstado]
	@Estado INT
AS
BEGIN
    SELECT 
		FacturaId,
        NumeroFactura,
        FechaEmision,
        MesaId,
        ComandaId,
        ClienteId,
        SubtotalGeneral,
        DescuentoTotal,
        ImpuestoTotal,
        Propina,
        TotalFinal,
        EstadoPago,
        MontoPagado,
        Cambio,
        Notas,
        FechaCierre,
        DivisionPago,
        MetodoPagoId
    FROM 
        dbo.factura
    WHERE 
        EstadoPago = @Estado;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMedioDePagoPorId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMedioDePagoPorId]
    @MedioDePagoId INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Seleccionar el medio de pago por ID
    SELECT 
        MedioDePagoId,
        Nombre,
		Estado
    FROM 
        MediosDePago
    WHERE 
        MedioDePagoId = @MedioDePagoId;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMediosDePago]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMediosDePago]
AS
BEGIN
    SET NOCOUNT ON;

    -- Seleccionar el medio de pago por ID
    SELECT 
        MedioDePagoId,
        Nombre,
		Estado
    FROM 
        MediosDePago
	WHERE
		Estado <> 0

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMesaDisponiblePorId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMesaDisponiblePorId]
	@mesa_id INT,
	@estadoMesa INT
AS 
BEGIN
	SELECT
		m.mesa_id,
		m.capacidadMaxima,
		m.estado_mesa
	FROM mesa AS m
	WHERE m.estado_mesa <> @estadoMesa AND m.mesa_id = @mesa_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMesasDisponibles]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMesasDisponibles]
	@estadoMesa INT
AS 
BEGIN
	SELECT
		m.mesa_id,
		m.capacidadMaxima,
		m.estado_mesa
	FROM mesa AS m
	WHERE m.estado_mesa <> @estadoMesa
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMesasPorEstado]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMesasPorEstado]
	@estadoMesa INT
AS 
BEGIN
	SELECT
		m.mesa_id,
		m.capacidadMaxima,
		m.estado_mesa
	FROM mesa AS m
	WHERE m.estado_mesa = @estadoMesa

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerNotificacionesNoVistas]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerNotificacionesNoVistas]
AS
BEGIN
    SELECT notificacion_id, comanda_id, mesa_id, visto
    FROM Notificaciones
    WHERE visto = 0;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosTreeView]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerPermisosTreeView]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id AS id_permiso,
        p.nombre AS nombre_permiso,
        pp.id_permiso_padre,
        p.es_rol,
        p.habilitado,
        p.permiso 
    FROM 
        [dbo].[permiso] p
    LEFT JOIN 
        [dbo].[permiso_permiso] pp ON p.id = pp.id_permiso_hijo
    WHERE 
        p.habilitado = 1 
    ORDER BY 
        pp.id_permiso_padre, p.id; 

    SELECT 
        u.id_usuario,
        u.PasswordHash,
        u.Username,
		u.idioma_id,
        u.FechaCreacion
    FROM 
        [dbo].[usuarios] u
    ORDER BY 
        u.id_usuario;

    SELECT 
        up.id_usuario,
        up.id_permiso
    FROM 
        [dbo].[usuarios_permisos] up
    ORDER BY 
        up.id_usuario, up.id_permiso; 

    SELECT 
        pp.id_permiso_padre,
        pp.id_permiso_hijo
    FROM 
        [dbo].[permiso_permiso] pp
    ORDER BY 
        pp.id_permiso_padre, pp.id_permiso_hijo; 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosTreeView2]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPermisosTreeView2]
AS
BEGIN
    -- Manejo de errores
    BEGIN TRY
        -- Declaramos un CTE para obtener los permisos recursivamente
        WITH PermisosRecursivos AS (
            -- Nivel base: selecciona los permisos raíz (padres principales)
            SELECT 
                p.id AS id_permiso,
                p.nombre AS nombre_permiso,
                p.habilitado,
                p.es_rol,
                p.permiso,
                NULL AS id_padre, -- No hay padre en la raíz
                p.id AS id_hijo,
                1 AS nivel -- Nivel inicial
            FROM permiso p
            LEFT JOIN permiso_permiso pp ON p.id = pp.id_permiso_hijo
            
            UNION ALL

            -- Nivel recursivo: selecciona los hijos de los permisos anteriores
            SELECT 
                ph.id AS id_permiso,
                ph.nombre AS nombre_permiso,
                ph.habilitado,
                ph.es_rol,
                ph.permiso,
                pr.id_permiso AS id_padre,
                ph.id AS id_hijo,
                pr.nivel + 1 AS nivel
            FROM PermisosRecursivos pr
            JOIN permiso_permiso pp ON pr.id_permiso = pp.id_permiso_padre
            JOIN permiso ph ON pp.id_permiso_hijo = ph.id
        )

        -- Selecciona los permisos únicos y su jerarquía
        SELECT DISTINCT
            id_permiso,
            nombre_permiso,
            habilitado,
            es_rol,
            permiso,
            id_padre as id_permiso_padre,
            id_hijo,
            nivel
        FROM PermisosRecursivos
        ORDER BY nivel, id_padre, id_permiso; -- Orden jerárquico
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS ErrorMensaje;
    END CATCH
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosUsuario]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPermisosUsuario]
    @id_usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    WITH PermisosRecursivos AS (
        -- Permisos directos del usuario
        SELECT 
            up.id_usuario,
            p.id AS id_permiso,
            p.nombre AS nombre_permiso
        FROM [dbo].[usuarios_permisos] up
        JOIN [dbo].[permiso] p ON up.id_permiso = p.id
        WHERE up.id_usuario = @id_usuario 
          AND p.habilitado = 1  -- Solo permisos habilitados

        UNION ALL

        -- Permisos indirectos (heredados) a través de roles
        SELECT 
            pr.id_usuario,
            ph.id AS id_permiso,
            ph.nombre AS nombre_permiso
        FROM PermisosRecursivos pr
        JOIN [dbo].[permiso_permiso] pp ON pr.id_permiso = pp.id_permiso_padre
        JOIN [dbo].[permiso] ph ON pp.id_permiso_hijo = ph.id
        WHERE ph.habilitado = 1  -- Solo permisos habilitados
    )

    -- Selecciona todos los permisos recursivos para el usuario específico
    SELECT DISTINCT 
        id_usuario,
        id_permiso,
        nombre_permiso
    FROM PermisosRecursivos
    ORDER BY nombre_permiso; -- Ordenar los permisos por nombre, si se desea
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosUsuarioPorUsername]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPermisosUsuarioPorUsername]
    @username NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id_usuario INT;

    SELECT @id_usuario = u.id_usuario
    FROM [dbo].[usuarios] u  
    WHERE u.username = @username;

    IF @id_usuario IS NULL
    BEGIN
        RAISERROR('El usuario no existe.', 16, 1);
        RETURN;
    END;

    ;WITH PermisosRecursivos AS (
        SELECT 
            up.id_usuario,
            p.* 
        FROM [dbo].[usuarios_permisos] up
        JOIN [dbo].[permiso] p ON up.id_permiso = p.id
        WHERE up.id_usuario = @id_usuario 
          AND p.habilitado = 1  
        UNION ALL
        SELECT 
            pr.id_usuario,
            ph.*  
        FROM PermisosRecursivos pr
        JOIN [dbo].[permiso_permiso] pp ON pr.id = pp.id_permiso_padre
        JOIN [dbo].[permiso] ph ON pp.id_permiso_hijo = ph.id
        WHERE ph.habilitado = 1 
          AND ph.es_rol = 1 
          AND EXISTS (
              SELECT 1
              FROM [dbo].[usuarios_permisos] up
              WHERE up.id_usuario = @id_usuario
              AND up.id_permiso = pr.id
          )
    )
    SELECT DISTINCT 
        pr.nombre AS nombre_permiso,
        pr.habilitado,
        pr.es_rol,
        pr.id AS id_permiso,
        pp.id_permiso_padre,  
        pr.permiso
    FROM PermisosRecursivos AS pr
    LEFT JOIN [dbo].[permiso_permiso] pp ON pr.id = pp.id_permiso_hijo
    ORDER BY pr.nombre; 
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerProductosPorFacturaId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerProductosPorFacturaId]
    @FacturaId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ProductoFacturaId,
        FacturaId,
        ProductoId,
        NombreProducto,
        Cantidad,
        PrecioUnitario
    FROM 
        dbo.ProductoFactura
    WHERE 
        FacturaId = @FacturaId;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodasLasEtiquetas]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerTodasLasEtiquetas]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT etiqueta_id, nombre
    FROM etiqueta;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodasLasMesas]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerTodasLasMesas]
AS 
BEGIN
	SELECT
		m.mesa_id,
		m.capacidadMaxima,
		m.estado_mesa
	FROM mesa AS m
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosIdiomas]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerTodosLosIdiomas]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idioma_id, nombre, habilitado
    FROM idioma;  -- Asegúrate de que el nombre de la tabla sea correcto
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosPermisos]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerTodosLosPermisos]
AS
BEGIN
    SET NOCOUNT ON;

    -- CTE para obtener todos los permisos y sus relaciones recursivas
    WITH PermisosRecursivos AS
    (
        -- Caso base: permisos raíz (aquellos que no tienen un padre)
        SELECT
            p.id AS id_permiso,
            p.nombre AS nombre_permiso,
            p.permiso AS permiso,
            p.es_rol AS es_rol,
            p.habilitado AS habilitado,
            NULL AS id_permiso_padre -- No tienen padre
        FROM
            permiso p
        LEFT JOIN
            permiso_permiso pp ON p.id = pp.id_permiso_hijo
        WHERE
            pp.id_permiso_padre IS NULL
        
        UNION ALL

        -- Caso recursivo: encuentra hijos de cada permiso
        SELECT
            p.id AS id_permiso,
            p.nombre AS nombre_permiso,
            p.permiso AS permiso,
            p.es_rol AS es_rol,
            p.habilitado AS habilitado,
            pp.id_permiso_padre AS id_permiso_padre
        FROM
            permiso p
        INNER JOIN
            permiso_permiso pp ON p.id = pp.id_permiso_hijo
        INNER JOIN
            PermisosRecursivos pr ON pr.id_permiso = pp.id_permiso_padre
    )
    -- Selecciona todos los permisos obtenidos recursivamente
    SELECT
        id_permiso,
        nombre_permiso,
        permiso,
        es_rol,
        habilitado,
        id_permiso_padre
    FROM
        PermisosRecursivos
    ORDER BY
        id_permiso_padre, id_permiso; -- Orden jerárquico
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosProductos]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerTodosLosProductos]
AS 
BEGIN
	SELECT 
	   [producto_id]
	  ,[nombre]
      ,[descripcion]
      ,[precio]
      ,[tiempo_preparacion]
      ,[disponible]
      ,[es_postre]
      ,[categoria]
	FROM 
		producto as p
	WHERE
		p.disponible = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosUsuarios]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerTodosLosUsuarios]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		id_usuario,
		Username,
		PasswordHash,
		FechaCreacion,
		idioma_id
	FROM
		[ISProyecto].[dbo].[usuarios];
END
		
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTraduccionesPorIdioma]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerTraduccionesPorIdioma]
    @idiomaId INT
AS
BEGIN
    SELECT 
        e.etiqueta_id,
        e.nombre,
        t.texto AS traduccion
    FROM 
        etiqueta e
    LEFT JOIN 
        traduccion t ON e.etiqueta_id = t.etiqueta_id
    INNER JOIN 
        idioma i ON t.idioma_id = i.idioma_id AND i.idioma_id = @idiomaId
    ORDER BY 
        e.nombre;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerUsuarioPorNombre]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerUsuarioPorNombre]
    @UserName NVARCHAR(50)
AS
BEGIN
    SELECT * FROM usuarios WHERE UserName = @UserName;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_VerificarComandaOcupada]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_VerificarComandaOcupada]
    @mesa_id INT
AS
BEGIN
    DECLARE @comanda_id INT;

    SELECT @comanda_id = comanda_id
    FROM [ISProyecto].[dbo].[comanda]
    WHERE mesa_id = @mesa_id AND estado = 0;  

    IF @comanda_id IS NOT NULL
    BEGIN
        SELECT @comanda_id AS comanda_id;
    END
    ELSE
    BEGIN
        SELECT 0 AS comanda_id;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_VerificarEstadoComandaProductosPorMesaId]    Script Date: 21/11/2024 13:51:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_VerificarEstadoComandaProductosPorMesaId]
    @mesa_id INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (
        SELECT 1
        FROM [ISProyecto].[dbo].[comandaProducto] cp
        INNER JOIN [ISProyecto].[dbo].[comanda] c ON cp.comanda_id = c.comanda_id
        WHERE c.mesa_id = @mesa_id
          AND cp.estado_producto <> 4
    )
    BEGIN
        SELECT 1 AS resultado;
    END
    ELSE
    BEGIN
        SELECT 0 AS resultado;
    END
END;

GO
