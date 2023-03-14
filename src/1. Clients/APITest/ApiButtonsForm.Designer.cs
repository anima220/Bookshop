namespace APITest
{
    partial class ApiButtonsForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetAllField = new System.Windows.Forms.RichTextBox();
            this.GetBooksButton = new System.Windows.Forms.Button();
            this.GetGenresButton = new System.Windows.Forms.Button();
            this.GetPublishersButton = new System.Windows.Forms.Button();
            this.GetAuthorsButton = new System.Windows.Forms.Button();
            this.CreateBook = new System.Windows.Forms.Button();
            this.CreateGenreButton = new System.Windows.Forms.Button();
            this.CreateAuthorButton = new System.Windows.Forms.Button();
            this.CreatePublisherButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.DeleteAuthorButton = new System.Windows.Forms.Button();
            this.DeleteGenreButton = new System.Windows.Forms.Button();
            this.DeletePublisherButton = new System.Windows.Forms.Button();
            this.deleteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.deleteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAllField
            // 
            this.GetAllField.Location = new System.Drawing.Point(377, 12);
            this.GetAllField.Name = "GetAllField";
            this.GetAllField.Size = new System.Drawing.Size(411, 426);
            this.GetAllField.TabIndex = 1;
            this.GetAllField.Text = "";
            // 
            // GetBooksButton
            // 
            this.GetBooksButton.Location = new System.Drawing.Point(12, 38);
            this.GetBooksButton.Name = "GetBooksButton";
            this.GetBooksButton.Size = new System.Drawing.Size(102, 23);
            this.GetBooksButton.TabIndex = 2;
            this.GetBooksButton.Text = "GetBooks";
            this.GetBooksButton.UseVisualStyleBackColor = true;
            this.GetBooksButton.Click += new System.EventHandler(this.GetBooksButton_Click);
            // 
            // GetGenresButton
            // 
            this.GetGenresButton.Location = new System.Drawing.Point(267, 38);
            this.GetGenresButton.Name = "GetGenresButton";
            this.GetGenresButton.Size = new System.Drawing.Size(104, 23);
            this.GetGenresButton.TabIndex = 3;
            this.GetGenresButton.Text = "GetGenres";
            this.GetGenresButton.UseVisualStyleBackColor = true;
            this.GetGenresButton.Click += new System.EventHandler(this.GetGenresButton_Click);
            // 
            // GetPublishersButton
            // 
            this.GetPublishersButton.Location = new System.Drawing.Point(12, 93);
            this.GetPublishersButton.Name = "GetPublishersButton";
            this.GetPublishersButton.Size = new System.Drawing.Size(112, 23);
            this.GetPublishersButton.TabIndex = 4;
            this.GetPublishersButton.Text = "GetPublishers";
            this.GetPublishersButton.UseVisualStyleBackColor = true;
            this.GetPublishersButton.Click += new System.EventHandler(this.GetPublishersButton_Click);
            // 
            // GetAuthorsButton
            // 
            this.GetAuthorsButton.Location = new System.Drawing.Point(137, 38);
            this.GetAuthorsButton.Name = "GetAuthorsButton";
            this.GetAuthorsButton.Size = new System.Drawing.Size(102, 23);
            this.GetAuthorsButton.TabIndex = 5;
            this.GetAuthorsButton.Text = "GetAuthors";
            this.GetAuthorsButton.UseVisualStyleBackColor = true;
            this.GetAuthorsButton.Click += new System.EventHandler(this.GetAuthorsButton_Click);
            // 
            // CreateBook
            // 
            this.CreateBook.Location = new System.Drawing.Point(12, 147);
            this.CreateBook.Name = "CreateBook";
            this.CreateBook.Size = new System.Drawing.Size(104, 23);
            this.CreateBook.TabIndex = 6;
            this.CreateBook.Text = "CreateBook";
            this.CreateBook.UseVisualStyleBackColor = true;
            this.CreateBook.Click += new System.EventHandler(this.CreateBook_Click);
            // 
            // CreateGenreButton
            // 
            this.CreateGenreButton.Location = new System.Drawing.Point(259, 147);
            this.CreateGenreButton.Name = "CreateGenreButton";
            this.CreateGenreButton.Size = new System.Drawing.Size(112, 23);
            this.CreateGenreButton.TabIndex = 7;
            this.CreateGenreButton.Text = "CreateGenre";
            this.CreateGenreButton.UseVisualStyleBackColor = true;
            this.CreateGenreButton.Click += new System.EventHandler(this.CreateGenreButton_Click);
            // 
            // CreateAuthorButton
            // 
            this.CreateAuthorButton.Location = new System.Drawing.Point(137, 147);
            this.CreateAuthorButton.Name = "CreateAuthorButton";
            this.CreateAuthorButton.Size = new System.Drawing.Size(116, 23);
            this.CreateAuthorButton.TabIndex = 8;
            this.CreateAuthorButton.Text = "CreateAuthor";
            this.CreateAuthorButton.UseVisualStyleBackColor = true;
            this.CreateAuthorButton.Click += new System.EventHandler(this.CreateAuthorButton_Click);
            // 
            // CreatePublisherButton
            // 
            this.CreatePublisherButton.Location = new System.Drawing.Point(12, 211);
            this.CreatePublisherButton.Name = "CreatePublisherButton";
            this.CreatePublisherButton.Size = new System.Drawing.Size(119, 23);
            this.CreatePublisherButton.TabIndex = 9;
            this.CreatePublisherButton.Text = "CreatePublisher";
            this.CreatePublisherButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Delete Id:";
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Location = new System.Drawing.Point(10, 342);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(104, 23);
            this.DeleteBookButton.TabIndex = 13;
            this.DeleteBookButton.Text = "DeleteBook";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // DeleteAuthorButton
            // 
            this.DeleteAuthorButton.Location = new System.Drawing.Point(120, 342);
            this.DeleteAuthorButton.Name = "DeleteAuthorButton";
            this.DeleteAuthorButton.Size = new System.Drawing.Size(116, 23);
            this.DeleteAuthorButton.TabIndex = 14;
            this.DeleteAuthorButton.Text = "DeleteAuthor";
            this.DeleteAuthorButton.UseVisualStyleBackColor = true;
            this.DeleteAuthorButton.Click += new System.EventHandler(this.DeleteAuthorButton_Click);
            // 
            // DeleteGenreButton
            // 
            this.DeleteGenreButton.Location = new System.Drawing.Point(242, 342);
            this.DeleteGenreButton.Name = "DeleteGenreButton";
            this.DeleteGenreButton.Size = new System.Drawing.Size(112, 23);
            this.DeleteGenreButton.TabIndex = 15;
            this.DeleteGenreButton.Text = "DeleteGenre";
            this.DeleteGenreButton.UseVisualStyleBackColor = true;
            this.DeleteGenreButton.Click += new System.EventHandler(this.DeleteGenreButton_Click);
            // 
            // DeletePublisherButton
            // 
            this.DeletePublisherButton.Location = new System.Drawing.Point(10, 385);
            this.DeletePublisherButton.Name = "DeletePublisherButton";
            this.DeletePublisherButton.Size = new System.Drawing.Size(121, 23);
            this.DeletePublisherButton.TabIndex = 16;
            this.DeletePublisherButton.Text = "DeletePublisher";
            this.DeletePublisherButton.UseVisualStyleBackColor = true;
            // 
            // deleteNumericUpDown
            // 
            this.deleteNumericUpDown.Location = new System.Drawing.Point(86, 300);
            this.deleteNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.deleteNumericUpDown.Name = "deleteNumericUpDown";
            this.deleteNumericUpDown.Size = new System.Drawing.Size(167, 22);
            this.deleteNumericUpDown.TabIndex = 17;
            // 
            // ApiButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteNumericUpDown);
            this.Controls.Add(this.DeletePublisherButton);
            this.Controls.Add(this.DeleteGenreButton);
            this.Controls.Add(this.DeleteAuthorButton);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreatePublisherButton);
            this.Controls.Add(this.CreateAuthorButton);
            this.Controls.Add(this.CreateGenreButton);
            this.Controls.Add(this.CreateBook);
            this.Controls.Add(this.GetAuthorsButton);
            this.Controls.Add(this.GetPublishersButton);
            this.Controls.Add(this.GetGenresButton);
            this.Controls.Add(this.GetBooksButton);
            this.Controls.Add(this.GetAllField);
            this.Name = "ApiButtonsForm";
            this.Text = "Übersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApiButtonsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApiButtonsForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GetAllField;
        private System.Windows.Forms.Button GetBooksButton;
        private System.Windows.Forms.Button GetGenresButton;
        private System.Windows.Forms.Button GetPublishersButton;
        private System.Windows.Forms.Button GetAuthorsButton;
        private System.Windows.Forms.Button CreateBook;
        private System.Windows.Forms.Button CreateGenreButton;
        private System.Windows.Forms.Button CreateAuthorButton;
        private System.Windows.Forms.Button CreatePublisherButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Button DeleteAuthorButton;
        private System.Windows.Forms.Button DeleteGenreButton;
        private System.Windows.Forms.Button DeletePublisherButton;
        private System.Windows.Forms.NumericUpDown deleteNumericUpDown;
    }
}

