using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.DataModel;

namespace Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = "Кобзар";
                book.Author = "Шевченко";

                context.Books.Add(book);
                context.SaveChanges();

            }
            Console.WriteLine("Done");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}