using System.Linq;
using WebInventario2._0.Models;
using WebInventario2._0.Models.SeguimientoModel;
using System.Collections.Generic;

namespace WebInventario2._0.Services
{
    public class SeguimientoService
    {
        public static PA_TOVA_SIB_InventariosEntities _db = new PA_TOVA_SIB_InventariosEntities();

        public SeguimientoResponse GetAvanceTotal(int baseId, string controlInventario)
        {
            var response = new SeguimientoResponse
            {
                ListAvanceZonaResponse = new List<SeguimientoResponse.AvanceZonaResponse>()
            };

            var avanceZonaResponse = _db.sp_Ciclico_AvanceZona(baseId, controlInventario);
            var avanceSkuPiezasResponse = _db.sp_Ciclico_AvanceSKU_Piezas(baseId, controlInventario).FirstOrDefault();

            response.ListAvanceZonaResponse = avanceZonaResponse.Select(m => new SeguimientoResponse.AvanceZonaResponse
            {
                Zona = m.Zona,
                Ubicacion = m.Ubicacion,
                Tipo = m.Tipo,
                Contada = m.Contada.Value
            }).ToList();

            response.TotalPiezas = avanceSkuPiezasResponse.TotalPiezas.Value;
            response.TotalPiezasContadas = avanceSkuPiezasResponse.TotalPiezasContadas.Value;
            response.TotalSKU = avanceSkuPiezasResponse.TotalSKU.Value;
            response.TotalSKUContados = avanceSkuPiezasResponse.TotalSKUContados.Value;

            return response;
        }
    }
}