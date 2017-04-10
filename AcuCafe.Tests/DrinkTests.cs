using System;
using AcuCafe.Domain;
using AcuCafe.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{
    [TestClass]
    public class DrinkTests
    {
        [TestMethod]
        public void ShouldAddIngredient()
        {
            var drink = new Tea();
            drink.AddSpecification(new Include<Sugar>());
            drink.AddIngredient(new Sugar());
            Assert.IsTrue(drink.Ingredients.Count == 1);
        }
        [TestMethod]
        public void ShouldAddIngredientByDefault()
        {
            var drink = new Tea();
            //drink.AddSpecification(new Include<Sugar>());
            drink.AddIngredient(new Sugar());
        }
        [TestMethod]
        [ExpectedException(typeof(NotAllowedIngredientException))]

        public void ShouldNotAllowAdditionOfIngredient()
        {
            var drink = new IceTea();
            drink.AddSpecification(new Exclude<Milk>());
            drink.AddIngredient(new Milk());
        }

    }
}
