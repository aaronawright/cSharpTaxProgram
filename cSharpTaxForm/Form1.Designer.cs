namespace cSharpTaxForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelPayPeriod = new System.Windows.Forms.Label();
            this.labelMaritalStatus = new System.Windows.Forms.Label();
            this.labelDependents = new System.Windows.Forms.Label();
            this.comboBoxPayPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.textBoxDependents = new System.Windows.Forms.TextBox();
            this.textBoxGrossPay = new System.Windows.Forms.TextBox();
            this.labelGross = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNet = new System.Windows.Forms.Label();
            this.textBoxMedicare = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResultNet = new System.Windows.Forms.TextBox();
            this.textBoxResultMedicare = new System.Windows.Forms.TextBox();
            this.textBoxSocial = new System.Windows.Forms.TextBox();
            this.textBoxResultFederal = new System.Windows.Forms.TextBox();
            this.textBoxResultGross = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Controls.Add(this.labelPayPeriod);
            this.groupBox1.Controls.Add(this.labelMaritalStatus);
            this.groupBox1.Controls.Add(this.labelDependents);
            this.groupBox1.Controls.Add(this.comboBoxPayPeriod);
            this.groupBox1.Controls.Add(this.comboBoxMaritalStatus);
            this.groupBox1.Controls.Add(this.textBoxDependents);
            this.groupBox1.Controls.Add(this.textBoxGrossPay);
            this.groupBox1.Controls.Add(this.labelGross);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter the data";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(103, 148);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(274, 23);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelPayPeriod
            // 
            this.labelPayPeriod.AutoSize = true;
            this.labelPayPeriod.Location = new System.Drawing.Point(6, 129);
            this.labelPayPeriod.Name = "labelPayPeriod";
            this.labelPayPeriod.Size = new System.Drawing.Size(58, 13);
            this.labelPayPeriod.TabIndex = 7;
            this.labelPayPeriod.Text = "Pay Period";
            // 
            // labelMaritalStatus
            // 
            this.labelMaritalStatus.AutoSize = true;
            this.labelMaritalStatus.Location = new System.Drawing.Point(6, 101);
            this.labelMaritalStatus.Name = "labelMaritalStatus";
            this.labelMaritalStatus.Size = new System.Drawing.Size(71, 13);
            this.labelMaritalStatus.TabIndex = 6;
            this.labelMaritalStatus.Text = "Marital Status";
            // 
            // labelDependents
            // 
            this.labelDependents.AutoSize = true;
            this.labelDependents.Location = new System.Drawing.Point(6, 73);
            this.labelDependents.Name = "labelDependents";
            this.labelDependents.Size = new System.Drawing.Size(65, 13);
            this.labelDependents.TabIndex = 5;
            this.labelDependents.Text = "Dependents";
            // 
            // comboBoxPayPeriod
            // 
            this.comboBoxPayPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayPeriod.FormattingEnabled = true;
            this.comboBoxPayPeriod.Items.AddRange(new object[] {
            "Biweekly",
            "Monthly"});
            this.comboBoxPayPeriod.Location = new System.Drawing.Point(103, 121);
            this.comboBoxPayPeriod.Name = "comboBoxPayPeriod";
            this.comboBoxPayPeriod.Size = new System.Drawing.Size(273, 21);
            this.comboBoxPayPeriod.TabIndex = 4;
            // 
            // comboBoxMaritalStatus
            // 
            this.comboBoxMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaritalStatus.FormattingEnabled = true;
            this.comboBoxMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.comboBoxMaritalStatus.Location = new System.Drawing.Point(103, 93);
            this.comboBoxMaritalStatus.Name = "comboBoxMaritalStatus";
            this.comboBoxMaritalStatus.Size = new System.Drawing.Size(274, 21);
            this.comboBoxMaritalStatus.TabIndex = 3;
            // 
            // textBoxDependents
            // 
            this.textBoxDependents.Location = new System.Drawing.Point(103, 66);
            this.textBoxDependents.Name = "textBoxDependents";
            this.textBoxDependents.Size = new System.Drawing.Size(275, 20);
            this.textBoxDependents.TabIndex = 2;
            this.textBoxDependents.Text = "0";
            this.textBoxDependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDependents.Leave += new System.EventHandler(this.textBoxDependents_Leave);
            // 
            // textBoxGrossPay
            // 
            this.textBoxGrossPay.Location = new System.Drawing.Point(103, 39);
            this.textBoxGrossPay.Name = "textBoxGrossPay";
            this.textBoxGrossPay.Size = new System.Drawing.Size(276, 20);
            this.textBoxGrossPay.TabIndex = 1;
            this.textBoxGrossPay.Text = "0.00";
            this.textBoxGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGrossPay.Leave += new System.EventHandler(this.textBoxGrossPay_Leave);
            // 
            // labelGross
            // 
            this.labelGross.AutoSize = true;
            this.labelGross.Location = new System.Drawing.Point(6, 46);
            this.labelGross.Name = "labelGross";
            this.labelGross.Size = new System.Drawing.Size(55, 13);
            this.labelGross.TabIndex = 0;
            this.labelGross.Text = "Gross Pay";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNet);
            this.groupBox2.Controls.Add(this.textBoxMedicare);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxResultNet);
            this.groupBox2.Controls.Add(this.textBoxResultMedicare);
            this.groupBox2.Controls.Add(this.textBoxSocial);
            this.groupBox2.Controls.Add(this.textBoxResultFederal);
            this.groupBox2.Controls.Add(this.textBoxResultGross);
            this.groupBox2.Location = new System.Drawing.Point(403, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // textBoxNet
            // 
            this.textBoxNet.AutoSize = true;
            this.textBoxNet.Location = new System.Drawing.Point(6, 155);
            this.textBoxNet.Name = "textBoxNet";
            this.textBoxNet.Size = new System.Drawing.Size(45, 13);
            this.textBoxNet.TabIndex = 13;
            this.textBoxNet.Text = "Net Pay";
            // 
            // textBoxMedicare
            // 
            this.textBoxMedicare.AutoSize = true;
            this.textBoxMedicare.Location = new System.Drawing.Point(6, 129);
            this.textBoxMedicare.Name = "textBoxMedicare";
            this.textBoxMedicare.Size = new System.Drawing.Size(72, 13);
            this.textBoxMedicare.TabIndex = 12;
            this.textBoxMedicare.Text = "Medicare Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Soc Sec Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fed Tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gross Pay";
            // 
            // textBoxResultNet
            // 
            this.textBoxResultNet.Location = new System.Drawing.Point(103, 148);
            this.textBoxResultNet.Name = "textBoxResultNet";
            this.textBoxResultNet.ReadOnly = true;
            this.textBoxResultNet.Size = new System.Drawing.Size(276, 20);
            this.textBoxResultNet.TabIndex = 9;
            this.textBoxResultNet.Text = "0.00";
            this.textBoxResultNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxResultMedicare
            // 
            this.textBoxResultMedicare.Location = new System.Drawing.Point(103, 122);
            this.textBoxResultMedicare.Name = "textBoxResultMedicare";
            this.textBoxResultMedicare.ReadOnly = true;
            this.textBoxResultMedicare.Size = new System.Drawing.Size(276, 20);
            this.textBoxResultMedicare.TabIndex = 8;
            this.textBoxResultMedicare.Text = "0.00";
            this.textBoxResultMedicare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSocial
            // 
            this.textBoxSocial.Location = new System.Drawing.Point(103, 94);
            this.textBoxSocial.Name = "textBoxSocial";
            this.textBoxSocial.ReadOnly = true;
            this.textBoxSocial.Size = new System.Drawing.Size(276, 20);
            this.textBoxSocial.TabIndex = 7;
            this.textBoxSocial.Text = "0.00";
            this.textBoxSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxResultFederal
            // 
            this.textBoxResultFederal.Location = new System.Drawing.Point(103, 66);
            this.textBoxResultFederal.Name = "textBoxResultFederal";
            this.textBoxResultFederal.ReadOnly = true;
            this.textBoxResultFederal.Size = new System.Drawing.Size(276, 20);
            this.textBoxResultFederal.TabIndex = 6;
            this.textBoxResultFederal.Text = "0.00";
            this.textBoxResultFederal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxResultGross
            // 
            this.textBoxResultGross.Location = new System.Drawing.Point(103, 39);
            this.textBoxResultGross.Name = "textBoxResultGross";
            this.textBoxResultGross.ReadOnly = true;
            this.textBoxResultGross.Size = new System.Drawing.Size(276, 20);
            this.textBoxResultGross.TabIndex = 5;
            this.textBoxResultGross.Text = "0.00";
            this.textBoxResultGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(713, 415);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tax Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelGross;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelPayPeriod;
        private System.Windows.Forms.Label labelMaritalStatus;
        private System.Windows.Forms.Label labelDependents;
        private System.Windows.Forms.ComboBox comboBoxPayPeriod;
        private System.Windows.Forms.ComboBox comboBoxMaritalStatus;
        private System.Windows.Forms.TextBox textBoxDependents;
        private System.Windows.Forms.TextBox textBoxGrossPay;
        private System.Windows.Forms.Label textBoxNet;
        private System.Windows.Forms.Label textBoxMedicare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResultNet;
        private System.Windows.Forms.TextBox textBoxResultMedicare;
        private System.Windows.Forms.TextBox textBoxSocial;
        private System.Windows.Forms.TextBox textBoxResultFederal;
        private System.Windows.Forms.TextBox textBoxResultGross;
    }
}

