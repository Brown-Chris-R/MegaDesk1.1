namespace MegaDesk1
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelQuote
            // 
            this.buttonCancelQuote.Location = new System.Drawing.Point(12, 12);
            this.buttonCancelQuote.Name = "buttonCancelQuote";
            this.buttonCancelQuote.Size = new System.Drawing.Size(75, 44);
            this.buttonCancelQuote.TabIndex = 0;
            this.buttonCancelQuote.Text = "Cancel Quote";
            this.buttonCancelQuote.UseVisualStyleBackColor = true;
            this.buttonCancelQuote.Click += new System.EventHandler(this.buttonCancelQuote_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(103, 12);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(113, 17);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(223, 13);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(335, 22);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(168, 47);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(48, 17);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(223, 47);
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
            this.labelDepth.Location = new System.Drawing.Point(342, 47);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(50, 17);
            this.labelDepth.TabIndex = 5;
            this.labelDepth.Text = "Depth:";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(398, 47);
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
            this.labelDrawers.Location = new System.Drawing.Point(82, 85);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(134, 17);
            this.labelDrawers.TabIndex = 7;
            this.labelDrawers.Text = "Number of Drawers:";
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(223, 85);
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
            this.labelMaterial.Location = new System.Drawing.Point(330, 85);
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
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(398, 82);
            this.comboBoxMaterial.MaxDropDownItems = 5;
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMaterial.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 253);
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
            this.Name = "AddQuote";
            this.Text = "AddQuote";
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
    }
}