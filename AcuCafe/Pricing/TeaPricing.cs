using AcuCafe.Domain;

namespace AcuCafe.Pricing
{
    public class TeaPricing : DefaultPricing
    {
        public TeaPricing(decimal drinkBaseMenuPrice) : base(drinkBaseMenuPrice)
        {
        }
        public override void ProccessSugar(Sugar concreteElementA)
        {
            TotalPrice += 20;
        }

        public override void ProccessMilk(Milk concreteElementB)
        {
            TotalPrice += 20;
        }

        public override void ProccessChocolateTopping(ChocolateTopping concreteElementB)
        {

        }


    }
}