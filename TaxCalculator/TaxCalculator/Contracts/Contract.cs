using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Contracts;
using TaxCalculator.Contributions;

namespace TaxCalculator.Contracts
{
    public abstract class Contract : IContract
    {
        private string _id;
        private double _basicAmount=0; //  podstawa
        private double _earnedAmount =0; // koszty uzyskania
        private double _decreasedAmount =0; // kwota zmniejszajaca
        private double _vatDecreased=0; // podatek 
        private double _advancedValue=0; //zaliczka US
        private double _tempBaseValue=0;
        private double _result=0;
        private List<Contribution> _listContributions =  new List<Contribution>();

        public Contract(string id,double basic,double earned, double decrased)
        {
            _id = id;
            _basicAmount = basic;
            EarnedAmount = earned;
            DecreasedAmount = decrased;
            SetContracts();
        }
        public double TempBaseValue
        {
            get
            {
                return _tempBaseValue;
            }

            set
            {
                _tempBaseValue = value;
            }
        }
        public double BasicAmount
        {
            get
            {
                return _basicAmount;
            }
        }

        public double DecreasedAmount
        {
            get
            {
                return _decreasedAmount;
            }

            set
            {
                _decreasedAmount = value;
            }
        }

        public double EarnedAmount
        {
            get
            {
                return _earnedAmount;
            }

            set
            {
                _earnedAmount = value;
            }
        }

        public double VatDecreased
        {
            get
            {
                return _vatDecreased;
            }

            set
            {
                _vatDecreased = value;
            }
        }

        public double AdvancedValue
        {
            get
            {
                return _advancedValue;
            }

            set
            {
                _advancedValue = value;
            }
        }

        public double Result
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
            }
        }

        public List<Contribution> ListC
        {
            get
            {
                return _listContributions;
            }

            set
            {
                _listContributions = value;
            }
        }

        public  abstract void SetContracts();

        public void AddToList(Contribution contribution)
        {
            _listContributions.Add(contribution);
        }
        public void obliczZaliczke(double zaliczkaNaPod, double zdrowMal)
        {
            AdvancedValue = zaliczkaNaPod - zdrowMal - DecreasedAmount;
        }
    }
}
