namespace MegaDesk1dot1
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.buttonCancelQuote = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelDepth = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.numericUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxRushOrder = new System.Windows.Forms.ComboBox();
            this.labelRushOrder = new System.Windows.Forms.Label();
            this.buttonGetQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelQuote
            // 
            this.buttonCancelQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelQuote.Location = new System.Drawing.Point(15, 170);
            this.buttonCancelQuote.Name = "buttonCancelQuote";
            this.buttonCancelQuote.Size = new System.Drawing.Size(75, 44);
            this.buttonCancelQuote.TabIndex = 0;
            this.buttonCancelQuote.Text = "Cancel";
            this.buttonCancelQuote.UseVisualStyleBackColor = true;
            this.buttonCancelQuote.Click += new System.EventHandler(this.buttonCancelQuote_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(33, 14);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(113, 17);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(153, 15);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(335, 22);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(37, 51);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(109, 17);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width (24\"-96\"):";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(153, 49);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownWidth.TabIndex = 4;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownWidth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskNumericValidation);
            this.numericUpDownWidth.Validated += new System.EventHandler(this.DeskNumericValidated);
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(234, 51);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(111, 17);
            this.labelDepth.TabIndex = 5;
            this.labelDepth.Text = "Depth (12\"-48\"):";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(351, 49);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownDepth.TabIndex = 6;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthKeyPress);
            this.numericUpDownDepth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskNumericValidation);
            this.numericUpDownDepth.Validated += new System.EventHandler(this.DeskNumericValidated);
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Location = new System.Drawing.Point(12, 87);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(134, 17);
            this.labelDrawers.TabIndex = 7;
            this.labelDrawers.Text = "Number of Drawers:";
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(153, 87);
            this.numericUpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDrawers.Name = "numericUpDownDrawers";
            this.numericUpDownDrawers.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownDrawers.TabIndex = 8;
            this.numericUpDownDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.DeskNumericValidation);
            this.numericUpDownDrawers.Validated += new System.EventHandler(this.DeskNumericValidated);
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(283, 87);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(62, 17);
            this.labelMaterial.TabIndex = 9;
            this.labelMaterial.Text = "Material:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxMaterial.Location = new System.Drawing.Point(351, 86);
            this.comboBoxMaterial.MaxDropDownItems = 5;
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(137, 24);
            this.comboBoxMaterial.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBoxRushOrder
            // 
            this.comboBoxRushOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRushOrder.FormattingEnabled = true;
            this.comboBoxRushOrder.Items.AddRange(new object[] {
            "Standard",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.comboBoxRushOrder.Location = new System.Drawing.Point(153, 124);
            this.comboBoxRushOrder.Name = "comboBoxRushOrder";
            this.comboBoxRushOrder.Size = new System.Drawing.Size(75, 24);
            this.comboBoxRushOrder.TabIndex = 11;
            // 
            // labelRushOrder
            // 
            this.labelRushOrder.AutoSize = true;
            this.labelRushOrder.Location = new System.Drawing.Point(60, 127);
            this.labelRushOrder.Name = "labelRushOrder";
            this.labelRushOrder.Size = new System.Drawing.Size(86, 17);
            this.labelRushOrder.TabIndex = 12;
            this.labelRushOrder.Text = "Rush Order:";
            // 
            // buttonGetQuote
            // 
            this.buttonGetQuote.Location = new System.Drawing.Point(153, 170);
            this.buttonGetQuote.Name = "buttonGetQuote";
            this.buttonGetQuote.Size = new System.Drawing.Size(335, 44);
            this.buttonGetQuote.TabIndex = 13;
            this.buttonGetQuote.Text = "Quote this desk";
            this.buttonGetQuote.UseVisualStyleBackColor = true;
            this.buttonGetQuote.Click += new System.EventHandler(this.buttonGetQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelQuote;
            this.ClientSize = new System.Drawing.Size(509, 253);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGetQuote);
            this.Controls.Add(this.labelRushOrder);
            this.Controls.Add(this.comboBoxRushOrder);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.numericUpDownDrawers);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.numericUpDownDepth);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.buttonCancelQuote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelQuote;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawers;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelRushOrder;
        private System.Windows.Forms.ComboBox comboBoxRushOrder;
        private System.Windows.Forms.Button buttonGetQuote;
    }
}