using AcuCafe.Interfaces;

namespace AcuCafe.Domain
{
    public abstract class Ingerdient
    {
        public abstract void Accept(Visitor visitor);

        public decimal Price { get; set; }  

        public string Description { get; set; }
    }
}