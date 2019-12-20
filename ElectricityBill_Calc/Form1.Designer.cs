namespace ElectricityBill_Calc
{
    partial class ElectricityBillCalculator
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
            this.conTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.industrialRadioButton = new System.Windows.Forms.RadioButton();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.KWHgroupBox = new System.Windows.Forms.GroupBox();
            this.offPeakHourTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.peakHourTextBox = new System.Windows.Forms.TextBox();
            this.peakHourLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.conTypeGroupBox.SuspendLayout();
            this.KWHgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // conTypeGroupBox
            // 
            this.conTypeGroupBox.Controls.Add(this.industrialRadioButton);
            this.conTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.conTypeGroupBox.Controls.Add(this.residentialRadioButton);
            this.conTypeGroupBox.Location = new System.Drawing.Point(48, 83);
            this.conTypeGroupBox.Name = "conTypeGroupBox";
            this.conTypeGroupBox.Size = new System.Drawing.Size(304, 240);
            this.conTypeGroupBox.TabIndex = 0;
            this.conTypeGroupBox.TabStop = false;
            this.conTypeGroupBox.Text = "Connection Type";
            // 
            // industrialRadioButton
            // 
            this.industrialRadioButton.AutoSize = true;
            this.industrialRadioButton.Location = new System.Drawing.Point(32, 95);
            this.industrialRadioButton.Name = "industrialRadioButton";
            this.industrialRadioButton.Size = new System.Drawing.Size(67, 17);
            this.industrialRadioButton.TabIndex = 2;
            this.industrialRadioButton.TabStop = true;
            this.industrialRadioButton.Text = "Industrial";
            this.industrialRadioButton.UseVisualStyleBackColor = true;
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(32, 71);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(79, 17);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.TabStop = true;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(32, 47);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(77, 17);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // KWHgroupBox
            // 
            this.KWHgroupBox.Controls.Add(this.offPeakHourTextBox);
            this.KWHgroupBox.Controls.Add(this.label2);
            this.KWHgroupBox.Controls.Add(this.peakHourTextBox);
            this.KWHgroupBox.Controls.Add(this.peakHourLabel);
            this.KWHgroupBox.Location = new System.Drawing.Point(423, 83);
            this.KWHgroupBox.Name = "KWHgroupBox";
            this.KWHgroupBox.Size = new System.Drawing.Size(317, 240);
            this.KWHgroupBox.TabIndex = 1;
            this.KWHgroupBox.TabStop = false;
            this.KWHgroupBox.Text = "KWH Used";
            // 
            // offPeakHourTextBox
            // 
            this.offPeakHourTextBox.Location = new System.Drawing.Point(133, 95);
            this.offPeakHourTextBox.Name = "offPeakHourTextBox";
            this.offPeakHourTextBox.Size = new System.Drawing.Size(148, 20);
            this.offPeakHourTextBox.TabIndex = 2;
            this.offPeakHourTextBox.TextChanged += new System.EventHandler(this.offPeakHourTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Off Peak Hours:";
            // 
            // peakHourTextBox
            // 
            this.peakHourTextBox.Location = new System.Drawing.Point(133, 58);
            this.peakHourTextBox.Name = "peakHourTextBox";
            this.peakHourTextBox.Size = new System.Drawing.Size(148, 20);
            this.peakHourTextBox.TabIndex = 2;
            // 
            // peakHourLabel
            // 
            this.peakHourLabel.AutoSize = true;
            this.peakHourLabel.Location = new System.Drawing.Point(47, 62);
            this.peakHourLabel.Name = "peakHourLabel";
            this.peakHourLabel.Size = new System.Drawing.Size(66, 13);
            this.peakHourLabel.TabIndex = 3;
            this.peakHourLabel.Text = "Peak Hours:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(302, 369);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(177, 20);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Location = new System.Drawing.Point(222, 373);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(75, 13);
            this.totalBillLabel.TabIndex = 3;
            this.totalBillLabel.Text = "Total Bill (Tk): ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculateBtn.Location = new System.Drawing.Point(485, 368);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Calculate Bill";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // ElectricityBillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 471);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalBillLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.KWHgroupBox);
            this.Controls.Add(this.conTypeGroupBox);
            this.Name = "ElectricityBillCalculator";
            this.Text = "Electricity Bill Calculator";
            this.conTypeGroupBox.ResumeLayout(false);
            this.conTypeGroupBox.PerformLayout();
            this.KWHgroupBox.ResumeLayout(false);
            this.KWHgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox conTypeGroupBox;
        private System.Windows.Forms.GroupBox KWHgroupBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RadioButton industrialRadioButton;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.TextBox offPeakHourTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox peakHourTextBox;
        private System.Windows.Forms.Label peakHourLabel;
    }
}

