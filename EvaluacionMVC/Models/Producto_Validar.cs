using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EvaluacionMVC.Models
{
    public class Producto_Validar
    {
        public int idProducto { get; set; }
        [DisplayName("Nombre del Producto")]
        [Required(ErrorMessage = "Nombre del producto Requerido")]
        [Key]
        public string Nombre { get; set; }

        public string idCategoria { get; set; }
        [Required(ErrorMessage = "Precio del producto Requerido")]
        [Range(10, 50)]
        public int precio { get; set; }
        public DateTime fVencimiento { get; set; }
        [Required(ErrorMessage = "Unidades del producto Requerido")]
        [Range(100, 1000)]
        public int unidades { get; set; }

    }
}