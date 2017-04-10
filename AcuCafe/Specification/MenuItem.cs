using System.Collections.Generic;
using System.Linq;
using AcuCafe.Domain;

namespace AcuCafe.Specification
{
    public class MenuItem
    { 
        IList<Specification> Specifications { get; } = new  List<Specification>();
         
        public bool CanAdd(Ingerdient ingredient)
        {
            return Specifications.All(specification => specification.CanAdd(ingredient)); 
        }

        public MenuItem AddSpecification(Specification specification)
        {
            Specifications.Add(specification);
            return this;
        }

    }
}