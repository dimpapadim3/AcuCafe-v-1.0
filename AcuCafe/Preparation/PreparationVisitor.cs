using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcuCafe.Domain;
using AcuCafe.Interfaces;

namespace AcuCafe.Preparation
{
    //an other implementation this is also an adapter since it adapts visitor to IPreparationStrategy
    public class PreparationVisitor : Visitor, IPreparationStrategy
    {      
        // the implementation just writes to debug but here should be the actual actions need to be made

        public void Prepare(Drink drink)
        {
            AcuCafeLogger.WriteLine($"Preparing {drink.Description}");

            ProccessDrink(drink);
        }

        public override void ProccessSugar(Sugar ingredient)
        {
            AcuCafeLogger.WriteLine($"Adding {ingredient.Description}");
        }

        public override void ProccessMilk(Milk ingredient)
        {
            AcuCafeLogger.WriteLine($"Adding {ingredient.Description}");
        }

        public override void ProccessChocolateTopping(ChocolateTopping concreteElementB)
        {
       
        }
    }
}
