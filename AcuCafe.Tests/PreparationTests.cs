using System;
using AcuCafe.Domain;
using AcuCafe.Interfaces;
using AcuCafe.Preparation;
using AcuCafe.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{
    [TestClass]
    public class PreparationTests
    {
        private static Tea CreateDrink()
        {
            var drink = new Tea();
            drink.AddSpecification(new Include<Sugar>());
            drink.AddIngredient(new Sugar());
            return drink;
        }

        [TestMethod]
        public void TestPreparationStrategy()
        {
            var drink = CreateDrink();
            IPreparationStrategy preparation = new PreparationStartegy();
            preparation.Prepare(drink);

        }

        [TestMethod]
        public void TestPreparationVisitor()
        {
            var drink = CreateDrink();
            IPreparationStrategy preparation = new PreparationVisitor();
            preparation.Prepare(drink);

        }

    }
}
