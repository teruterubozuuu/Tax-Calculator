using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Diagnostics.Tracing;

namespace Tax_Due_Calculator
{
    public partial class TaxDue : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        int num;
        public TaxDue()
        {
            InitializeComponent();
           

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SetValueForText1 = txtFullName.Text;
            SetValueForText2 = txtTIN.Text;
            SetValueForText3 = txtGrossIncome.Text;
            SetValueForText4 = txtCivilStatus.Text;
            SetValueForText5 = txtDependents.Text;

            if (int.TryParse(txtDependents.Text, out num))
            {

                if (num > 4)
                {
                    MessageBox.Show("Invalid no. of dependents");
                    txtDependents.Clear();
                }
                else if (num <=4 && (txtCivilStatus.Text.Equals("Head of the family", StringComparison.OrdinalIgnoreCase)) || (txtCivilStatus.Text.Equals("Married", StringComparison.OrdinalIgnoreCase)) && (txtFullName.TextLength > 0 && txtCivilStatus.TextLength > 0 && txtTIN.TextLength > 0 && txtGrossIncome.TextLength > 0))
                {
                    new Summary().Show();
                    this.Hide();
                }
                else if (txtFullName.TextLength == 0 || txtCivilStatus.TextLength == 0 || txtTIN.TextLength == 0 || txtGrossIncome.TextLength == 0 )
                {
                     MessageBox.Show("Please enter all missing information.");
  
                }

            }

            if (txtCivilStatus.Text.Equals("Single", StringComparison.OrdinalIgnoreCase) && (txtFullName.TextLength > 0 && txtCivilStatus.TextLength > 0 && txtTIN.TextLength > 0 && txtGrossIncome.TextLength > 0))
            {
                new Summary().Show();
                this.Hide();
            }


        }

        private void TaxDue_Load(object sender, EventArgs e)
        {
            this.AcceptButton = submitButton;
            

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDependents_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtCivilStatus_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCivilStatus.Text))
            {
                txtDependents.Enabled = true;
                txtDependents.BackColor = Color.White;

            }
            else if ((txtCivilStatus.Text.Equals("Single", StringComparison.OrdinalIgnoreCase)))
            {
                txtDependents.Enabled = false;
                txtDependents.BackColor= Color.Lavender;

            }
            else if ((txtCivilStatus.Text.Equals("Head of the family", StringComparison.OrdinalIgnoreCase)) || (txtCivilStatus.Text.Equals("Married", StringComparison.OrdinalIgnoreCase)))
            {
                txtDependents.Enabled = true;
                
            }
        }

        private void txtTIN_TextChanged_1(object sender, EventArgs e)
        {
            txtTIN.MaxLength = 9;

        }

        private void txtTIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtGrossIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDependents_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtCivilStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
           
            
        }
    }
}
