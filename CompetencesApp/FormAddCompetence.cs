using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencesApp
{
    public partial class FormAddCompetence : Form2
    {
        Admin userAdmin;
        ComboBox comboBox;
        public FormAddCompetence(Admin userAdmin, ComboBox comboBoxModified)
        {
            this.comboBox = comboBoxModified;
            this.userAdmin = userAdmin;

            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var competence = await HttpRequests.PostCreateCompetence(textBoxNom.Text, textBoxDescription.Text);
            this.userAdmin.competences.Add(competence);
            this.comboBox.Items.Add(competence.name);
            this.Close();
        }
    }
}
