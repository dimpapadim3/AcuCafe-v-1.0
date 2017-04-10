using AcuCafe.Domain;
using AcuCafe.Pricing;

namespace AcuCafe.Tests.Mocks
{
    public class MockPricing : DefaultPricing
    {

        public MockPricing(decimal drinkBaseMenuPrice) : base(drinkBaseMenuPrice)
        {
        }
        public override void ProccessSugar(Sugar concreteElementA)
        {
            TotalPrice += 10;
        }

        public override void ProccessMilk(Milk concreteElementB)
        {
            TotalPrice += 10;
        }

        public override void ProccessChocolateTopping(ChocolateTopping concreteElementB)
        {
        }
    }
}