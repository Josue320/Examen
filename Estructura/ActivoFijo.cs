using Estructura.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estructura
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ActivoFijo
    {
        [JsonProperty]
        public int id { get; set; }
        [JsonProperty]
        public string CodigoActivo { get; set; }
        [JsonProperty]
        public string NombreActivo { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public decimal ValorActivo { get; set; }
        [JsonProperty]
        public decimal ValorResidual { get; set; }
        [JsonProperty]
        public DateTime FechaAdquisicion { get; set; }
        [JsonProperty]
        public TipoActivoFijo tipoActivoFijo { get; set; }
        [JsonProperty]
        public MetodoDepreciacion metodoDepreciacion { get; set; }
    }
}
