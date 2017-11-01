using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebAPI.Models
{
    public class PedidoViewModel
    {
        public long Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Range(0,double.MaxValue,ErrorMessage ="Debe ser un valor positivo")]
        public decimal Precio { get; set; }
        public long Cantidad { get; set; }

    }
}