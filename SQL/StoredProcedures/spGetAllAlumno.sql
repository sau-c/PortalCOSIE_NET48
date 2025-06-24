USE PortalCOSIE
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spGetAllAlumno 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT A.NumeroBoleta, U.PrimerNombre, U.SegundoNombre, U.ApellidoMaterno, U.ApellidoMaterno
	, C.Nombre AS Carrera, A.PlanEstudios, A.FechaIngreso

	FROM Alumno AS A
	INNER JOIN Usuario AS U
	ON A.UserName = U.UserName
	INNER JOIN Carrera AS C
	ON A.Carrera = C.CarreraId

END
GO
