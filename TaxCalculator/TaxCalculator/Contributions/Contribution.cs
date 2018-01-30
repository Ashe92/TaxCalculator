using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Contributions
{
    public  class Contribution
    {
        public string _id;
        private string _nameContribution;
        private double _valuePercent;
        private double _result;
        private double _basicAmount;
        public Contribution(string id,string name, double value, double basic)
        {
            this._id = id;
            this._nameContribution = name;
            this._valuePercent = value;
            this._basicAmount = basic;
            _result = Count();
        }

        public double Value
        {
            get
            {
                return _valuePercent;
            }

            set
            {
                this._valuePercent = value;
            }
        }

        public double Result
        {
            get
            {
                return Math.Round(_result,2); 
            }
        }

        public double Count()
        {
            _result = (_basicAmount * _valuePercent) / 100;
            return Result;
        } 

        public string ShowText()
        {
            return _id + " " + _nameContribution +" "+ _valuePercent.ToString() +": "+ _result.ToString();
        }
    }
}
