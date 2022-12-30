using Tedas.Services.ShoppingCartAPI.Models.Dto;

namespace Tedas.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
