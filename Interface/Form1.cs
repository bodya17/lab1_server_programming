using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Interface.DataModel;
using System.Data.Entity;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

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
        private string SEPARATOR = " / ";

        private byte[] openFile()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Image for book";
            theDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            theDialog.InitialDirectory = @"C:\";
            byte[] data = null;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.FileName;
                FileInfo fileInfo = new FileInfo(path);

                data = new byte[fileInfo.Length];

                using (FileStream fs = fileInfo.OpenRead())
                {
                    fs.Read(data, 0, data.Length);
                }
            }
            return data;
        }


        public void Display()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var bookList = context.Books.Select(x => new {
                    BookId = x.BookId,
                    Title = x.Title,
                    Authors = x.Authors.Select(a => a.Name).ToList()
                }).ToList().Select(x => new {
                    BookId = x.BookId,
                    Title = x.Title,
                    Authors = String.Join(this.SEPARATOR, x.Authors)
                }).ToList();

                var authorList = context.Authors.Select(x => new {
                    AuthorId = x.AuthorId,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Books = x.Books.Select(b => b.Title).ToList()
                }).ToList().Select(x => new {
                    AuthorId = x.AuthorId,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Books = String.Join(this.SEPARATOR, x.Books)
                }).ToList();

                book_data_grid.DataSource = bookList;
                author_data_grid.DataSource = authorList;

                this.authors_list.SelectionMode = SelectionMode.MultiSimple;
                this.authors_list.DataSource = context.Authors.Select(x => x.Name).ToList();
            }

            if (this.renderUpdateButtons)
            {
                var buttonCol = new DataGridViewButtonColumn();
                buttonCol.Name = "ShowImage";
                buttonCol.HeaderText = "Image";
                buttonCol.Text = "Show image";
                buttonCol.UseColumnTextForButtonValue = true;
                book_data_grid.Columns.Add(buttonCol);
                this.renderUpdateButtons = false;
            } else
            {
                isIDAtZero = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Display();
        }

        private void createNewBookInDb(object sender, EventArgs e)
        {
            var imageData = this.openFile();
            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = this.book_name_text_box.Text;
                if (imageData == null) {
                    string fileName = "book.jpg";
                    string path = Path.Combine(Environment.CurrentDirectory, fileName);
                    Console.WriteLine(path);
                    byte[] DEFAULT_IMAGE = System.IO.File.ReadAllBytes(path);
                    book.image = DEFAULT_IMAGE;
                } else {
                    book.image = imageData;
                }
                
                foreach (var item in authors_list.SelectedItems)
                {
                    Author author = context.Authors.Where(a => a.Name == item.ToString()).Single();
                    author.Books.Add(book);
                }
                context.Books.Add(book);
                context.SaveChanges();

            }
            this.Display();
        }

        private void deleteBookFromDb(object sender, EventArgs e)
        {
            if (book_data_grid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in book_data_grid.SelectedRows)
                {
                    int id = this.isIDAtZero
                        ? Convert.ToInt32(row.Cells[0].Value)
                        : Convert.ToInt32(row.Cells[1].Value);

                    using (LibraryContext context = new LibraryContext())
                    {
                        Book bookToDelete = context.Books.Where(x => x.BookId == id).Select(x => x).FirstOrDefault();
                        context.Entry(bookToDelete).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                }
                this.Display();
            }
        }

        private void showImage(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                using (Form form = new MetroFramework.Forms.MetroForm())
                {
                    using (LibraryContext context = new LibraryContext())
                    {
                       
                        Bitmap bmp;
                        using (var ms = new MemoryStream(context.Books.ToList()[e.RowIndex].image))
                        {
                            bmp = new Bitmap(ms);
                            form.StartPosition = FormStartPosition.CenterScreen;
                            form.Size = bmp.Size;

                            PictureBox pb = new PictureBox();
                            pb.Dock = DockStyle.Fill;
                            pb.Image = bmp;

                            form.Controls.Add(pb);
                            form.ShowDialog();
                        }
                    }
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
                author.City = this.city_text_box.Text;
                author.Age = Convert.ToInt32(this.age_text_box.Text);
                context.Authors.Add(author);
                context.SaveChanges();
            }
            author_name_text_box.Text = "";
            city_text_box.Text = "";
            age_text_box.Text = "";
            this.Display();
        }

        private void delete_author_btn_Click(object sender, EventArgs e)
        {
            if (author_data_grid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in author_data_grid.SelectedRows) // foreach datagridview selected rows values  
                {
                    var id = Convert.ToInt32(row.Cells[0].Value);
                    
                    using (LibraryContext context = new LibraryContext())
                    {
                        Author authorToDelete = context.Authors.Where(x => x.AuthorId == id).Select(x => x).FirstOrDefault();
                        context.Entry(authorToDelete).State = EntityState.Deleted;
                        context.SaveChanges();
                    }
                }
                this.Display();
            }
        }

        // https://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void edit_book_btn_Click(object sender, EventArgs e)
        {
            const int IMAGE_HEIGHT = 100;
            const int IMAGE_WIDTH = 100;
            var rowIndex = book_data_grid.CurrentCell.RowIndex;

            int i = this.isIDAtZero ? 0 : 1;
            int bookId = this.isIDAtZero
                ? Convert.ToInt32(book_data_grid.Rows[rowIndex].Cells[0].Value)
                : Convert.ToInt32(book_data_grid.Rows[rowIndex].Cells[1].Value);

            var bookTitle = book_data_grid.Rows[rowIndex].Cells[i+1].Value.ToString();
            var authors = book_data_grid.Rows[rowIndex].Cells[i+2].Value.ToString();
            byte[] booksImage = null;

            using (var form = new MetroFramework.Forms.MetroForm())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = new Size(600, 450);
                form.Font = new Font("Century Gothic", 9.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                TextBox title_text_box = new TextBox();
                title_text_box.Text = bookTitle;
                title_text_box.Location = new Point(200, 50);

                Label title = new Label();
                title.Text = "Title: ";
                title.Location = new Point(100, 50);

                Label authorsLabel = new Label();
                authorsLabel.Text = "Authors: ";
                authorsLabel.Location = new Point(100, 100);

                ListBox authors_list = new ListBox();

                authors_list.SelectionMode = SelectionMode.MultiSimple;
                authors_list.Location = new Point(200, 100);

                PictureBox pb = new PictureBox();
                using (LibraryContext context = new LibraryContext())
                {
                    Bitmap bmp;
                    using (var ms = new MemoryStream(context.Books.Where(book => book.BookId == bookId).First().image))
                    {
                        bmp = new Bitmap(ms);
                        pb.Size = new Size(IMAGE_WIDTH, IMAGE_HEIGHT);
                        pb.Location = new Point(200, 200);
                        pb.Image = ResizeImage(bmp, IMAGE_WIDTH, IMAGE_HEIGHT);
                    }

                    var allAUTHORS = context.Authors.Select(x => x.Name).ToList();
                    var authorsList = context.Books.Where(book => book.BookId == bookId).First().Authors.ToList();
                    authors_list.DataSource = allAUTHORS;
                    form.Load += new EventHandler(delegate (object s, EventArgs args)
                    {
                        authors_list.SetSelected(0, false);
                        foreach (var author in authorsList)
                        {
                            var indx = allAUTHORS.FindIndex(h => h == author.Name);
                            authors_list.SetSelected(indx, true);
                        }
                       
                    });
                        
                }
  
                Button saveBtn = new Button();
                saveBtn.Text = "Save changes";
                saveBtn.Location = new Point(200, 330);
                saveBtn.Click += new EventHandler(delegate (object s, EventArgs args) {
                    using (LibraryContext context = new LibraryContext())
                    {
                        Book bookToUpdate = context.Books.Where(x => x.BookId == bookId).Select(x => x).FirstOrDefault();
                        bookToUpdate.Title = title_text_box.Text;
                        
                        bookToUpdate.Authors.Clear();
                       
                        foreach (var item in authors_list.SelectedItems)
                        {
                            Author author = context.Authors.Where(a => a.Name == item.ToString()).Single();
                            bookToUpdate.Authors.Add(author);
                        }
                        if (booksImage != null) {
                            bookToUpdate.image = booksImage;
                        }
                            
                        context.SaveChanges();
                    }
                    this.Display();
                    form.Close();
                    Console.WriteLine("Save");
                });

                Button changeImageBtn = new Button();
                changeImageBtn.Text = "Change Image";
                changeImageBtn.Location = new Point(320, 250);
                changeImageBtn.Click += new EventHandler(delegate (object s, EventArgs args) {
                    
                    booksImage = openFile();
                    if (booksImage != null) {
                        using (var ms = new MemoryStream(booksImage))
                        {
                            pb.Image = ResizeImage(Image.FromStream(ms), IMAGE_WIDTH, IMAGE_HEIGHT);
                        }
                    }
                    
                });

                Button discardBtn = new Button();
                discardBtn.Text = "Discard changes";
                discardBtn.Location = new Point(300, 330);
                discardBtn.Click += new EventHandler(delegate (object s, EventArgs args) {
                    form.Close();
                });

                form.Controls.Add(title);
                form.Controls.Add(authorsLabel);
                form.Controls.Add(title_text_box);
                form.Controls.Add(authors_list);
                form.Controls.Add(saveBtn);
                form.Controls.Add(discardBtn);
                form.Controls.Add(pb);
                form.Controls.Add(changeImageBtn);
                
                form.ShowDialog();
            }
        }

        private void edit_author_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("edit author btn clicked");
            var editAuthorForm = new AuthorEditForm();
            //editAuthorForm.Load += new EventHandler(delegate (object s, EventArgs args)
            //{

            //});

            using (var form = new MetroFramework.Forms.MetroForm())
            {
                editAuthorForm.Controls["author_name"].Text = author_data_grid.SelectedRows[0].Cells[1].Value.ToString();
                editAuthorForm.Controls["city_text_box"].Text = author_data_grid.SelectedRows[0].Cells[3].Value.ToString();
                editAuthorForm.Controls["age_text_box"].Text = author_data_grid.SelectedRows[0].Cells[2].Value.ToString();

                int id = Convert.ToInt32(author_data_grid.SelectedRows[0].Cells[0].Value);

                form.Size = new Size(800, 500);
                form.Controls.Add(editAuthorForm);
                var l = (ListBox)form.Controls[0].Controls["books_list"];

                form.Load += new EventHandler(delegate (object s, EventArgs args)
                {
                    using (LibraryContext context = new LibraryContext())
                    {
                        var allBooksTitles = context.Books.Select(b => b.Title).ToList();
                        l.DataSource = allBooksTitles;
                        Author authorToEdit = context.Authors.Where(author => author.AuthorId == id).First();
                        l.SetSelected(0, false);
                        foreach (var book in authorToEdit.Books.ToList())
                        {
                            var indx = allBooksTitles.FindIndex(h => h == book.Title);
                            l.SetSelected(indx, true);
                        }

                    }

                });
                

                form.Controls[0].Controls["save_author_btn"].Click += new EventHandler(delegate (object s, EventArgs args)
                {
                    using (LibraryContext context = new LibraryContext())
                    {                        
                        var allBooks = context.Books.Select(book => book.Title).ToList();
                        var authorId = Convert.ToInt32(author_data_grid.SelectedRows[0].Cells[0].Value);
                        Author authorToUpdate = context.Authors.Where(x => x.AuthorId == authorId).Select(x => x).FirstOrDefault();
                        authorToUpdate.Name = form.Controls[0].Controls["author_name"].Text;
                        authorToUpdate.City = form.Controls[0].Controls["city_text_box"].Text;
                        authorToUpdate.Age = Convert.ToInt32(form.Controls[0].Controls["age_text_box"].Text);
                        authorToUpdate.Books.Clear();
                        foreach (var item in l.SelectedItems)
                        {
                            Book book = context.Books.Where(b => b.Title == item.ToString()).Single();
                            authorToUpdate.Books.Add(book);
                        }
                        context.SaveChanges();
                    }
                    this.Display();
                    form.Close();

                });
                
                form.ShowDialog();
            }
        }
    }
}
