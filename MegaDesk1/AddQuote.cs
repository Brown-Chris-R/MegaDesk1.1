using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
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
    }
}
