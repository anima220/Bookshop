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
    public partial class CreateAuthorForm : Form
    {
        IAgentOfWork _agentOfWork;
        public CreateAuthorForm()
        {
            InitializeComponent();
        }

        public CreateAuthorForm(IAgentOfWork agentOfWork)
        {
            _agentOfWork = agentOfWork;
        }

        private async void CreateAuthorButton_Click(object sender, EventArgs e)
        {       
            ApiButtonsForm apiButtonsForm = new ApiButtonsForm();


            try
            {
                Author author = new Author();
                author.FirstName = firstNameTextBox.Text;
                author.LastName = lastNameTextBox.Text;
                author.Birthdate = birthdateDateTimePicker.Value;
                author.IsAlive = isAliveCheckBox.Checked;

                var authors = await _agentOfWork.Author.Add(author);
                MessageBox.Show("Erstellen erfolgreich!");

                apiButtonsForm.Show();
                apiButtonsForm.GetAuthorsButton_Click(sender, e);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler");
            }
        }
    }
}
