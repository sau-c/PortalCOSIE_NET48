USE [PortalCOSIE]
GO

-- =========================================
--		Roles
-- =========================================
INSERT INTO Rol (Nombre, Descripcion)
VALUES 
	('Alumno', 'Rol para estudiantes que realizarán trámites.'),
	('Personal', 'Rol para trabajadores administrativos o docentes.'),
	('Administrador', 'Rol para administradores del sistema.')
GO

-- =========================================
--		Facultades (acciones del sistema)
-- =========================================
INSERT INTO Facultad (Nombre, Descripcion)
VALUES
	('ALTA_USUARIO', 'Permite registrar nuevos usuarios.'),
	('ALTA_TRAMITE', 'Inicia un nuevo tramite.'),
	('ALTA_DOCUMENTO', 'Carga de documentos.'),
	('CONSULTAR_DASHBBOARD', 'Acceso al panel de administración.'),
	('CONSULTAR_USUARIO', 'Ver datos del usuario.'),
	('CONSULTAR_TRAMITE', 'Ver estado y contenido del tramite.'),
	('CONSULTAR_DOCUMENTO', 'Ver documentos cargados por los alumnos.'),
	('ACTUALIZAR_USUARIO', 'Editar la información personal.'),
	('ACTUALIZAR_TRAMITE', 'Revisar y aceptar/rechazar trámites.'),
	('ACTUALIZAR_DOCUMENTO', 'Editar documento de trámite.'),
	('ACTUALIZAR_CONTRASENA', 'Permite modificar la contraseña.'),
	('COMENTAR_DOCUMENTO', 'Facultad para comentar documentos.'),
	('GENERAR_REPORTE', 'Para crear reportes del sistema.')
GO

-- =========================================
--		RolFacultad (asignación de facultades)
-- =========================================
INSERT INTO FacultadRol (RolId, FacultadId)
VALUES
	-- ALUMNO
	(1, 2),
	(1, 3),
	(1, 5),
	(1, 6),
	(1, 10),

	-- PERSONAL
	(2, 4),
	(2, 5),
	(2, 6),
	(2, 8),
	(2, 11),

	--ADMINISTRAOR
	(3, 1),
	(3, 4),
	(3, 7),
	(3, 9),
	(3, 10),
	(3, 12),
	(3, 13)
GO

-- =========================================
--		Carrera
-- =========================================
INSERT INTO Carrera (Nombre, Descripcion)
VALUES
	('Mecatronica','Carrera de ingenieria mecatronica'),
	('Telematica','Carrera de ingenieria telematica'),
	('Bionica','Carrera de ingenieria bionica'),
	('Energia','Carrera de ingenieria energia'),
	('Sistemas Automotrices','Carrera de ingenieria en sistemas automotrices')
GO

-- =========================================
--		Usuarios (15 alumnos, 4 personal, 1 admin)
-- =========================================
INSERT INTO Usuario (UserName, Nombre, ApellidoPaterno, ApellidoMaterno, RolId, Celular, Correo, Contrasena, FechaUltimoAcceso)
VALUES 
	-- Alumnos
	('alumno01', 'Carlos', 'Pérez', 'López', 1, '5512340001', 'alumno01@cosie.com', '1234', NULL),
	('alumno02', 'Ana', 'Gómez', 'Martínez', 1, '5512340002', 'alumno02@cosie.com', '1234', NULL),
	('alumno03', 'Luis', 'Rodríguez', 'Sánchez', 1, '5512340003', 'alumno03@cosie.com', '1234', NULL),
	('alumno04', 'María', 'Hernández', 'Vega', 1, '5512340004', 'alumno04@cosie.com', '1234', NULL),
	('alumno05', 'Pedro', 'Torres', 'Jiménez', 1, '5512340005', 'alumno05@cosie.com', '1234', NULL),
	('alumno06', 'Laura', 'Mendoza', 'Flores', 1, '5512340006', 'alumno06@cosie.com', '1234', NULL),
	('alumno07', 'José', 'Ruiz', 'Domínguez', 1, '5512340007', 'alumno07@cosie.com', '1234', NULL),
	('alumno08', 'Lucía', 'Castro', 'Aguilar', 1, '5512340008', 'alumno08@cosie.com', '1234', NULL),
	('alumno09', 'Miguel', 'Ramos', 'Navarro', 1, '5512340009', 'alumno09@cosie.com', '1234', NULL),
	('alumno10', 'Andrea', 'Silva', 'Guerrero', 1, '5512340010', 'alumno10@cosie.com', '1234', NULL),
	('alumno11', 'Fernando', 'Cruz', 'Ortiz', 1, '5512340011', 'alumno11@cosie.com', '1234', NULL),
	('alumno12', 'Diana', 'Chávez', 'Morales', 1, '5512340012', 'alumno12@cosie.com', '1234', NULL),
	('alumno13', 'Jorge', 'Delgado', 'Núñez', 1, '5512340013', 'alumno13@cosie.com', '1234', NULL),
	('alumno14', 'Natalia', 'Vargas', 'Salas', 1, '5512340014', 'alumno14@cosie.com', '1234', NULL),
	('alumno15', 'Ricardo', 'Pacheco', 'Valdez', 1, '5512340015', 'alumno15@cosie.com', '1234', NULL),

	-- Personal
	('personal01', 'Sofía', 'Lara', 'Campos', 2, '5512340016', 'personal01@cosie.com', '1234', NULL),
	('personal02', 'Andrés', 'Muñoz', 'Solís', 2, '5512340017', 'personal02@cosie.com', '1234', NULL),
	('personal03', 'Elena', 'Peña', 'Rosales', 2, '5512340018', 'personal03@cosie.com', '1234', NULL),
	('personal04', 'David', 'Santos', 'León', 2, '5512340019', 'personal04@cosie.com', '1234', NULL),

	-- Admin
	('admin', 'Admin', 'Master', NULL, 3, '5512340020', 'admin@cosie.com', 'admin', NULL)
