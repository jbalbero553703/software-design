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
            btnShowBooks = new Krypton.Toolkit.KryptonButton();
            groupBox1 = new GroupBox();
            txtSearchBox = new Krypton.Toolkit.KryptonTextBox();
            btnDeleteBook = new Krypton.Toolkit.KryptonButton();
            btnUpdateBook = new Krypton.Toolkit.KryptonButton();
            txtBookID = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSearchBox);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(btnShowBooks);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 426);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Book";
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
            // txtBookID
            // 
            txtBookID.Location = new Point(41, 133);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(220, 23);
            txtBookID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(41, 55);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 8;
            label1.Text = "Search Book:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(41, 115);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Book ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(41, 175);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(41, 242);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "Book Title:";
            // 
            // Form1
            // 
            AcceptButton = btnAddBook;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 164, 153);
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
        private Krypton.Toolkit.KryptonButton btnShowBooks;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonButton btnUpdateBook;
        private Krypton.Toolkit.KryptonTextBox txtBookID;
        private Krypton.Toolkit.KryptonButton btnDeleteBook;
        private Krypton.Toolkit.KryptonTextBox txtSearchBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
