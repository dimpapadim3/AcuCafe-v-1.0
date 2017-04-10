using AcuCafe.Domain;

namespace AcuCafe.Specification
{
    public class Include<T> : Specification
    {
        public override bool CanAdd(Ingerdient typeofIngredient)
        {
            return typeofIngredient is T;
        }
    }
}