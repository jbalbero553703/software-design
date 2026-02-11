using ClassLibrary1;

namespace TestProject1
{
    public class BookstoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //////////////////////////////////////////// Task 1 ////////////////////////////////////////////
        [Test]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.That(book.Title, Is.EqualTo("C# Programming"));
            Assert.That(book.Author, Is.EqualTo("John Smith"));
        }

        [Test]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", IssueNumber = 12 };
            Assert.That(magazine.Title, Is.EqualTo("Tech Weekly"));
            Assert.That(magazine.IssueNumber, Is.EqualTo(12));
        }

        [TestFixture]
        public class PolymorphismTests
        {
            [Test]
            public void TestPolymorphism_GetInfo_Method()
            {
                Book[] books = new Book[]
                {
                    new Book { Title = "C# Programming", Author = "John Smith" },
                    new Magazine { Title = "Tech Weekly", IssueNumber = 12 },
                    new EBook { Title = "Learn C#", FileSizeMb = 5 },
                };

                Assert.That(books[0].GetInfo(), Is.EqualTo("Title: C# Programming | Author: John Smith"));
                Assert.That(books[1].GetInfo(), Is.EqualTo("Title: Tech Weekly | Issue: 12"));
                Assert.That(books[2].GetInfo(), Is.EqualTo("Title: Learn C# | Ebook | File Size: 5 MB)"));
            }


            //////////////////////////////////////////// Task 2 ////////////////////////////////////////////
            [Test]
            public void TestInvalidMagazineCreation()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = -1 };
                });
            }


            ///////////////////////////////////////// Task 3 Part 1 /////////////////////////////////////////
            [Test]
            public void TestBookEmptyTitle()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Book book = new Book { Title = "", Author = "John Smith" };
                });
            }

            [Test]
            public void TestMagazineNegativeIN()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Magazine magazine = new Magazine
                    {
                        Title = "Tech Weekly",
                        IssueNumber = -5
                    };
                });
            }


            ///////////////////////////////////////// Task 3 Part 2 /////////////////////////////////////////
            [Test]
            public void TestTextBookWithEmptySubject()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    TextBook textBook = new TextBook
                    {
                        Title = "Physics 101",
                        Subject = ""
                    };
                });
            }

        }
    }
}
