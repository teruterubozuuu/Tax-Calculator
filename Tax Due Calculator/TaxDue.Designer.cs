using System;

namespace Tax_Due_Calculator
{
    partial class TaxDue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrossIncome = new System.Windows.Forms.TextBox();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(473, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "TaxDue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tax_Due_Calculator.Properties.Resources.tax;
            this.pictureBox1.Location = new System.Drawing.Point(410, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(284, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(284, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter TIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(284, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Gross Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(284, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Civil Status (Single/Married/Head Of The Family)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(284, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter No. of Dependents (Maximum of 4)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtGrossIncome
            // 
            this.txtGrossIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrossIncome.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossIncome.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtGrossIncome.Location = new System.Drawing.Point(288, 319);
            this.txtGrossIncome.Name = "txtGrossIncome";
            this.txtGrossIncome.Size = new System.Drawing.Size(421, 20);
            this.txtGrossIncome.TabIndex = 7;
            this.txtGrossIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossIncome_KeyPress);
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCivilStatus.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCivilStatus.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtCivilStatus.Location = new System.Drawing.Point(288, 403);
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.Size = new System.Drawing.Size(421, 20);
            this.txtCivilStatus.TabIndex = 8;
            this.txtCivilStatus.TextChanged += new System.EventHandler(this.txtCivilStatus_TextChanged);
            this.txtCivilStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCivilStatus_KeyPress);
            // 
            // txtDependents
            // 
            this.txtDependents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDependents.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependents.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtDependents.Location = new System.Drawing.Point(288, 488);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(421, 20);
            this.txtDependents.TabIndex = 9;
            this.txtDependents.TextChanged += new System.EventHandler(this.txtDependents_TextChanged);
            this.txtDependents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDependents_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightCoral;
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Snow;
            this.submitButton.Location = new System.Drawing.Point(433, 560);
            this.submitButton.Margin = new System.Windows.Forms.Padding(0);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(119, 31);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // txtTIN
            // 
            this.txtTIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTIN.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIN.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtTIN.Location = new System.Drawing.Point(288, 239);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(421, 20);
            this.txtTIN.TabIndex = 11;
            this.txtTIN.TextChanged += new System.EventHandler(this.txtTIN_TextChanged_1);
            this.txtTIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTIN_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(288, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 2);
            this.panel1.TabIndex = 13;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtFullName.Location = new System.Drawing.Point(288, 160);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(421, 20);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.ForeColor = System.Drawing.Color.SlateBlue;
            this.panel2.Location = new System.Drawing.Point(288, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 2);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.ForeColor = System.Drawing.Color.SlateBlue;
            this.panel3.Location = new System.Drawing.Point(288, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.ForeColor = System.Drawing.Color.SlateBlue;
            this.panel4.Location = new System.Drawing.Point(288, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 2);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.ForeColor = System.Drawing.Color.SlateBlue;
            this.panel5.Location = new System.Drawing.Point(288, 513);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 2);
            this.panel5.TabIndex = 16;
            // 
            // TaxDue
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 706);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTIN);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.txtDependents);
            this.Controls.Add(this.txtCivilStatus);
            this.Controls.Add(this.txtGrossIncome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.Name = "TaxDue";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TaxDue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtTIN_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrossIncome;
        private System.Windows.Forms.TextBox txtCivilStatus;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

