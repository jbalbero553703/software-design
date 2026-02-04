using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Task2_3 : Form
    {
        public Task2_3()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"Title: {Title} | Author: {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"Title: {Title} | Issue: {IssueNumber}";
            }
        }

        public class EBook : Book
        {
            public double FileSizeMb { get; set; }

            public override string GetInfo()
            {
                return $"Title: {Title} | Ebook | File Size: {FileSizeMb} MB)";
            }
        }
        private void ProcessBooks(Book[] books)
        {
            listBox1.Items.Clear();
            foreach (Book book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book[] books =
                {
            new Book { Title = "Anyone Can Cook!", 
                Author = "Auguste Gusteau" },
            new Magazine { Title = "National Geographic", 
                IssueNumber = 67 },
            new EBook { Title = "Programming Basics with C#", 
                Author = "Dr. Svetlin Nakov", 
                FileSizeMb = 6.7 },
            new TextBook { Title = "Fundamentals of Differential Equations", 
                Subject = "Differential Equations" },
            new AudioBook { Title = "A Girl on the Train", 
                Narrator = "Paula Hawkins", 
                Duration = 167 }
        };
            ProcessBooks(books);
        }

        public class TextBook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"Title: {Title} | Subjet: {Subject} TextBook";
            }
        }
        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public int Duration { get; set; }

            public override string GetInfo()
            {
                return $"Title: {Title} | Duration: {Duration} minutes with {Narrator}";
            }
        }
    }
}
