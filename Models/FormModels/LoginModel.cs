using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebInventario2._0.Models.FormModels
{
    public class LoginModel
    {
        [Required]
        public String usuario { get; set; }
        [Required]
        public String contrasenia { get; set; }
        public String mensaje { get; set; }
    }
}