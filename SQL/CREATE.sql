--CREATE DATABASE PortalCOSIE
--GO

USE PortalCOSIE
GO

CREATE TABLE Menu (
    Id INT IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(50) NULL,
    PadreId INT NULL,
	Icono VARCHAR(50) NULL,
    Controller VARCHAR(50) NULL,
    [Action] VARCHAR(50) NULL,
    CONSTRAINT PK_Menu PRIMARY KEY (Id)
);
GO

CREATE TABLE Rol (
    Id INT IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX) NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT PK_Rol PRIMARY KEY (Id),
	CONSTRAINT UQ_Rol_Nombre UNIQUE (Nombre)
);
GO

CREATE TABLE Facultad (
    Id INT IDENTITY(1,1) NOT NULL,
    Nombre NVARCHAR(150) NOT NULL,
    Descripcion NVARCHAR(MAX),
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT PK_Facultad PRIMARY KEY (Id),
    CONSTRAINT UQ_Facultad_Nombre UNIQUE (Nombre)
);
GO

CREATE TABLE FacultadRol (
    RolId INT NOT NULL,
    FacultadId INT NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT PK_RolFacultad PRIMARY KEY (RolId, FacultadId),
    CONSTRAINT FK_RolFacultad_Rol FOREIGN KEY (RolId) REFERENCES Rol(Id),
    CONSTRAINT FK_RolFacultad_Facultad FOREIGN KEY (FacultadId) REFERENCES Facultad(Id)
);
GO

CREATE TABLE Carrera (
    Id INT IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX) NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT PK_Carrera PRIMARY KEY (Id),
	CONSTRAINT UQ_Carrera_Nombre UNIQUE (Nombre)
);
GO

CREATE TABLE PlanEstudios (
    Id INT IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX) NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT PK_PlanEstudios PRIMARY KEY (Id),
	CONSTRAINT UQ_PlanEstudios_Nombre UNIQUE (Nombre)
);
GO

-- Tabla base de usuarios
CREATE TABLE Usuario (
    Id INT IDENTITY(1,1) NOT NULL,
    --UserName NVARCHAR(20) NOT NULL PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    ApellidoPaterno NVARCHAR(100) NOT NULL,
    ApellidoMaterno NVARCHAR(100),
    RolId INT NOT NULL,
    Celular NVARCHAR(20) NOT NULL,
    Correo NVARCHAR(320) UNIQUE NOT NULL,
    Contrasena NVARCHAR(MAX) NOT NULL,
    FechaUltimoAcceso DATETIME,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (RolId) REFERENCES Rol(Id),
    CONSTRAINT CHK_Usuario_Correo CHECK (Correo LIKE '_%@_%._%')
);
GO

CREATE TABLE Acceso (
    Id INT IDENTITY(1,1) NOT NULL,
    UsuarioId INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    ApellidoPaterno NVARCHAR(100) NOT NULL,
    ApellidoMaterno NVARCHAR(100),
    RolId INT NOT NULL,
    Celular NVARCHAR(20) NOT NULL,
    Correo NVARCHAR(320) UNIQUE NOT NULL,
    Contrasena NVARCHAR(MAX) NOT NULL,
    FechaUltimoAcceso DATETIME,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (RolId) REFERENCES Rol(Id),
    CONSTRAINT CHK_Usuario_Correo CHECK (Correo LIKE '_%@_%._%')
);
GO

-- Tabla de alumnos
CREATE TABLE Alumno (
    UserName NVARCHAR(20) NOT NULL PRIMARY KEY,
    NumeroBoleta INT NOT NULL UNIQUE,
    FechaIngreso DATE NOT NULL,
	Carrera INT,
	PlanEstudios INT,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT FK_Alumno_Usuario FOREIGN KEY (UserName) REFERENCES Usuario(UserName),
    CONSTRAINT FK_Alumno_Carrera FOREIGN KEY (Carrera) REFERENCES Carrera(CarreraId)
);
GO

-- Tabla de personal administrativo
CREATE TABLE Personal (
    UserName NVARCHAR(20) NOT NULL PRIMARY KEY,
    NumeroEmpleado INT NOT NULL UNIQUE,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT FK_Personal_Usuario FOREIGN KEY (UserName) REFERENCES Usuario(UserName)
);
GO

-- Tabla de estados para los tramites
CREATE TABLE Estado (
    EstadoId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
);
GO

-- Tabla de trámites realizados por alumnos
CREATE TABLE Tramite (
    TramiteId INT IDENTITY(1,1) PRIMARY KEY,
    Alumno NVARCHAR(20) NOT NULL,
    Personal NVARCHAR(20) NOT NULL,
	FechaSolicitud DATE NOT NULL,
	FechaConclusion DATE NOT NULL,
	EstadoId INT NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT FK_Tramite_Alumno FOREIGN KEY (Alumno) REFERENCES Alumno(UserName),
    CONSTRAINT FK_Tramite_Personal FOREIGN KEY (Personal) REFERENCES Personal(UserName),
    CONSTRAINT FK_Tramite_Estado FOREIGN KEY (EstadoId) REFERENCES Estado(EstadoId)
);
GO

-- Tabla de documentos ligados a un trámite
CREATE TABLE Documento (
    DocumentoId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Comentario NVARCHAR(MAX),
    TramiteId INT NOT NULL,
    ContenidoHash VARBINARY(MAX),
	CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
	CreatedBy NVARCHAR(20) NOT NULL,
	UpdatedAt DATETIME NULL,
	UpdatedBy NVARCHAR(20) NULL,
    CONSTRAINT FK_Documento_Tramite FOREIGN KEY (TramiteId) REFERENCES Tramite(TramiteId)
);
GO
