using System.CodeDom;
using System.Collections.Generic;
using AcuCafe.Interfaces;
using AcuCafe.Specification;

namespace AcuCafe.Domain
{
    public abstract class Drink : MenuItem
    {
        //here are a default implementation of bridge pattern  as it is located in the Drink abstraction 

        public IPreparationStrategy PreparationStategy { get; set; }
        public IList<Ingerdient> Ingredients { get; set; } = new List<Ingerdient>();

        public void AddIngredient(Ingerdient ingredient)
        {
            if (CanAdd(ingredient))
            {
                Ingredients.Add(ingredient);
            }
            else
            {
                throw new NotAllowedIngredientException($"{ingredient.Description} ingredient should not be added to {Description}");
            }
        }
        public string Description { get; set; }

        public void Prepare(IPreparationStrategy preparationStartegy)
        {
            preparationStartegy.Prepare(this);
        }

    }
}
