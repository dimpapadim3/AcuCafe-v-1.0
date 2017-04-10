using AcuCafe.Interfaces;

namespace AcuCafe.Domain
{
    public class Milk : Ingerdient
    {
        public Milk()
        {
            Description = "Milk";
        }
        public override void Accept(Visitor visitor)
        {
            visitor.ProccessMilk(this);
        }
    }
}