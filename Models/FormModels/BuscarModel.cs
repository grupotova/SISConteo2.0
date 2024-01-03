using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebInventario2._0.Models.FormModels
{
    public class BuscarModel
    {
        [AllowHtml]
        [Required]
        public String documentoControl { get; set; }
        [AllowHtml]
        [Required]
        public int _Base { get; set; }
        [AllowHtml]
        public String mensaje { get; set; }
        public Decimal CostoPiso { get; set; }
        [AllowHtml]
        public Decimal CostoDep { get; set; }
        [AllowHtml]
        public Decimal dporPiso { get; set; }
        [AllowHtml]
        public Decimal dporDep { get; set; }
        [AllowHtml]
        public String cod_estilo { get; set; }
        [AllowHtml]
        public String sku { get; set; }
    }
}