GO

-- =========================================
--		Alumnos
-- =========================================
INSERT INTO Alumno (UserName, NumeroBoleta, FechaIngreso, Carrera, PlanEstudios)
VALUES 
	('alumno01', 2010000001, '2024-09-05', 1, 2009),
	('alumno02', 2011000002, '2024-09-05', 1, 2009),
	('alumno03', 2012000003, '2024-09-05', 1, 2009),
	('alumno04', 2013000004, '2024-09-05', 2, 2009),
	('alumno05', 2014000005, '2024-09-05', 2, 2009),
	('alumno06', 2015000006, '2024-09-05', 2, 2009),
	('alumno07', 2016000007, '2024-09-05', 3, 2009),
	('alumno08', 2017000008, '2024-09-05', 3, 2009),
	('alumno09', 2018000009, '2024-09-05', 3, 2009),
	('alumno10', 2019000010, '2024-09-05', 4, 2009),
	('alumno11', 2020000011, '2024-09-05', 4, 2009),
	('alumno12', 2021000012, '2024-09-05', 4, 2009),
	('alumno13', 2022000013, '2024-09-05', 5, 2009),
	('alumno14', 2023000014, '2024-09-05', 5, 2009),
	('alumno15', 2024000015, '2024-09-05', 5, 2009)
GO

-- =========================================
--		Personal
-- =========================================
INSERT INTO Personal (UserName, NumeroEmpleado)
VALUES
	('personal01', 1001),
	('personal02', 1002),
	('personal03', 1003),
	('personal04', 1004)
GO

-- =========================================
--		Estado
-- =========================================
INSERT INTO Estado (Nombre)
VALUES
	('En revision'),
	('Finalizado'),
	('Sin documentos'),
	('Comentarios pendientes')
GO

-- =========================================
--		Trámites (5 de distintos alumnos)
-- =========================================
INSERT INTO Tramite (Alumno, Personal, FechaSolicitud, FechaConclusion, EstadoId)
VALUES
	('alumno01', 'personal01', '2024-09-01', '2024-09-05',1),
	('alumno02', 'personal01','2024-09-02', '2024-09-06',2),
	('alumno03', 'personal02', '2024-09-03', '2024-09-07',3),
	('alumno04', 'personal03', '2024-09-04', '2024-09-08',4),
	('alumno05', 'personal04', '2024-09-05', '2024-09-09',1)
GO

-- =========================================
--		Documentos (2 por trámite, total 10)
-- =========================================
INSERT INTO Documento (Nombre, Comentario, TramiteId, ContenidoHash)
VALUES
	( 'Acta de nacimiento.pdf', 'Debes firmar en tinta azul.', 1, 0x00),
	( 'Comprobante de domicilio.pdf', 'El archivo está borroso, vuelve a escanear.', 1, 0x00),
	( 'INE.pdf', 'Falta el reverso en el PDF.', 2, 0x00),
	( 'Carta de motivos.pdf', 'Está sin firma del alumno.', 2, 0x00),
	( 'Historial académico.pdf', 'Formato inválido, debe ser el oficial.', 3, 0x00),
	( 'Kardex.pdf', 'Sellado ilegible.', 3, 0x00),
	( 'Identificación universitaria.pdf', 'Solo incluye un lado.', 4, 0x00),
	( 'Certificado médico.pdf', 'Falta sello del médico.', 4, 0x00),
	( 'Formato de reinscripción.pdf', 'Firma del coordinador no es visible.', 5, 0x00),
	( 'Carta de no adeudo.pdf', 'Falta nombre del alumno.', 5, 0x00)
GO
