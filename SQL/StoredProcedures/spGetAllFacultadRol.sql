USE PortalCOSIE
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spGetAllFacultadRol
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT R.Nombre, F.Nombre
	FROM FacultadRol FR
	INNER JOIN Facultad AS F
		ON FR.FacultadId = F.FacultadId
	INNER JOIN Rol AS R
		ON FR.RolId = R.RolId
END
GO
