using AcuCafe.Domain;

namespace AcuCafe.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPricing
    {
        decimal GetPrice(Drink drink);
    }
}