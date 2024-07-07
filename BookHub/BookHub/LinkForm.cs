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
    public partial class LinkForm : Form
    {
        public LinkForm(Book book)
        {
            InitializeComponent();
            linkLabel1.Text = book.Title;
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, book.ImageURL);
        }

        private void LinkForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
