using AcuCafe.Interfaces;

namespace AcuCafe.Domain
{
    public class ChocolateTopping : Ingerdient
    {
        public ChocolateTopping()
        {
            Description = "Chocolate Topping";
        }
        public override void Accept(Visitor visitor)
        {
            visitor.ProccessChocolateTopping(this);
        }
    }
}