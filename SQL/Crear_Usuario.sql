
-- 1. Crear el login SQL
CREATE LOGIN usuario2025 WITH PASSWORD = 'usuario2025';

-- 2. Usar la base de datos
USE PortalCOSIE;

-- 3. Crear el usuario dentro de la base de datos
CREATE USER usuario2025 FOR LOGIN usuario2025;

-- 4. Darle permisos (puedes ajustar el rol)
ALTER ROLE db_datareader ADD MEMBER usuario2025;
ALTER ROLE db_datawriter ADD MEMBER usuario2025;
-- O si necesitas control total dentro de la base de datos
-- ALTER ROLE db_owner ADD MEMBER usuario_proyecto;


SELECT name, type_desc, is_disabled
FROM sys.server_principals
WHERE name = 'usuario2025';

USE PortalCOSIE;
GO

SELECT name, type_desc
FROM sys.database_principals
WHERE name = 'usuario2025';
