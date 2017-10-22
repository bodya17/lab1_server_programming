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
            this.isIDAtZero = true;
            this.renderUpdateButtons = true;
            //using (LibraryContext context = new LibraryContext())
            //{
            //    Author author = new Author();
            //    author.Name = "Vasya";

            //    context.Authors.Add(author);
            //    //context.Author
            //    context.SaveChanges();
            //}
        }

        private bool isIDAtZero;
        private bool renderUpdateButtons;
        // gets data from db and puts it into datagrid
        public void Display()
        {
            using (LibraryContext context = new LibraryContext())
            {
                dataGridView1.DataSource = context.Books.ToList();
            }

            if (this.renderUpdateButtons)
            {
                dataGridView1.Columns[0].ReadOnly = true; // disable id editing

                var buttonCol = new DataGridViewButtonColumn();
                buttonCol.Name = "Update";
                buttonCol.HeaderText = "Update";
                buttonCol.Text = "Update";
                buttonCol.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Insert(3, buttonCol);
                this.renderUpdateButtons = false;
            } else
            {
                dataGridView1.Columns[1].ReadOnly = true; // disable id editing
                isIDAtZero = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Display();
        }

        private void createNewBookInDb(object sender, EventArgs e)
        {
            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = this.textBox1.Text;
                //book.Author = this.textBox2.Text;

                context.Books.Add(book);
                context.SaveChanges();

            }
            this.Display();
        }

        // Delete button pressed
        private void deleteFromDb(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {

                    int id;
                    if (this.isIDAtZero)
                    {
                        id = Convert.ToInt32(row.Cells[0].Value);
                    }
                    else
                    {
                        id = Convert.ToInt32(row.Cells[1].Value);
                    }
                    Console.WriteLine("Book with id to delete");
                    Console.WriteLine(id);
                    using (LibraryContext context = new LibraryContext())
                    {
                        Book bookToDelete = context.Books.Where(x => x.BookId == id).Select(x => x).FirstOrDefault();
                        context.Entry(bookToDelete).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                    this.Display();
                }
            }
        }

        private void updateData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int i = this.isIDAtZero ? 0 : 1;
                int id;
                if (this.isIDAtZero)
                {
                    id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                }
                var BookTitle = this.dataGridView1.Rows[e.RowIndex].Cells[i + 1].Value.ToString();
                var AuthorName = this.dataGridView1.Rows[e.RowIndex].Cells[i + 2].Value.ToString();
                

                using (LibraryContext context = new LibraryContext())
                {
                    Book bookToUpdate = context.Books.Where(x => x.BookId == id).Select(x => x).FirstOrDefault();
                    //bookToUpdate.Author = AuthorName;
                    bookToUpdate.Title = BookTitle;
                    context.Entry(bookToUpdate).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

            }

        }
    }
}
