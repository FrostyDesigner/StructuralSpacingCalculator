using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpacingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double totalWidth = 0;
            double gapWidth = 0;
            double panelQty = 0;

            totalWidth = double.Parse(txtTotalWidth.Text);
            gapWidth = double.Parse(txtGapWidth.Text);
            panelQty = double.Parse(txtNumPanels.Text);

            double totalGapWidth = gapWidth * panelQty;

            double objectLength = (totalWidth - totalGapWidth) / panelQty;

            txtTotalGapWidth.Text = totalGapWidth.ToString();
            txtPanelWidth.Text = objectLength.ToString();

            convertInchesTofeet(objectLength);
        }

        static void convertInchesTofeet(double inches)
        {
            var result = ToFeetInches(inches);

            string feet = (result.Key.ToString());

            string remainderInches = (result.Value.ToString());

            MessageBox.Show($"Object length should be {feet}'- {remainderInches}\"");
        }

        static KeyValuePair<int, double> ToFeetInches(double inches)
        {
            return new KeyValuePair<int, double>((int)inches / 12, inches % 12);
        }
    }
}