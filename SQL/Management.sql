USE PortalCOSIE
GO

-- =========================================
-- 1. CONSULTA (DQL)
-- =========================================
--Tablas
SELECT * FROM Rol
SELECT * FROM Facultad
SELECT * FROM FacultadRol
SELECT * FROM Carrera
SELECT * FROM Usuario
SELECT * FROM Alumno
SELECT * FROM Personal
SELECT * FROM Estado
SELECT * FROM Tramite
SELECT * FROM Documento

-- Informacion para el usuario guardada en Stored Procedures
EXEC spGetAllAlumno
EXEC spGetAllFacultad
EXEC spGetAllRol
EXEC spGetAllFacultadRol

-- =========================================
-- 2. Manipulacion (DML)
-- =========================================

-- Sutituir valores dependiendo la tabla
SELECT * FROM dbo.Rol

--UPDATE [dbo].[Rol]
--SET [Nombre] = 'ADMINISTRADOR'
--	--,[Descripcion] = ''
--WHERE Id = 1

--DELETE FROM Rol WHERE RolId = 1
-- ===========================================




--%%%%%%%%%%%%%%%%%%%%%%%%
--%%%% ELIMINAR TABLAS %%%
--%%%%%%%%%%%%%%%%%%%%%%%%
DROP TABLE dbo.Documento
GO
DROP TABLE dbo.Tramite
GO
DROP TABLE dbo.Estado
GO
DROP TABLE dbo.Personal
GO
DROP TABLE dbo.Alumno
GO
DROP TABLE dbo.Usuario
GO
DROP TABLE dbo.Carrera
GO
DROP TABLE dbo.PermisoRol
GO
DROP TABLE dbo.Permiso
GO
DROP TABLE dbo.Rol
GO
DROP TABLE dbo.Menu
GO
DROP TABLE dbo.PlanEstudio
GO
