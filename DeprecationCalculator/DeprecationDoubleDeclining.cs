using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeprecationCalculator
{
    class DeprecationDoubleDeclining : DepreciationStraightLine
    {
        public DeprecationDoubleDeclining(string newTitle, int newStartVal, int newSalvageVal, int newlifetime, DateTime newIn, DateTime newOut) :
            base(newTitle, newStartVal, newSalvageVal, newlifetime, newIn, newOut)
        {
            
        }

        protected override void Calc()
        {
            double annualDepExpense;
            double depRate;

            annualDepExpense = (StartValue - SalvageValue) / LifeTime;

            depRate = annualDepExpense / (StartValue - SalvageValue);

            EndValue = StartValue;

            for(int i = 0; i < (DateRemovedFromInventory.Year - DataAddedToInventory.Year); i++ )
            {
                EndValue -= depRate * EndValue;
            }
        }

        public override string ToString()
        {
            return Title + ":Start Val $" + StartValue.ToString() + ":Salvage Val $" + SalvageValue + ":Lifetime " + " years:Date In " + DataAddedToInventory.ToString() 
                + ":Date Out " + DateRemovedFromInventory.ToString();
        }
    }
}
