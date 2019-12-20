using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBill_Calc
{
    public partial class ElectricityBillCalculator : Form
    {
        public ElectricityBillCalculator()
        {
            InitializeComponent();
        }

        double varPeak, varOffPeak, temp, exp1, exp2;

        private void offPeakHourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (residentialRadioButton.Checked || commercialRadioButton.Checked)
            {
                offPeakHourTextBox.Clear();
            }
        }

        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void inputHours()
        {
            varPeak = Convert.ToDouble(peakHourTextBox.Text);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (residentialRadioButton.Checked)
            {
                inputHours();
                temp = ((0.053 * varPeak) + (0.053 * varOffPeak) + 10);
                resultTextBox.Text = Convert.ToString(temp);
            }

            if (commercialRadioButton.Checked)
            {
                inputHours();
                temp = 50;
                if (varPeak>800)
                {
                    temp = 50 + (varPeak - 800) * 0.042;
                }

                resultTextBox.Text = Convert.ToString(temp);
            }
            if (industrialRadioButton.Checked)
            {
                varPeak = Convert.ToDouble(peakHourTextBox.Text);
                varOffPeak = Convert.ToDouble(offPeakHourTextBox.Text);
                exp1 = 70; exp2 = 35;
                temp = exp1 + exp2;
                if (varPeak > 800)
                {
                    exp1= 70 + (varPeak-800)*0.0620;
                }else if (varOffPeak > 800)
                {
                    exp2 = 35 + (varOffPeak - 800)*0.025;
                }

                temp = exp1 + exp2;
                resultTextBox.Text = Convert.ToString(temp);
            }
        }
    }
}
