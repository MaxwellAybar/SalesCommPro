using SalesCommPro.Application.DTOs;

namespace SalesCommPro.Infrastructure.Services
{
    public class CommissionService
    {
        public decimal Calculate(CommissionDTO dto)
        {
            decimal baseAmount = dto.Sales - dto.Discount;

            return dto.Country switch
            {
                "India" => baseAmount * 0.10m,
                "US" => baseAmount * 0.15m,
                "UK" => baseAmount * 0.12m,
                _ => 0
            };
        }
    }
}