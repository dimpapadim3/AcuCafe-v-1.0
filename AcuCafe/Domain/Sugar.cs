using AcuCafe.Interfaces;

namespace AcuCafe.Domain
{
    public class Sugar : Ingerdient
    {
        public Sugar()
        {
            Description = "Sugar";
        }
        public override void Accept(Visitor visitor)
        {
            visitor.ProccessSugar(this);
        }
    }
}

