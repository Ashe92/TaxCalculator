using TaxCalculator.Contributions;

namespace TaxCalculator.Contracts
{
    interface IContract
    {
        void obliczZaliczke(double zaliczkaNaPod, double sZdrow);
        void SetContracts();
        void AddToList(Contribution contribution);
    }
}