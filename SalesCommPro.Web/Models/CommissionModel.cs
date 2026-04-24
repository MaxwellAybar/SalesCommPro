using System.ComponentModel.DataAnnotations;

namespace SalesCommPro.Web.Models
{
    public class CommissionModel
    {
        [Required(ErrorMessage = "Las ventas son obligatorias")]
        [Range(0, double.MaxValue, ErrorMessage = "Las ventas deben ser mayores o iguales a 0")]
        public decimal? Sales { get; set; }

        [Required(ErrorMessage = "El descuento es obligatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "El descuento debe ser mayor o igual a 0")]
        public decimal? Discount { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un país")]
        public string Country { get; set; }

        public decimal Result { get; set; }

        public bool HasResult { get; set; }
    }
}