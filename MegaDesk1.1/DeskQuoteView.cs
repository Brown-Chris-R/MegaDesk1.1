using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1dot1
{
    public partial class DeskQuoteView : Form
    {
        public DeskQuoteView(string customerName, DateTime quoteDate, decimal width, decimal depth, 
            int drawers, DesktopMaterial material, int rushDays, decimal deskQuotePrice)
        {
            InitializeComponent();

            // set display label values
            CustomerName.Text = customerName;
            QuoteDate.Text = quoteDate.ToString();
            DeskWidth.Text = width.ToString() + "\"";
            DeskDepth.Text = depth.ToString() + "\"";
            DeskDrawers.Text = drawers.ToString();
            DeskMaterial.Text = material.ToString();
            if (rushDays == 14)
            {
                RushOrderDays.Text = "Standard";
            }
            else
            {
                RushOrderDays.Text = rushDays.ToString() + " days";
            }
            QuotePrice.Text = deskQuotePrice.ToString("C");
        }

        private void DeskQuoteView_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.Tag.GetType().ToString(),"Tag Type");

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();

        }
    }
}
