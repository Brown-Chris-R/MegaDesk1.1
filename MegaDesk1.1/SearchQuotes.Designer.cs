namespace MegaDesk1dot1
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
            this.comboBoxMaterialSearch = new System.Windows.Forms.ComboBox();
            this.labelSearchCriteria = new System.Windows.Forms.Label();
            this.listViewMaterialSearchResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // comboBoxMaterialSearch
            // 
            this.comboBoxMaterialSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialSearch.FormattingEnabled = true;
            this.comboBoxMaterialSearch.Location = new System.Drawing.Point(360, 12);
            this.comboBoxMaterialSearch.Name = "comboBoxMaterialSearch";
            this.comboBoxMaterialSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaterialSearch.TabIndex = 2;
            this.comboBoxMaterialSearch.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaterialSearch_SelectionChangeCommitted);
            // 
            // labelSearchCriteria
            // 
            this.labelSearchCriteria.AutoSize = true;
            this.labelSearchCriteria.Location = new System.Drawing.Point(102, 15);
            this.labelSearchCriteria.Name = "labelSearchCriteria";
            this.labelSearchCriteria.Size = new System.Drawing.Size(252, 17);
            this.labelSearchCriteria.TabIndex = 3;
            this.labelSearchCriteria.Text = "Search for quotes by desktop material:";
            // 
            // listViewMaterialSearchResults
            // 
            this.listViewMaterialSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewMaterialSearchResults.GridLines = true;
            this.listViewMaterialSearchResults.Location = new System.Drawing.Point(13, 60);
            this.listViewMaterialSearchResults.Name = "listViewMaterialSearchResults";
            this.listViewMaterialSearchResults.Size = new System.Drawing.Size(468, 181);
            this.listViewMaterialSearchResults.TabIndex = 4;
            this.listViewMaterialSearchResults.UseCompatibleStateImageBehavior = false;
            this.listViewMaterialSearchResults.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quote Data";
            this.columnHeader1.Width = 465;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 253);
            this.Controls.Add(this.listViewMaterialSearchResults);
            this.Controls.Add(this.labelSearchCriteria);
            this.Controls.Add(this.comboBoxMaterialSearch);
            this.Controls.Add(this.buttonCancelSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelSearchQuotes;
        private System.Windows.Forms.ComboBox comboBoxMaterialSearch;
        private System.Windows.Forms.Label labelSearchCriteria;
        private System.Windows.Forms.ListView listViewMaterialSearchResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}