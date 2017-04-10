using System;
using AcuCafe.Domain;
using AcuCafe.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{
    [TestClass]
    public class SepcificationTest
    {
        [TestMethod]
        public void ShouldNotAllowIngredient()
        {
            var menuItem = new MenuItem();

            menuItem.AddSpecification(new Exclude <Sugar>());

             Assert.IsFalse(menuItem.CanAdd(new Sugar()));
             Assert.IsTrue(menuItem.CanAdd(new Milk()));

        }

        [TestMethod]
        public void ShouldAllowIngredient()
        {
            var menuItem = new MenuItem();

            menuItem.AddSpecification(new Include<Sugar>());

            Assert.IsTrue(menuItem.CanAdd(new Sugar()));
            Assert.IsTrue(menuItem.CanAdd(new Milk()));

        }
    }
}
