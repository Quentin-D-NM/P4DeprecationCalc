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
        int startValue;
        int salvageValue;
        int lifetime;

        //class properties
        public DateTime DataAddedToInventory { get { return dateAddedToInventory; } set { dateAddedToInventory = value; } }
        public DateTime DateRemovedFromInventory { get { return dateRemovedFromInventory; } set { dateRemovedFromInventory = value; Calc(); } }
        public string Title { get { return title; } set { title = value; } }
        public double EndValue { get { return endValue; } set { endValue = value; } }
        public int StartValue { get { return startValue; } set { startValue = value; } }
        public int SalvageValue { get { return salvageValue; } set { salvageValue = value; } }
        public int LifeTime { get { return lifetime; } set { lifetime = value; } }


        protected virtual void Calc()
        {
            double annualDepExpense;
            double depRate;

            annualDepExpense = (StartValue - SalvageValue) / LifeTime;

            depRate = annualDepExpense / (StartValue - SalvageValue);

            EndValue = StartValue - (annualDepExpense * (DateRemovedFromInventory.Year - DataAddedToInventory.Year)); 

        }

        public DepreciationStraightLine(string newTitle, int newStartVal, int newSalvageVal, int newlifetime, DateTime newIn, DateTime newOut)
        {
            Title = newTitle;
            StartValue = newStartVal;
            SalvageValue = newSalvageVal;
            LifeTime = newlifetime;
            DataAddedToInventory = newIn;
            DateRemovedFromInventory = newOut;
        }

        public override string ToString()
        {
            return Title + ":Start Val $" + StartValue.ToString() + ":Salvage Val $" + SalvageValue + ":Lifetime " + " years:Date In " + DataAddedToInventory.ToString()
                + ":Date Out " + DateRemovedFromInventory.ToString();
        }


    }
}
