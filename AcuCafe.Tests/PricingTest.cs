using System;
using AcuCafe.Domain;
using AcuCafe.Specification;
using AcuCafe.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{

    [TestClass]
    public class PricingTest
    {
        [TestMethod]
        public void ShouldPriceSugarCorrectly()
        {
            var pricing = new MockPricing(0);
            pricing.ProccessSugar(new Sugar());
            var price = pricing.GetPrice(null);
            Assert.IsTrue(price == 10); 
        }

        [TestMethod]
        public void ShouldPriceMilkCorrectly()
        {
            var pricing = new MockPricing(0);
            pricing.ProccessMilk(new Milk());
            var price = pricing.GetPrice(null);
            Assert.IsTrue(price == 20);

        }

        [TestMethod]
        public void TestMethod1()
        {
            var drink = new Tea();
            drink.AddSpecification(new Include<Sugar>());
            drink.AddIngredient(new Sugar());
            var price = new MockPricing(100).GetPrice(drink);
            Assert.IsTrue(price == 110);
        }
    }
}
