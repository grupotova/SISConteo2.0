using System.Collections.Generic;

namespace WebInventario2._0.Models.SeguimientoModel
{
    public class SeguimientoResponse
    {
        public List<AvanceZonaResponse> ListAvanceZonaResponse { get; set; }
        public int TotalPiezas { get; set; }
        public int TotalPiezasContadas { get; set; }
        public int TotalSKU { get; set; }
        public int TotalSKUContados { get; set; }

        public class AvanceZonaResponse
        {
            public string Zona { get; set; }
            public string Ubicacion { get; set; }
            public string Tipo { get; set; }
            public bool Contada { get; set; }
        }
    }
}