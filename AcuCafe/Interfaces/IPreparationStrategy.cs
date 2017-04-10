using AcuCafe.Domain;

namespace AcuCafe.Interfaces
{
    public interface IPreparationStrategy
    {
        void Prepare(Drink drink);
    }
}