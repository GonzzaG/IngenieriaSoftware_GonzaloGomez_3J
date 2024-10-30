USE [ISProyecto]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 29/10/2024 15:20:55 ******/
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
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 29/10/2024 15:20:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prueba]    Script Date: 29/10/2024 15:20:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prueba](
	[id] [int] NOT NULL,
	[dni] [int] NULL,
 CONSTRAINT [PK_prueba] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 29/10/2024 15:20:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[PasswordHash] [varchar](256) NULL,
	[FechaCreacion] [date] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 29/10/2024 15:20:55 ******/
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
ALTER TABLE [dbo].[permiso] ADD  DEFAULT ((0)) FOR [es_rol]
GO
ALTER TABLE [dbo].[permiso] ADD  DEFAULT ((1)) FOR [habilitado]
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
/****** Object:  StoredProcedure [dbo].[sp_AsignarPermiso]    Script Date: 29/10/2024 15:20:55 ******/
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

    -- Verifica si la asignación ya existe
    IF NOT EXISTS (SELECT 1 FROM UsuarioPermisos WHERE UsuarioId = @usuario_id AND PermisoId = @permiso_id)
    BEGIN
        INSERT INTO UsuarioPermisos (UsuarioId, PermisoId)
        VALUES (@usuario_id, @permiso_id);
    END
    ELSE
    BEGIN
        PRINT 'El permiso ya está asignado a este usuario.';
    END
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarUsuario]    Script Date: 29/10/2024 15:20:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GuardarUsuario]
    @IdUsuario INT,
    @Username NVARCHAR(50),
    @PasswordHash NVARCHAR(255),
    @FechaCreacion DATETIME
AS
BEGIN
    INSERT INTO usuarios (id_usuario, Username, PasswordHash, FechaCreacion)
    VALUES (@IdUsuario, @Username, @PasswordHash, @FechaCreacion);
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosTreeView]    Script Date: 29/10/2024 15:20:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerPermisosTreeView]
AS
BEGIN
    SET NOCOUNT ON;

    -- Obtener todos los permisos junto con sus id_permiso_padre
    SELECT 
        p.id AS id_permiso,
        p.nombre AS nombre_permiso,
        pp.id_permiso_padre,
        p.es_rol,
        p.habilitado,
        p.permiso -- Descripción del permiso
    FROM 
        [dbo].[permiso] p
    LEFT JOIN 
        [dbo].[permiso_permiso] pp ON p.id = pp.id_permiso_hijo
    WHERE 
        p.habilitado = 1 -- Solo permisos habilitados
    ORDER BY 
        pp.id_permiso_padre, p.id; -- Orden para facilitar la visualización

    -- Obtener todos los usuarios
    SELECT 
        u.id_usuario,
        u.PasswordHash,
        u.Username,
        u.FechaCreacion
    FROM 
        [dbo].[usuarios] u
    ORDER BY 
        u.id_usuario; -- Orden para facilitar la visualización

    -- Obtener todas las relaciones entre usuarios y permisos
    SELECT 
        up.id_usuario,
        up.id_permiso
    FROM 
        [dbo].[usuarios_permisos] up
    ORDER BY 
        up.id_usuario, up.id_permiso; -- Orden para facilitar la visualización

    -- Obtener todas las relaciones entre permisos
    SELECT 
        pp.id_permiso_padre,
        pp.id_permiso_hijo
    FROM 
        [dbo].[permiso_permiso] pp
    ORDER BY 
        pp.id_permiso_padre, pp.id_permiso_hijo; -- Orden para facilitar la visualización
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosUsuario]    Script Date: 29/10/2024 15:20:55 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosPermisos]    Script Date: 29/10/2024 15:20:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored Procedure para obtener todos los permisos con todos sus campos
CREATE PROCEDURE [dbo].[sp_ObtenerTodosLosPermisos]
AS
BEGIN
    SET NOCOUNT ON;

    -- Seleccionar todos los permisos con todos los campos de la tabla "permiso"
    SELECT 
        id AS id_permiso,
        nombre AS nombre_permiso,
        permiso,
        es_rol,
        habilitado
    FROM 
        [dbo].[permiso]
    ORDER BY 
        id; -- Ordenar por ID para facilitar la visualización en la UI
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosUsuarios]    Script Date: 29/10/2024 15:20:55 ******/
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
		FechaCreacion
	FROM
		[ISProyecto].[dbo].[usuarios];
END
		
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerUsuarioPorNombre]    Script Date: 29/10/2024 15:20:55 ******/
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
