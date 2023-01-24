using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Tax_Due_Calculator
{
    public partial class Summary : Form
    {
        int pdeductionAmount = 50000;
        int dependentsAmount = 25000;
        int gross;
        int num;

        public Summary()
        {
            InitializeComponent();
        
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            outputName.Text = TaxDue.SetValueForText1;
            outputTIN.Text = TaxDue.SetValueForText2;
            outputGross.Text = "Php " + TaxDue.SetValueForText3;
            outputCivilStatus.Text = TaxDue.SetValueForText4;
            outputDependents.Text = TaxDue.SetValueForText5;
            if (outputCivilStatus.Text.Equals("Single", StringComparison.OrdinalIgnoreCase))
            {
                outputDependents.Text = "0";

            }

            personalDeduction.Text = "Php " + pdeductionAmount.ToString();
            additionalExemption.Text = "Php " + (int.Parse(outputDependents.Text) * dependentsAmount).ToString();
            totalExemption.Text = "Php " + (int.Parse(outputDependents.Text) * dependentsAmount + pdeductionAmount).ToString();
            
            bool success = int.TryParse(outputGross.Text.Substring(3), out gross);
            if (success)
            {
                taxableIncome.Text = "Php " + (gross - (int.Parse(outputDependents.Text) * dependentsAmount + pdeductionAmount)).ToString();
            }
            else
            {
                Console.WriteLine("outputGross.Text is not a valid number");
            }

            bool result = int.TryParse(taxableIncome.Text.Substring(3), out num);
            if (result)
            {
               if (num < 250000)
                {
                    taxDue.Text = "Php 0";
                }
               else if (num >= 250000 && num <= 400000)
                {
                    taxDue.Text = "Php " + ((num-250000)*0.15).ToString();
                }
                else if (num >= 400000 && num < 800000)
                {
                    taxDue.Text = "Php " + ((22500+(num - 400000)) * 0.20).ToString();
                }
                else if (num >= 800000 && num < 2000000)
                {
                    taxDue.Text = "Php " + ((102500 + (num - 800000)) * 0.25).ToString();
                }
                else if (num >= 2000000 && num < 5000000)
                {
                    taxDue.Text = "Php " + ((402500 + (num - 2000000)) * 0.30).ToString();
                }
                else if (num >= 5000000)
                {
                    taxDue.Text = "Php " + ((1302500 + (num - 5000000)) * 0.35).ToString();
                }


            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TaxDue().Show();
            this.Hide();
        }
    }
}
