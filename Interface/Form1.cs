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

        }

        private bool isIDAtZero;
        private bool renderUpdateButtons;
        // gets data from db and puts it into datagrid
        public void Display()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var bookList = context.Books.Select(x => new { BookId = x.BookId, Title = x.Title }).ToList();
                var authorList = context.Authors.Select(x => new { AuthorId = x.AuthorId, Name = x.Name}).ToList();

                book_data_grid.DataSource = bookList;
                author_data_grid.DataSource = authorList;

                this.comboBox1.DataSource = context.Authors.Select(x => x.Name).ToList();
                

            }

            if (this.renderUpdateButtons)
            {
                //dataGridView1.Columns[0].ReadOnly = true; // disable id editing

                var buttonCol = new DataGridViewButtonColumn();
                buttonCol.Name = "Update";
                buttonCol.HeaderText = "Update";
                buttonCol.Text = "Update";
                buttonCol.UseColumnTextForButtonValue = true;

                book_data_grid.Columns.Insert(2, buttonCol);
                this.renderUpdateButtons = false;
            } else
            {
                //dataGridView1.Columns[1].ReadOnly = true; // disable id editing
                isIDAtZero = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Display();
        }

        private void createNewBookInDb(object sender, EventArgs e)
        {
            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = this.textBox1.Text;
                //book.Author = this.textBox2.Text;
                Console.WriteLine(comboBox1.Text);
                Author author = context.Authors.Where(a => a.Name == comboBox1.Text).Single();
                author.Books.Add(book);
               //book.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();

            }
            this.Display();
        }

        // Delete button pressed
        private void deleteFromDb(object sender, EventArgs e)
        {
            if (book_data_grid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in book_data_grid.SelectedRows) // foreach datagridview selected rows values  
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
                    id = Convert.ToInt32(this.book_data_grid.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    id = Convert.ToInt32(this.book_data_grid.Rows[e.RowIndex].Cells[1].Value);
                }
                var BookTitle = this.book_data_grid.Rows[e.RowIndex].Cells[i + 1].Value.ToString();
                //var AuthorName = this.dataGridView1.Rows[e.RowIndex].Cells[i + 2].Value.ToString();
                
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

        private void saveAuthorToDB(object sender, EventArgs e)
        {
            var authorName = this.author_name_text_box.Text;
            using (LibraryContext context = new LibraryContext())
            {
                Author author = new Author();
                author.Name = this.author_name_text_box.Text;
             
                context.Authors.Add(author);
                context.SaveChanges();
            }
            this.Display();

        }
    }
}
