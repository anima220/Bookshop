using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.ClientCore;
using Nordblick.Bookshop.ClientCore.Agents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITest
{
    public partial class CreateBookForm : Form
    {
        IAgentOfWork _agentOfWork;
        public CreateBookForm()
        {

            InitializeComponent();
        }
        public CreateBookForm(IAgentOfWork agentOfWork)
        {
            _agentOfWork = agentOfWork;
        }


        private void CreateBookForm_Load(object sender, EventArgs e)
        {

        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            ApiButtonsForm apiButtonsForm = new ApiButtonsForm();
            this.Close();
            apiButtonsForm.Show();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            ApiButtonsForm apiButtonsForm = new ApiButtonsForm();

            try
            {
                Book book = new Book();
                book.Title = titleTextBox.Text;
                book.PublishingYear = publishingYearDateTimePicker.Value;
                book.PageCount = Convert.ToInt32(pageCountNumericUpDown.Value);
                book.Edition = EditionTextBox.Text;
                book.Price = Convert.ToDouble(priceNumericUpDown.Value);
                book.AvailabilityState = Convert.ToInt32(availabilityStateNumericUpDown.Value);
                book.CoverType = Convert.ToInt32(coverTypeNumericUpDown.Value);
                book.IsEBook = isEbookCheckBox.Checked;
                book.Isbn = isbnTextBox.Text;

                var books = await _agentOfWork.Book.Add(book);
                MessageBox.Show("Erstellen erfolgreich!");

                apiButtonsForm.GetBooksButton_Click(sender, e);
                apiButtonsForm.Show();
                this.Hide();           
            }
            catch (Exception)
            {

                MessageBox.Show("Fehler");
            }


        }

        private void PublishingYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
