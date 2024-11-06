USE [ISProyecto]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 31/10/2024 14:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prueba]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_AgregarPermiso]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_AsignarPermiso]    Script Date: 31/10/2024 14:16:32 ******/
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

    -- Verifica si el permiso es un rol
    SELECT @es_rol = es_rol 
    FROM [dbo].[permiso] 
    WHERE [id] = @permiso_id;

    -- Verifica si el permiso está habilitado
    IF EXISTS (SELECT 1 FROM [dbo].[permiso] WHERE [id] = @permiso_id AND [habilitado] = 1)
    BEGIN
        -- Si es un rol, asigna el permiso y sus permisos hijos
        IF @es_rol = 1
        BEGIN
            -- Inserta el permiso principal si aún no está asignado
            IF NOT EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
            BEGIN
                INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
                VALUES (@usuario_id, @permiso_id);
            END

            -- Asigna todos los permisos hijos del rol de forma recursiva
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
            -- Si no es un rol, solo asigna el permiso si aún no está asignado
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

    -- Retorna la tabla usuarios_permisos
    SELECT id_usuario, id_permiso FROM [dbo].[usuarios_permisos]
    WHERE [id_usuario] = @usuario_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_AsignarPermisoPorCod]    Script Date: 31/10/2024 14:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AsignarPermisoPorCod]
    @usuario_nombre NVARCHAR(50),  -- Nombre de usuario
    @cod_permiso NVARCHAR(50)  -- Código de permiso
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @es_rol BIT;
    DECLARE @permiso_id INT;
    DECLARE @usuario_id INT;

    -- Obtiene el ID del permiso a partir del CodPermiso
    SELECT @permiso_id = id
    FROM [dbo].[permiso] 
    WHERE [permiso] = @cod_permiso;

    -- Verifica si se encontró el permiso
    IF @permiso_id IS NULL
    BEGIN
        PRINT 'El permiso especificado no existe.';
        RETURN;
    END

    -- Obtiene el ID del usuario a partir del nombre de usuario
    SELECT @usuario_id = id_usuario
    FROM [dbo].[usuarios] 
    WHERE [username] = @usuario_nombre;

    -- Verifica si se encontró el usuario
    IF @usuario_id IS NULL
    BEGIN
        PRINT 'El usuario especificado no existe.';
        RETURN;
    END

    -- Verifica si el permiso es un rol
    SELECT @es_rol = es_rol 
    FROM [dbo].[permiso] 
    WHERE [id] = @permiso_id;

    -- Verifica si el permiso está habilitado
    IF EXISTS (SELECT 1 FROM [dbo].[permiso] WHERE [id] = @permiso_id AND [habilitado] = 1)
    BEGIN
        -- Si es un rol, asigna el permiso y sus permisos hijos
        IF @es_rol = 1
        BEGIN
            -- Inserta el permiso principal si aún no está asignado
            IF NOT EXISTS (SELECT 1 FROM [dbo].[usuarios_permisos] WHERE [id_usuario] = @usuario_id AND [id_permiso] = @permiso_id)
            BEGIN
                INSERT INTO [dbo].[usuarios_permisos] ([id_usuario], [id_permiso])
                VALUES (@usuario_id, @permiso_id);
            END

            -- Asigna todos los permisos hijos del rol de forma recursiva
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
            -- Si no es un rol, solo asigna el permiso si aún no está asignado
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

    -- Retorna la tabla usuarios_permisos
    SELECT id_usuario, id_permiso FROM [dbo].[usuarios_permisos]
    WHERE [id_usuario] = @usuario_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_DesasignarPermiso]    Script Date: 31/10/2024 14:16:32 ******/
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
                SELECT pr.id FROM PermisosRecursivos pr
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
/****** Object:  StoredProcedure [dbo].[sp_EliminarPermiso]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_EliminarUsuario]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GuardarUsuario]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosTreeView]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosUsuario]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPermisosUsuarioPorUsername]    Script Date: 31/10/2024 14:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerPermisosUsuarioPorUsername]
    @username NVARCHAR(255)  -- Cambia el tipo de dato según el tamaño de tu campo Username
AS
BEGIN
    SET NOCOUNT ON;

    -- Variable para almacenar el id_usuario
    DECLARE @id_usuario INT;

    -- Obtener el id_usuario a partir del username
    SELECT @id_usuario = u.id_usuario
    FROM [dbo].[usuarios] u  -- Asegúrate de que esta tabla existe y contiene el campo username
    WHERE u.username = @username;

    -- Verificar si se encontró el usuario
    IF @id_usuario IS NULL
    BEGIN
        RAISERROR('El usuario no existe.', 16, 1);
        RETURN;
    END;

    ;WITH PermisosRecursivos AS (
        -- Permisos directos del usuario
        SELECT 
            up.id_usuario,
            p.*  -- Selecciona todos los campos de la tabla permiso
        FROM [dbo].[usuarios_permisos] up
        JOIN [dbo].[permiso] p ON up.id_permiso = p.id
        WHERE up.id_usuario = @id_usuario 
          AND p.habilitado = 1  -- Solo permisos habilitados

        UNION ALL

        -- Permisos indirectos (heredados) a través de roles
        SELECT 
            pr.id_usuario,
            ph.*  -- Selecciona todos los campos de la tabla permiso
        FROM PermisosRecursivos pr
        JOIN [dbo].[permiso_permiso] pp ON pr.id = pp.id_permiso_padre
        JOIN [dbo].[permiso] ph ON pp.id_permiso_hijo = ph.id
        WHERE ph.habilitado = 1  -- Solo permisos habilitados
    )

    -- Selecciona todos los permisos recursivos para el usuario específico, incluyendo el id_permiso_padre
    SELECT DISTINCT 
        pr.nombre AS nombre_permiso,
        pr.habilitado,
        pr.es_rol,
        pr.id AS id_permiso,
        pp.id_permiso_padre,  -- Agrega el id_permiso_padre desde la tabla permiso_permiso
        pr.permiso
    FROM PermisosRecursivos AS pr
    LEFT JOIN [dbo].[permiso_permiso] pp ON pr.id = pp.id_permiso_hijo
    ORDER BY pr.nombre; -- Ordenar los permisos por nombre, si se desea
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosPermisos]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosUsuarios]    Script Date: 31/10/2024 14:16:32 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerUsuarioPorNombre]    Script Date: 31/10/2024 14:16:32 ******/
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
