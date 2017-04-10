using AcuCafe.Domain;

namespace AcuCafe.Specification
{
    //https://en.wikipedia.org/wiki/Specification_pattern
    /// <summary>
    /// describes what kind of ingredients can be added into a drink 
    /// </summary>
    public class Specification
    {
        public virtual bool CanAdd(Ingerdient typeofIngredient)
        {
            return true;
        }
    }
}
