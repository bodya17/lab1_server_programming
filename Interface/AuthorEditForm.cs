using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class AuthorEditForm : UserControl
    {
        public AuthorEditForm(string authorName)
        {
            this.authorName = authorName;
           // this.author_name.Text = "fdssd";
            InitializeComponent();
        }
        string authorName { get; set; }

        private void save_author_btn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
