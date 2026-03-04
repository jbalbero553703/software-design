namespace lab6
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtBookId = new TextBox();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnAddBook = new Button();
            label2 = new Label();
            label1 = new Label();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(btnFetchBooks);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(40, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 165);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Book ID:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(75, 183);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(200, 23);
            txtBookId.TabIndex = 8;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(178, 293);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(85, 25);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.AutoSize = true;
            btnUpdateBook.Location = new Point(178, 249);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(85, 25);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.AutoSize = true;
            btnAddBook.Location = new Point(87, 249);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(85, 25);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Book:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 43);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Author:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(75, 116);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(200, 23);
            txtBookTitle.TabIndex = 2;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(75, 61);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(200, 23);
            txtAuthorName.TabIndex = 1;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.AutoSize = true;
            btnFetchBooks.Location = new Point(87, 293);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(85, 25);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Dock = DockStyle.Right;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(410, 40);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(350, 370);
            listBoxBooks.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxBooks);
            Controls.Add(groupBox1);
            Name = "Form1";
            Padding = new Padding(40);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Label label2;
        private Label label1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Label label3;
        private TextBox txtBookId;
    }
}
