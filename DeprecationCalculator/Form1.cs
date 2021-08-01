using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeprecationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            int year = int.Parse(dateTimePicker1.Value.ToString("yyyy"));
            int month = int.Parse(dateTimePicker1.Value.ToString("MM"));
            int day = int.Parse(dateTimePicker1.Value.ToString("dd"));
            DateTime dateIn = new DateTime(year, month, day);

            int yearOut = int.Parse(dateTimePicker2.Value.ToString("yyyy"));
            int monthOut = int.Parse(dateTimePicker2.Value.ToString("MM"));
            int dayOut = int.Parse(dateTimePicker2.Value.ToString("dd"));
            DateTime dateOut = new DateTime(yearOut, monthOut, dayOut);

            string title = txtTitle.Text;
            int startVal = int.Parse(txtStartVal.Text);
            int salvageVal = int.Parse(txtSalvageVal.Text);
            int lifetime = int.Parse(txtLifeTime.Text);


            if(rbtnStraightLine.Checked)
            {
                DepreciationStraightLine dsl = new DepreciationStraightLine(title, startVal, salvageVal, lifetime, dateIn, dateOut);
                lboxInventory.Items.Add(dsl);
            }
            else
            {
                DeprecationDoubleDeclining ddd = new DeprecationDoubleDeclining(title, startVal, salvageVal, lifetime, dateIn, dateOut);
                lboxInventory.Items.Add(ddd);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            lboxInventory.Items.Remove(lboxInventory.SelectedItem);
        }

        private void btnCalcValue_Click(object sender, EventArgs e)
        {
            double totalValue = 0; 

            foreach(object ob in lboxInventory.Items)
            {
                try
                {
                    DeprecationDoubleDeclining ob2 = (DeprecationDoubleDeclining)ob;
                    totalValue += ob2.EndValue;
                }catch(InvalidCastException ex)
                {
                    DepreciationStraightLine ob2 = (DepreciationStraightLine)ob;
                    totalValue += ob2.EndValue;
                }
                
            }

            txtFinalvalue.Text = "The total value of your inventory is $" + totalValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
