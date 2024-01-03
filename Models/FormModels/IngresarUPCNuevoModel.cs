using DevExpress.Web.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebInventario2._0.Models.FormModels
{
    public class IngresarUPCNuevoModel
    {
        [AllowHtml]
        public String documentoControl {  get; set; }
        [AllowHtml]
        public String _base {  get; set; }
        [AllowHtml]
        public String ubicacion { get; set; }
        [AllowHtml]
        public String UPC {  get; set; }
        [AllowHtml]
        public String cantidad { get; set; }
        [AllowHtml]
        public String codEstilo { get; set; }
        [AllowHtml]
        public String descripcion { get; set; }
        [AllowHtml]
        public String SKU { get; set; }
        [AllowHtml]
        public String identificador { get; set; }
        [AllowHtml]
        public String mensaje { get; set; }
    }
}