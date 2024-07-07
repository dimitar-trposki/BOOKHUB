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
            //додавање на линк кон сликата во формата
            linkLabel1.Text = book.Title;
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, book.ImageURL);
        }

        //акција при клик на линкот
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
