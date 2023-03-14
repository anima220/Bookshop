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
    public partial class CreateGenreForm : Form
    {
        IAgentOfWork _agentOfWork;

        public CreateGenreForm()
        {
            InitializeComponent();
        }
        public CreateGenreForm(IAgentOfWork agentOfWork)
        {
            _agentOfWork = agentOfWork;
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            ApiButtonsForm apiButtonsForm = new ApiButtonsForm();

            try
            {
                Genre genre = new Genre();
                genre.Description = nameTextBox.Text;
                genre.IsEditable = isEditableCheckBox.Checked;
             
                var genres = await _agentOfWork.Genre.Add(genre);

                MessageBox.Show("Erstellen erfolgreich!");

                apiButtonsForm.GetGenresButton_Click(sender, e);
                apiButtonsForm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler");
            }
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            ApiButtonsForm apiButtonsForm = new ApiButtonsForm();
            this.Close();
            apiButtonsForm.Show();
        }
    }
}
