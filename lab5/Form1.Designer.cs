namespace lab5
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new Krypton.Toolkit.KryptonTextBox();
            txtBookTitle = new Krypton.Toolkit.KryptonTextBox();
            btnAddBook = new Krypton.Toolkit.KryptonButton();
            listBoxBooks = new Krypton.Toolkit.KryptonListBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnShowBooks = new Krypton.Toolkit.KryptonButton();
            groupBox1 = new GroupBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            txtSearchBox = new Krypton.Toolkit.KryptonTextBox();
            btnDeleteBook = new Krypton.Toolkit.KryptonButton();
            btnUpdateBook = new Krypton.Toolkit.KryptonButton();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtBookID = new Krypton.Toolkit.KryptonTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(41, 193);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(220, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(41, 260);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(220, 23);
            txtBookTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(41, 329);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 25);
            btnAddBook.TabIndex = 4;
            btnAddBook.Values.DropDownArrowColor = Color.Empty;
            btnAddBook.Values.Text = "Add Book";
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Location = new Point(318, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(463, 426);
            listBoxBooks.TabIndex = 9;
            listBoxBooks.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(41, 162);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(90, 25);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Author:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(41, 229);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(90, 25);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.TabStop = false;
            kryptonLabel2.Values.Text = "Book:";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(41, 360);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(100, 25);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Values.DropDownArrowColor = Color.Empty;
            btnShowBooks.Values.Text = "Show Books";
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kryptonLabel4);
            groupBox1.Controls.Add(txtSearchBox);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(kryptonLabel1);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(btnShowBooks);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(kryptonLabel3);
            groupBox1.Controls.Add(kryptonLabel2);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 426);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Book";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(41, 42);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(90, 25);
            kryptonLabel4.TabIndex = 8;
            kryptonLabel4.TabStop = false;
            kryptonLabel4.Values.Text = "Search Book:";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(41, 73);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(220, 23);
            txtSearchBox.TabIndex = 0;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(161, 360);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(100, 25);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Values.DropDownArrowColor = Color.Empty;
            btnDeleteBook.Values.Text = "Delete Book";
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(161, 329);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(100, 25);
            btnUpdateBook.TabIndex = 5;
            btnUpdateBook.Values.DropDownArrowColor = Color.Empty;
            btnUpdateBook.Values.Text = "Update Book";
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(41, 102);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(90, 25);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Book ID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(41, 133);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(220, 23);
            txtBookID.TabIndex = 1;
            // 
            // Form1
            // 
            AcceptButton = btnAddBook;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtAuthorName;
        private Krypton.Toolkit.KryptonTextBox txtBookTitle;
        private Krypton.Toolkit.KryptonButton btnAddBook;
        private Krypton.Toolkit.KryptonListBox listBoxBooks;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnShowBooks;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonButton btnUpdateBook;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtBookID;
        private Krypton.Toolkit.KryptonButton btnDeleteBook;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtSearchBox;
    }
}
