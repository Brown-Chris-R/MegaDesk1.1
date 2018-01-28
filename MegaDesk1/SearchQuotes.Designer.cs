namespace MegaDesk1
{
    partial class SearchQuotes
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
            this.buttonCancelSearchQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancelSearchQuotes
            // 
            this.buttonCancelSearchQuotes.Location = new System.Drawing.Point(12, 12);
            this.buttonCancelSearchQuotes.Name = "buttonCancelSearchQuotes";
            this.buttonCancelSearchQuotes.Size = new System.Drawing.Size(75, 25);
            this.buttonCancelSearchQuotes.TabIndex = 1;
            this.buttonCancelSearchQuotes.Text = "Cancel";
            this.buttonCancelSearchQuotes.UseVisualStyleBackColor = true;
            this.buttonCancelSearchQuotes.Click += new System.EventHandler(this.buttonCancelSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonCancelSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelSearchQuotes;
    }
}