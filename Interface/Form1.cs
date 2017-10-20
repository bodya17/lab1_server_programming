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

        // gets data from db and puts it into datagrid
        public void Display()
        {
            using (LibraryContext context = new LibraryContext())
            {
                dataGridView1.DataSource = context.Books.ToList();
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
                book.Author = this.textBox2.Text;

                context.Books.Add(book);
                context.SaveChanges();

            }
            this.Display();
        }

        // Calling Datagridview cell click to Update and Delete  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dataGridView1.SelectedRows.Count);
            
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {
                    Console.WriteLine(row.Cells[1].Value.ToString());
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (LibraryContext context = new LibraryContext())
            {
                List<Book> bookList = new List<Book>();
                bookList = context.Books.Select(x => new Book
                {
                    Title = x.Title,
                    Author = x.Author
                }).ToList();

                dataGridView1.DataSource = bookList;
                //context.Books.Select
                int i = 0;
                //this.comboBox1.Items.Clear();
                foreach (var book in context.Books)
                {
                    i++;
                    var label = new System.Windows.Forms.Label();

                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(75, 200 + i * 15);
                    label.Size = new System.Drawing.Size(38, 13);
                   
                    label.Text = book.Author;

                    //this.author_list.Add(label);
                    //this.author_list.Controls.Add(label);
                    this.Controls.Add(label);
                    //this.PerformLayout();
                   
                    //this.comboBox1.Items.Add(book.Author);
                }   
            }
        }

        // Delete button pressed
        private void deleteFromDb(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {
                    var id = (int)row.Cells[0].Value;
                    Console.WriteLine("Book with id to delete");
                    Console.WriteLine(id);
                    using (LibraryContext context = new LibraryContext())
                    {
                        Book bookToDelete = context.Books.Where(x => x.BookId == id).Select(x => x).FirstOrDefault();
                        //context.Books.DeleteObject(bookToDelete);
                        context.Entry(bookToDelete).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }  
                }
            }
        }
    }
}
