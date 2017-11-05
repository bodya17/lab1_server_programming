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
    public partial class addForm : MetroFramework.Forms.MetroForm
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (LibraryContext context = new LibraryContext())
            {
                metroGrid1.DataSource = context.Books.Select(b => new {
                    BookId = b.BookId,
                    Title = b.Title,
                    Image = b.image
                }).ToList();
            }
                
        }
    }
}
