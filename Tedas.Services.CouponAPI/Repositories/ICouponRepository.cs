using Tedas.Services.CouponAPI.Models.Dto;

namespace Tedas.Services.CouponAPI.Repositories
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
