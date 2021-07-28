using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeprecationCalculator
{
    class DepreciationStraightLine
    {
        //class Fields
        DateTime dateAddedToInventory;
        DateTime dateRemovedFromInventory;
        string title;
        double endValue;
        double startValue;
        double salvageValue;
        int lifetime;

        //class properties
        DateTime DataAddedToInventory { get; set; }
        DateTime DateRemovedFromInventory { get; set; }
        string Title { get; set; }
        double EndValue { get; set; }
        double StartValue { get; set; }
        double SalvageValue { get; set; }
        int LifeTime { get; set; }


        protected virtual void Calc()
        {

        }

        private void StraightLineDepreciation()
        {

        }

        public override string ToString()
        {
            return "";
        }


    }
}
