namespace DeprecationCalculator
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
            this.tctrMain = new System.Windows.Forms.TabControl();
            this.tabHowTo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHowTo = new System.Windows.Forms.TextBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.gboxDepreciationType = new System.Windows.Forms.GroupBox();
            this.rbtnStraightLine = new System.Windows.Forms.RadioButton();
            this.rbtnDoubleDeclining = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLifeTime = new System.Windows.Forms.TextBox();
            this.txtSalvageVal = new System.Windows.Forms.TextBox();
            this.txtStartVal = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDateOutInventory = new System.Windows.Forms.Label();
            this.lblDateInInventory = new System.Windows.Forms.Label();
            this.lblLifetime = new System.Windows.Forms.Label();
            this.lblSalvageVal = new System.Windows.Forms.Label();
            this.lblStartVal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lboxInventory = new System.Windows.Forms.ListBox();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.txtFinalvalue = new System.Windows.Forms.TextBox();
            this.btnCalcValue = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.tctrMain.SuspendLayout();
            this.tabHowTo.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.gboxDepreciationType.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrMain
            // 
            this.tctrMain.Controls.Add(this.tabHowTo);
            this.tctrMain.Controls.Add(this.tabInventory);
            this.tctrMain.Controls.Add(this.tabSummary);
            this.tctrMain.Location = new System.Drawing.Point(12, 12);
            this.tctrMain.Name = "tctrMain";
            this.tctrMain.SelectedIndex = 0;
            this.tctrMain.Size = new System.Drawing.Size(573, 426);
            this.tctrMain.TabIndex = 0;
            // 
            // tabHowTo
            // 
            this.tabHowTo.Controls.Add(this.label1);
            this.tabHowTo.Controls.Add(this.txtHowTo);
            this.tabHowTo.Location = new System.Drawing.Point(4, 22);
            this.tabHowTo.Name = "tabHowTo";
            this.tabHowTo.Padding = new System.Windows.Forms.Padding(3);
            this.tabHowTo.Size = new System.Drawing.Size(565, 400);
            this.tabHowTo.TabIndex = 0;
            this.tabHowTo.Text = "How to use this application";
            this.tabHowTo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Super Depreciation Calculator 3000";
            // 
            // txtHowTo
            // 
            this.txtHowTo.Location = new System.Drawing.Point(60, 46);
            this.txtHowTo.Multiline = true;
            this.txtHowTo.Name = "txtHowTo";
            this.txtHowTo.ReadOnly = true;
            this.txtHowTo.Size = new System.Drawing.Size(434, 71);
            this.txtHowTo.TabIndex = 0;
            this.txtHowTo.Text = "Welcome to Super Depreciation Calculator 3000. Enter your inventory in the invent" +
    "ory tab. Then go to the summary tab to find the value of your inventory.";
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnRemoveSelected);
            this.tabInventory.Controls.Add(this.btnAddInventory);
            this.tabInventory.Controls.Add(this.gboxDepreciationType);
            this.tabInventory.Controls.Add(this.dateTimePicker2);
            this.tabInventory.Controls.Add(this.dateTimePicker1);
            this.tabInventory.Controls.Add(this.txtLifeTime);
            this.tabInventory.Controls.Add(this.txtSalvageVal);
            this.tabInventory.Controls.Add(this.txtStartVal);
            this.tabInventory.Controls.Add(this.txtTitle);
            this.tabInventory.Controls.Add(this.lblDateOutInventory);
            this.tabInventory.Controls.Add(this.lblDateInInventory);
            this.tabInventory.Controls.Add(this.lblLifetime);
            this.tabInventory.Controls.Add(this.lblSalvageVal);
            this.tabInventory.Controls.Add(this.lblStartVal);
            this.tabInventory.Controls.Add(this.lblTitle);
            this.tabInventory.Controls.Add(this.lboxInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(565, 400);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(60, 354);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(133, 32);
            this.btnRemoveSelected.TabIndex = 17;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(334, 284);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(133, 32);
            this.btnAddInventory.TabIndex = 16;
            this.btnAddInventory.Text = "Add to Inventory";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // gboxDepreciationType
            // 
            this.gboxDepreciationType.Controls.Add(this.rbtnStraightLine);
            this.gboxDepreciationType.Controls.Add(this.rbtnDoubleDeclining);
            this.gboxDepreciationType.Location = new System.Drawing.Point(334, 197);
            this.gboxDepreciationType.Name = "gboxDepreciationType";
            this.gboxDepreciationType.Size = new System.Drawing.Size(133, 81);
            this.gboxDepreciationType.TabIndex = 15;
            this.gboxDepreciationType.TabStop = false;
            this.gboxDepreciationType.Text = "Depreciation Type";
            // 
            // rbtnStraightLine
            // 
            this.rbtnStraightLine.AutoSize = true;
            this.rbtnStraightLine.Location = new System.Drawing.Point(6, 19);
            this.rbtnStraightLine.Name = "rbtnStraightLine";
            this.rbtnStraightLine.Size = new System.Drawing.Size(84, 17);
            this.rbtnStraightLine.TabIndex = 13;
            this.rbtnStraightLine.TabStop = true;
            this.rbtnStraightLine.Text = "Straight Line";
            this.rbtnStraightLine.UseVisualStyleBackColor = true;
            // 
            // rbtnDoubleDeclining
            // 
            this.rbtnDoubleDeclining.AutoSize = true;
            this.rbtnDoubleDeclining.Location = new System.Drawing.Point(6, 42);
            this.rbtnDoubleDeclining.Name = "rbtnDoubleDeclining";
            this.rbtnDoubleDeclining.Size = new System.Drawing.Size(106, 17);
            this.rbtnDoubleDeclining.TabIndex = 14;
            this.rbtnDoubleDeclining.TabStop = true;
            this.rbtnDoubleDeclining.Text = "Double Declining";
            this.rbtnDoubleDeclining.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(376, 171);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(376, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtLifeTime
            // 
            this.txtLifeTime.Location = new System.Drawing.Point(376, 105);
            this.txtLifeTime.Name = "txtLifeTime";
            this.txtLifeTime.Size = new System.Drawing.Size(183, 20);
            this.txtLifeTime.TabIndex = 10;
            // 
            // txtSalvageVal
            // 
            this.txtSalvageVal.Location = new System.Drawing.Point(376, 77);
            this.txtSalvageVal.Name = "txtSalvageVal";
            this.txtSalvageVal.Size = new System.Drawing.Size(183, 20);
            this.txtSalvageVal.TabIndex = 9;
            // 
            // txtStartVal
            // 
            this.txtStartVal.Location = new System.Drawing.Point(376, 49);
            this.txtStartVal.Name = "txtStartVal";
            this.txtStartVal.Size = new System.Drawing.Size(183, 20);
            this.txtStartVal.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(376, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(183, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // lblDateOutInventory
            // 
            this.lblDateOutInventory.AutoSize = true;
            this.lblDateOutInventory.Location = new System.Drawing.Point(248, 177);
            this.lblDateOutInventory.Name = "lblDateOutInventory";
            this.lblDateOutInventory.Size = new System.Drawing.Size(109, 13);
            this.lblDateOutInventory.TabIndex = 6;
            this.lblDateOutInventory.Text = "Date Out of Inventory";
            // 
            // lblDateInInventory
            // 
            this.lblDateInInventory.AutoSize = true;
            this.lblDateInInventory.Location = new System.Drawing.Point(248, 141);
            this.lblDateInInventory.Name = "lblDateInInventory";
            this.lblDateInInventory.Size = new System.Drawing.Size(89, 13);
            this.lblDateInInventory.TabIndex = 5;
            this.lblDateInInventory.Text = "Date In Inventory";
            // 
            // lblLifetime
            // 
            this.lblLifetime.AutoSize = true;
            this.lblLifetime.Location = new System.Drawing.Point(248, 108);
            this.lblLifetime.Name = "lblLifetime";
            this.lblLifetime.Size = new System.Drawing.Size(77, 13);
            this.lblLifetime.TabIndex = 4;
            this.lblLifetime.Text = "Lifetime (years)";
            // 
            // lblSalvageVal
            // 
            this.lblSalvageVal.AutoSize = true;
            this.lblSalvageVal.Location = new System.Drawing.Point(248, 80);
            this.lblSalvageVal.Name = "lblSalvageVal";
            this.lblSalvageVal.Size = new System.Drawing.Size(85, 13);
            this.lblSalvageVal.TabIndex = 3;
            this.lblSalvageVal.Text = "Salvage Value $";
            // 
            // lblStartVal
            // 
            this.lblStartVal.AutoSize = true;
            this.lblStartVal.Location = new System.Drawing.Point(248, 52);
            this.lblStartVal.Name = "lblStartVal";
            this.lblStartVal.Size = new System.Drawing.Size(82, 13);
            this.lblStartVal.TabIndex = 2;
            this.lblStartVal.Text = "Starting Value $";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(248, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lboxInventory
            // 
            this.lboxInventory.FormattingEnabled = true;
            this.lboxInventory.Location = new System.Drawing.Point(6, 6);
            this.lboxInventory.Name = "lboxInventory";
            this.lboxInventory.Size = new System.Drawing.Size(236, 342);
            this.lboxInventory.TabIndex = 0;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.txtFinalvalue);
            this.tabSummary.Controls.Add(this.btnCalcValue);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(565, 400);
            this.tabSummary.TabIndex = 2;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // txtFinalvalue
            // 
            this.txtFinalvalue.Location = new System.Drawing.Point(6, 99);
            this.txtFinalvalue.Multiline = true;
            this.txtFinalvalue.Name = "txtFinalvalue";
            this.txtFinalvalue.ReadOnly = true;
            this.txtFinalvalue.Size = new System.Drawing.Size(553, 67);
            this.txtFinalvalue.TabIndex = 1;
            this.txtFinalvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcValue
            // 
            this.btnCalcValue.Location = new System.Drawing.Point(181, 54);
            this.btnCalcValue.Name = "btnCalcValue";
            this.btnCalcValue.Size = new System.Drawing.Size(216, 23);
            this.btnCalcValue.TabIndex = 0;
            this.btnCalcValue.Text = "Calculate Inventory Value";
            this.btnCalcValue.UseVisualStyleBackColor = true;
            this.btnCalcValue.Click += new System.EventHandler(this.btnCalcValue_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.tctrMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tctrMain.ResumeLayout(false);
            this.tabHowTo.ResumeLayout(false);
            this.tabHowTo.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.gboxDepreciationType.ResumeLayout(false);
            this.gboxDepreciationType.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrMain;
        private System.Windows.Forms.TabPage tabHowTo;
        private System.Windows.Forms.TextBox txtHowTo;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.GroupBox gboxDepreciationType;
        private System.Windows.Forms.RadioButton rbtnStraightLine;
        private System.Windows.Forms.RadioButton rbtnDoubleDeclining;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtLifeTime;
        private System.Windows.Forms.TextBox txtSalvageVal;
        private System.Windows.Forms.TextBox txtStartVal;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDateOutInventory;
        private System.Windows.Forms.Label lblDateInInventory;
        private System.Windows.Forms.Label lblLifetime;
        private System.Windows.Forms.Label lblSalvageVal;
        private System.Windows.Forms.Label lblStartVal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lboxInventory;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TextBox txtFinalvalue;
        private System.Windows.Forms.Button btnCalcValue;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

