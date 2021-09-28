using Estructura.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estructura
{
    public class ActivoFijo
    {
        public int id { get; set; }
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivoFijo tipoActivoFijo { get; set; }
        public MetodoDepreciacion metodoDepreciacion { get; set; }
    }
}
