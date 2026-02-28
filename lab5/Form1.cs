using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static lab5.Form1;

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
            MessageBox.Show("Book and Author added successfully!");
            LoadList();
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author)
                                        .FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully!");
            LoadList();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully!");
                    LoadList();
                }
                else
                {
                    MessageBox.Show("Book not found!");
                }
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBox.Text.ToLower();
            var filteredBooks = GetBooksWithAuthors()
                .Where(b => b.ToLower().Contains(searchTerm))
                .ToList();
            listBoxBooks.DataSource = filteredBooks;
        }
    }
}
