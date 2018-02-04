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
    public partial class AddQuote : Form
    {
        // Variables to hold form input
        string CustomerName = String.Empty;
        decimal DeskWidth = 0;
        decimal DeskDepth = 0;
        int DeskDrawers = 0;
        DesktopMaterial DesktopMaterial;
        int RushDays = 0;
        decimal DeskQuotePrice = 0;

        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            comboBoxMaterial.DataSource = DesktopMaterialList;
        }

        private void buttonCancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ResetBackColorOnFocus(object sender, EventArgs e)
        {
            // This method is for resetting the back color on the Add Quote fields that failed validation
            // Create a reference to the control.
            // NumericUpDown answerBox = sender as NumericUpDown;
            // The user input was out of range
            // answerBox.BackColor = default(Color);
        }

        private void DeskNumericValidation(object sender, CancelEventArgs e)
        {
            // This method is for validating the input on the Width, Depth and # of Drawers
            string errorMsg = "Number must be between ";

            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox.Text.Length == 0)
                return;
            try
            {
                int.TryParse(answerBox.Text, out int deskWidth);  // parse string input from text box to a number
                if (deskWidth < answerBox.Minimum || deskWidth > answerBox.Maximum)
                {
                    // Cancel the event and notify the user
                    e.Cancel = true;
                    // The user input was out of range, set visual clue by changing backcolor
                    answerBox.BackColor = Color.MistyRose;
                    // Set the error message for the error provider
                    errorMsg = errorMsg + answerBox.Minimum.ToString() + " and " + answerBox.Maximum.ToString() + ".";
                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(answerBox, errorMsg);
                }
            }
            catch
            {

            }
        }

        private void DeskNumericValidated(object sender, EventArgs e)
        {
            // Create a reference to the control.
            NumericUpDown answerBox = sender as NumericUpDown;
            // If all conditions have been met, clear the ErrorProvider of errors and reset he backcolor.
            errorProvider1.SetError(answerBox, "");
            answerBox.BackColor = default(Color);
        }

        private void DepthKeyPress(object sender, KeyPressEventArgs e)
        {
            // Restrict input to numeric characters and Backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is non-numerical.
               e.Handled = true;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetQuote_Click(object sender, EventArgs e)
        {
            DeskQuote NewQuote;
            //Get Input
            try
            {
                CustomerName = textBoxCustomerName.Text;
                DeskWidth = numericUpDownWidth.Value;
                DeskDepth = numericUpDownDepth.Value;
                DeskDrawers = (int)numericUpDownDrawers.Value;

                string Material = comboBoxMaterial.SelectedItem.ToString();
                Enum.TryParse(Material, out DesktopMaterial);

                // Rush Days is a string, convert it to an int and default to 14 if conversion fails
                string rushDays = comboBoxRushOrder.SelectedItem.ToString().Substring(0, 1);
                bool result = int.TryParse(rushDays, out RushDays);
                if (result == false)
                {
                    // String is not a number.
                    RushDays = 14;
                }

                // Create DeskQuote object
                   NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, DeskDrawers, DesktopMaterial, RushDays);
                // Calculate QuotePrice
                DeskQuotePrice = NewQuote.CalculateQuotePrice();

                try
                {
                    // Store this quote as a row of comma separated values into the quotes text file
                    string quoteRecord = NewQuote.CustomerName + ", " + NewQuote.QuoteDate + ", " + NewQuote.Desk.Width + ", " +
                        NewQuote.Desk.Depth + ", " + NewQuote.Desk.NumberOfDrawers + ", " + NewQuote.Desk.DesktopMaterial + ", " +
                        NewQuote.RushDays + ", " + DeskQuotePrice;
                    string quoteFile = @"D:\CIT 365\quotes.txt";
                    if (!File.Exists(quoteFile))
                    {
                        StreamWriter sw = File.CreateText(quoteFile);
                        sw.Close();
                    }
                    using (StreamWriter sw = File.AppendText(quoteFile))
                    {
                        sw.WriteLine(quoteRecord);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Saving Quote");
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Input methods");
                throw;
            }

            // Display the quote
            var MainMenu = (MainMenu)Tag;
            DeskQuoteView newQuoteView = new DeskQuoteView(NewQuote.CustomerName, NewQuote.QuoteDate, NewQuote.Desk.Width,
                        NewQuote.Desk.Depth, NewQuote.Desk.NumberOfDrawers, NewQuote.Desk.DesktopMaterial,
                        NewQuote.RushDays, DeskQuotePrice)
            {
                Tag = MainMenu
            };
            newQuoteView.Show();
            this.Close();
        }

    }
}
