namespace MegaDesk1dot1
{
    partial class ViewAllQuotes
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
            this.buttonCancelViewAllQuotes = new System.Windows.Forms.Button();
            this.listViewAllQuotes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonCancelViewAllQuotes
            // 
            this.buttonCancelViewAllQuotes.Location = new System.Drawing.Point(12, 12);
            this.buttonCancelViewAllQuotes.Name = "buttonCancelViewAllQuotes";
            this.buttonCancelViewAllQuotes.Size = new System.Drawing.Size(75, 25);
            this.buttonCancelViewAllQuotes.TabIndex = 0;
            this.buttonCancelViewAllQuotes.Text = "Cancel";
            this.buttonCancelViewAllQuotes.UseVisualStyleBackColor = true;
            this.buttonCancelViewAllQuotes.Click += new System.EventHandler(this.buttonCancelViewAllQuotes_Click);
            // 
            // listViewAllQuotes
            // 
            this.listViewAllQuotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewAllQuotes.Location = new System.Drawing.Point(12, 43);
            this.listViewAllQuotes.Name = "listViewAllQuotes";
            this.listViewAllQuotes.Size = new System.Drawing.Size(468, 198);
            this.listViewAllQuotes.TabIndex = 1;
            this.listViewAllQuotes.UseCompatibleStateImageBehavior = false;
            this.listViewAllQuotes.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quote Data";
            this.columnHeader1.Width = 465;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 253);
            this.Controls.Add(this.listViewAllQuotes);
            this.Controls.Add(this.buttonCancelViewAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelViewAllQuotes;
        private System.Windows.Forms.ListView listViewAllQuotes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}