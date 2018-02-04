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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            comboBoxMaterialSearch.DataSource = DesktopMaterialList;

        }

        private void FillSearchResults()
        {
            string Material = comboBoxMaterialSearch.SelectedItem.ToString();
            //DEBUG: MessageBox.Show(Material, "Material Search Criteria");
            listViewMaterialSearchResults.Items.Clear();

            try
            {
                // Read quotes from the quotes text file and fill the ListView control with quotes that match
                // our search criteria.
                string quoteFile = @"D:\CIT 365\quotes.txt";
                if (!File.Exists(quoteFile))
                {
                    MessageBox.Show("No quote file exists","Error searching quotes");
                }
                else
                {
                    using (StreamReader sr = new StreamReader(quoteFile))
                    {
                        string quoteRow = sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            if (quoteRow.Contains(Material))
                            {
                                //DEBUG: MessageBox.Show("Found " + quoteRow, "Search Results");
                                listViewMaterialSearchResults.Items.Add(quoteRow);
                            }
                            quoteRow = sr.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Searching Quotes");
                throw;
            }
        }
        private void buttonCancelSearchQuotes_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
        private void comboBoxMaterialSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillSearchResults();
        }
    }
}
