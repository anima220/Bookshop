using Microsoft.SqlServer.Server;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.ClientCore;
using Nordblick.Bookshop.ClientCore.Agents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITest
{
    public partial class ApiButtonsForm : Form
    {
        IAgentOfWork _agentOfWork;
        public ApiButtonsForm()
        {         
            InitializeComponent();
        }

        public ApiButtonsForm(IAgentOfWork agentOfWork)
        {
            _agentOfWork = agentOfWork;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public async void GetBooksButton_Click(object sender, EventArgs e)
        {
            GetAllField.Text = "";

            var books = await _agentOfWork.Book.GetAll();

            StringListBuilder<Book> stringListBuilder = new StringListBuilder<Book>(books.ToList());

            GetAllField.Text = stringListBuilder.RunFatClient();
        }

        public async void GetGenresButton_Click(object sender, EventArgs e)
        {
            GetAllField.Text = "";

            var allItems = await _agentOfWork.Genre.GetAll();

            StringListBuilder<Genre> stringListBuilder = new StringListBuilder<Genre>(allItems.ToList());

            GetAllField.Text = stringListBuilder.RunFatClient();
        }

        public async void GetPublishersButton_Click(object sender, EventArgs e)
        {
            GetAllField.Text = "";

            var allItems = await _agentOfWork.Publisher.GetAll();

            StringListBuilder<Publisher> stringListBuilder = new StringListBuilder<Publisher>(allItems.ToList());

            GetAllField.Text = stringListBuilder.RunFatClient();
        }

        public async void GetAuthorsButton_Click(object sender, EventArgs e)
        {
            GetAllField.Text = "";

            var authors = await _agentOfWork.Author.GetAll();

            StringListBuilder<Author> stringListBuilder = new StringListBuilder<Author>(authors.ToList());

            GetAllField.Text = stringListBuilder.RunFatClient();
        }

        private void CreateBook_Click(object sender, EventArgs e)
        {
            CreateBookForm createBookForm = new CreateBookForm();

            createBookForm.Show();
            this.Hide();
        }

        private void CreateGenreButton_Click(object sender, EventArgs e)
        {
            CreateGenreForm createGenreForm = new CreateGenreForm();

            createGenreForm.Show();
            this.Hide();
        }

        private void CreateAuthorButton_Click(object sender, EventArgs e)
        {
            CreateAuthorForm createAuthorForm = new CreateAuthorForm();

            createAuthorForm.Show();
            this.Hide();
        }

        private async void DeleteBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _agentOfWork.Book.Remove(Convert.ToInt32(deleteNumericUpDown.Value));

                GetBooksButton_Click(sender, e);

                MessageBox.Show("Löschen erfolgreich");
            }
            catch (Exception exep)
            {

               MessageBox.Show(exep.Message) ;
            }
        }

        private async void DeleteAuthorButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _agentOfWork.Author.Remove(Convert.ToInt32(deleteNumericUpDown.Value));

                GetAuthorsButton_Click(sender, e);

                MessageBox.Show("Löschen erfolgreich");
            }
            catch (Exception exep)
            {

                MessageBox.Show(exep.Message);
            }
        }

        private async void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _agentOfWork.Genre.Remove(Convert.ToInt32(deleteNumericUpDown.Value));

                GetGenresButton_Click(sender, e);

                MessageBox.Show("Löschen erfolgreich");
            }
            catch (Exception exep)
            {

                MessageBox.Show(exep.Message);
            }
        }

        private void ApiButtonsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ApiButtonsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
