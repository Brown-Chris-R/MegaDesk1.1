namespace MegaDesk1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonAddQuote = new System.Windows.Forms.Button();
            this.buttonViewQuotes = new System.Windows.Forms.Button();
            this.buttonSearchQuotes = new System.Windows.Forms.Button();
            this.buttonExitMainMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddQuote
            // 
            this.buttonAddQuote.Location = new System.Drawing.Point(16, 62);
            this.buttonAddQuote.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddQuote.Name = "buttonAddQuote";
            this.buttonAddQuote.Size = new System.Drawing.Size(133, 37);
            this.buttonAddQuote.TabIndex = 0;
            this.buttonAddQuote.Text = "Add New Quote";
            this.buttonAddQuote.UseVisualStyleBackColor = true;
            this.buttonAddQuote.Click += new System.EventHandler(this.buttonAddQuote_Click);
            // 
            // buttonViewQuotes
            // 
            this.buttonViewQuotes.Location = new System.Drawing.Point(16, 123);
            this.buttonViewQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewQuotes.Name = "buttonViewQuotes";
            this.buttonViewQuotes.Size = new System.Drawing.Size(133, 37);
            this.buttonViewQuotes.TabIndex = 1;
            this.buttonViewQuotes.Text = "View Quotes";
            this.buttonViewQuotes.UseVisualStyleBackColor = true;
            this.buttonViewQuotes.Click += new System.EventHandler(this.buttonViewQuotes_Click);
            // 
            // buttonSearchQuotes
            // 
            this.buttonSearchQuotes.Location = new System.Drawing.Point(16, 185);
            this.buttonSearchQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchQuotes.Name = "buttonSearchQuotes";
            this.buttonSearchQuotes.Size = new System.Drawing.Size(133, 37);
            this.buttonSearchQuotes.TabIndex = 2;
            this.buttonSearchQuotes.Text = "Search Quotes";
            this.buttonSearchQuotes.UseVisualStyleBackColor = true;
            this.buttonSearchQuotes.Click += new System.EventHandler(this.buttonSearchQuotes_Click);
            // 
            // buttonExitMainMenu
            // 
            this.buttonExitMainMenu.Location = new System.Drawing.Point(16, 246);
            this.buttonExitMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitMainMenu.Name = "buttonExitMainMenu";
            this.buttonExitMainMenu.Size = new System.Drawing.Size(133, 37);
            this.buttonExitMainMenu.TabIndex = 3;
            this.buttonExitMainMenu.Text = "Exit";
            this.buttonExitMainMenu.UseVisualStyleBackColor = true;
            this.buttonExitMainMenu.Click += new System.EventHandler(this.buttonExitMainMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExitMainMenu);
            this.Controls.Add(this.buttonSearchQuotes);
            this.Controls.Add(this.buttonViewQuotes);
            this.Controls.Add(this.buttonAddQuote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Mega Desk 1.0";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddQuote;
        private System.Windows.Forms.Button buttonViewQuotes;
        private System.Windows.Forms.Button buttonSearchQuotes;
        private System.Windows.Forms.Button buttonExitMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

