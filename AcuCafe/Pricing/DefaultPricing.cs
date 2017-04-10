using AcuCafe.Domain;
using AcuCafe.Interfaces;

namespace AcuCafe.Pricing
{
    public abstract class DefaultPricing: Visitor, IPricing
    {
        private readonly decimal _drinkBaseMenuPrice;

        protected DefaultPricing(decimal drinkBaseMenuPrice)
        {
            _drinkBaseMenuPrice = drinkBaseMenuPrice;
        }

        protected decimal TotalPrice { get; set; } = 0;

        public decimal GetPrice(Drink drink)
        {
            ProccessDrink(drink);

            TotalPrice += _drinkBaseMenuPrice;

            return TotalPrice;
        }
    }
}