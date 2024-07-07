using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub
{
    public partial class BuyForm : Form
    {
        public Book Book { get; set; }
        public BuyForm(Book book)
        {
            InitializeComponent();
            this.Book = book;
            btnBuy.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //намалување на количината на соодветната книга
            if (tbName.Text.Length > 0 && tbAddress.Text.Length > 0 && tbNumber.Text.Length > 0 && tbQuantity.Text.Length > 0)
            {
                if (Book.Quantity >= Convert.ToInt32(tbQuantity.Text))
                {
                    Book.Quantity -= Convert.ToInt32(tbQuantity.Text);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Thank you for your purchase.\nSee you next time.");
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Not enough books.\nQuantity: " + Book.Quantity + ".\nPlease add different value for quantity.");
                }
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            btnBuy.Enabled = true;
        }
    }
}