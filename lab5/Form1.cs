using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.BookId} - {b.Author.Name} by {b.Title}")
                    .ToList();

                return booksWithAuthors;
            }
        }

        public void LoadList()
        {
            var booksWithAuthors = GetBooksWithAuthors();
            listBoxBooks.DataSource = booksWithAuthors;
        }

        public void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookName = txtBookTitle.Text;
            string authorName = txtAuthorName.Text;
            AddAuthorWithBook(authorName, bookName);
            LoadList();
        }

        public void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookId == bookId);

                if (book == null)
                    return;

                if (book.Author == null && book.AuthorId != 0)
                {
                    book.Author = context.Authors.Find(book.AuthorId);
                }

                book.Title = newTitle;
                if (book.Author != null)
                {
                    book.Author.Name = newAuthorName;
                }

                context.SaveChanges();
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully!");
            LoadList();
        }
    }
}
