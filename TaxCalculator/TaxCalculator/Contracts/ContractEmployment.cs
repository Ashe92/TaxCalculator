using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Contributions;
using TaxCalculator.StaticVariables;

namespace TaxCalculator.Contracts
{
    public class ContractEmployment : Contract
    {
        public ContractEmployment(string id, double basic, double earned, double decrased) : base(id, basic, earned, decrased)
        {
        }

        public override void SetContracts()
        {
            Contribution eme = new Contribution("EME", "Składka na ubezpieczenie emerytalne", StaticValues.EMERYTALNE, BasicAmount);
            Contribution ren = new Contribution("REN", "Składka na ubezpieczenie rentowe", StaticValues.RENTOWE, BasicAmount);
            Contribution cho = new Contribution("CHO", "Składka na ubezpieczenie chorobowe", StaticValues.CHOROBOWE, BasicAmount);
            TempBaseValue = BasicAmount - eme.Result + ren.Result + cho.Result;
            Contribution zdrWlk = new Contribution("ZDROW_WLK", "Składka na ubezpieczenie zdworotne od podstawy wymiaru", StaticValues.ZDROWOTLE_WLK, TempBaseValue);//with temp
            Contribution zdrMal = new Contribution("ZDROW_MAL", "Składka na ubezpieczenie zdworotne od podstawy wymiaru", StaticValues.ZDROWOTNE_MAL, TempBaseValue);// with temp
            TempBaseValue = TempBaseValue - EarnedAmount;
            Contribution zalPod = (new Contribution("ZAL_POD", "Zaliczka na podatek", StaticValues.ZAL_PODAT, TempBaseValue));// with temp
            VatDecreased = zalPod.Result - DecreasedAmount;
            obliczZaliczke(zalPod.Result, zdrMal.Result);
            Result = BasicAmount - ((eme.Result + ren.Result + cho.Result) + zdrWlk.Result + zalPod.Result);

            AddingAllToList(eme, ren, cho, zdrWlk, zdrMal, zalPod);
        }

        public void AddingAllToList(Contribution eme, Contribution ren, Contribution cho, Contribution zdrWlk, Contribution zdrMal, Contribution zalPod)
        {
            AddToList(eme);
            AddToList(ren);
            AddToList(cho);
            AddToList(zdrWlk);
            AddToList(zdrMal);
            AddToList(zalPod);
        }
    }
}
