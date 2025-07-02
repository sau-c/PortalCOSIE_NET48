using System;
using System.Collections.Generic;

namespace PortalCOSIE.Domain.Entities
{
    public class Alumno : Usuario
    {
        public string NumeroBoleta { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CarreraId { get; set; }
        public int PlanEstudioId { get; set; }

        public virtual PlanEstudio PlanEstudio { get; set; }
        public virtual Carrera Carrera { get; set; }
    }
}
