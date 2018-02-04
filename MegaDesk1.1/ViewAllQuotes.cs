using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1dot1
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void buttonCancelViewAllQuotes_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            listViewAllQuotes.Items.Clear();

            try
            {
                // Read quotes from the quotes text file and fill the ListView control with all quotes
                string quoteFile = @"D:\CIT 365\quotes.txt";
                if (!File.Exists(quoteFile))
                {
                    MessageBox.Show("No quote file exists", "Error searching quotes");
                }
                else
                {
                    using (StreamReader sr = new StreamReader(quoteFile))
                    {
                        string quoteRow = sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            //DEBUG: MessageBox.Show("Found " + quoteRow, "Search Results");
                            listViewAllQuotes.Items.Add(quoteRow);
                            quoteRow = sr.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Saving Quote");
                throw;
            }

        }
    }
}
