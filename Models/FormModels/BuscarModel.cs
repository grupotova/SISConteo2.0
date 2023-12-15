using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebInventario2._0.Models.FormModels
{
    public class BuscarModel
    {
        [Required]
       public String documentoControl { get; set; }

        [Required]
       public int _Base{ get; set; }
    }
}