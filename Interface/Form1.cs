using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.DataModel;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = this.textBox1.Text;
                book.Author = this.textBox2.Text;

                context.Books.Add(book);
                context.SaveChanges();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
