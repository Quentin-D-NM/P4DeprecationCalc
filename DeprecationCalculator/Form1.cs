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
            DateTime dateOut = new DateTime(year, month, day);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcValue_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
