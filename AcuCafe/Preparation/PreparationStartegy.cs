using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcuCafe.Domain;
using AcuCafe.Interfaces;

namespace AcuCafe.Preparation
{
    //here are a default implementation of strategy pattern that actually form a bridge as it is located in the Drink abstraction 
    public class PreparationStartegy : IPreparationStrategy
    {
        // the implementation just writes to debug but here should be the actual actions need to be made
        public void Prepare(Drink drink)
        {
            AcuCafeLogger.WriteLine($"Preparing {drink.Description}");

            if (drink?.Ingredients != null)
                foreach (var ingredient in drink.Ingredients)
                {
                    AcuCafeLogger.WriteLine($"Adding {ingredient.Description}");
                }
        }
    }
}
