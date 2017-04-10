using AcuCafe.Domain;

namespace AcuCafe.Interfaces
{
    //https://www.codeproject.com/Articles/588882/TheplusVisitorplusPatternplusExplained
    //https://industriallogic.com/xp/refactoring/accumulationToVisitor.html
    public abstract class Visitor
    {
        protected void ProccessDrink(Drink drink)
        {
            if (drink?.Ingredients != null)
                foreach (var ingredient in drink.Ingredients)
                {
                    ingredient.Accept(this);
                }
        }

        public abstract void ProccessSugar(Sugar concreteElementA); 
        public abstract void ProccessMilk(Milk concreteElementB);
        public abstract void ProccessChocolateTopping(ChocolateTopping concreteElementB);

 
    }
}