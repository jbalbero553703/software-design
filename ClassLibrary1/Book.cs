namespace ClassLibrary1
{
    public class Book
    {
        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");

                _title = value;
            }
        }

        public string Author { get; set; }

        public virtual string GetInfo()
        {
            return $"Title: {Title} | Author: {Author}";
        }
    }


    public class Magazine : Book
    {
        private int _issueNumber;

        public int IssueNumber
        {
            get => _issueNumber;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Issue number cannot be negative.");

                _issueNumber = value;
            }
        }

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

    public class TextBook : Book
    {
        private string _subject;

        public string Subject
        {
            get => _subject;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Subject cannot be empty.");

                _subject = value;
            }
        }

        public override string GetInfo()
        {
            return $"Title: {Title} | Subject: {Subject} | TextBook";
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
