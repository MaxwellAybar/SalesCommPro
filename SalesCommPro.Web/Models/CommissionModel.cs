using System.ComponentModel.DataAnnotations;

namespace SalesCommPro.Web.Models
{
    public class CommissionModel
    {
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Sales { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Discount { get; set; }

        [Required]
        public string Country { get; set; }

        public decimal Result { get; set; }
    }
}