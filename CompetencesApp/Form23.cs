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
    public partial class Form23 : Form2
    {
        private Teacher user;
        private List<UserCompetenceTeacher> usercompetences;
        private Competence selectedCompetence;
        //private int currentWindow; // 0 = fenetre comp , 1 = fenetre ressource, 2 = profil

        public Form23(Teacher teacheruser)
        {
            InitializeComponent();

            //Affichage Onglet Competences
            HideProfile();
            HideRessources();
            ShowCompetences();
            //this.currentWindow = 0;


            //Affichage attribut teacher
            labelPrenom.Text = teacheruser.firstName;
            labelNom.Text = teacheruser.surname.ToUpper();

            this.user = teacheruser;

            teacheruser.teacherCompetence.ForEach((competence) => comboBoxCompetences.Items.Add(competence.name));

            if(comboBoxCompetences.Items.Count != 0) comboBoxCompetences.SelectedIndex = 0;


            this.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void comboBoxCompetences_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudent.Items.Clear();
            listBoxResources.Items.Clear();
            var competenceSelected = this.user.teacherCompetence[comboBoxCompetences.SelectedIndex];
            if(competenceSelected != null)
            {
                //if(this.currentWindow == 0)
                //{
                    var comps = await HttpRequests.GetUserCompetenceTeacherById(competenceSelected._id);
                    this.usercompetences = comps;
                    this.selectedCompetence = competenceSelected;
                    comps.ForEach((usercomp) => listBoxStudent.Items.Add(usercomp.firstName + " " + usercomp.surname.ToUpper())); // Affichage nom prenom user
                //}
                //if (this.currentWindow == 1)
                //{
                    // Affichage ressource
                    var ressources = competenceSelected.ressources;
                    if(ressources == null)
                    {
                        competenceSelected.ressources = await HttpRequests.GetResourceByCompetenceId(competenceSelected._id);
                    }

                    competenceSelected.ressources.ForEach((ressource) => listBoxResources.Items.Add(ressource.title));
                //}
            }
        }

        private async void buttonValider_Click(object sender, EventArgs e)
        {
            var usercompetenceSelected = this.usercompetences[listBoxStudent.SelectedIndex];
            if(usercompetenceSelected != null)
            {
                usercompetenceSelected.doclist = await HttpRequests.GetDocumentsByUserCompetenceId(usercompetenceSelected._id);


                this.selectedCompetence.ressources = await HttpRequests.GetResourceByCompetenceId(this.selectedCompetence._id);
                


                Form3 formcompetence = new Form3(this.selectedCompetence, usercompetenceSelected, this.user);
                formcompetence.ShowDialog();
            }
        }

        private void ShowProfile()
        {
            buttonDeconnection.Show();
            labelStatut.Show();
        }
        private void HideProfile()
        {
            buttonDeconnection.Hide();
            labelStatut.Hide();
        }

        private void ShowCompetences()
        {
            labelCompetences.Show();
            comboBoxCompetences.Show();

            labelStudent.Show();
            listBoxStudent.Show();


            buttonValider.Show();
        }

        private void HideCompetences()
        {
            labelCompetences.Hide();
            comboBoxCompetences.Hide();

            labelStudent.Hide();
            listBoxStudent.Hide();

            buttonValider.Hide();
        }

        private void ShowRessources()
        {
            labelCompetences.Show();
            comboBoxCompetences.Show();

            labelResourceTitle.Show();
            textBoxResource.Show();

            labelDescription.Show();
            textBoxDescription.Show();

            labelResources.Show();
            listBoxResources.Show();

            labelShowDescription.Show();
            richTextBoxDescription.Show();

            buttonAdd.Show();
            buttonRemove.Show();
        }

        private void HideRessources()
        {
            labelCompetences.Hide();
            comboBoxCompetences.Hide();

            labelResourceTitle.Hide();
            textBoxResource.Hide();

            labelDescription.Hide();
            textBoxDescription.Hide();

            labelResources.Hide();
            listBoxResources.Hide();

            labelShowDescription.Hide();
            richTextBoxDescription.Hide();

            buttonAdd.Hide();
            buttonRemove.Hide();
        }

        private void buttonCompetences_Click(object sender, EventArgs e)
        {
            HideProfile();
            HideRessources();
            ShowCompetences();
            //this.currentWindow = 0;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            //this.currentWindow = 2;
            ShowProfile();
            HideCompetences();
            HideRessources();
        }

        private void buttonDeconnection_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            HideProfile();
            //this.currentWindow = 1;
            HideCompetences();
            ShowRessources();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxResource.TextLength != 0)
            {
                var resource = await HttpRequests.PostRessourceByCompetenceId(selectedCompetence._id, textBoxResource.Text, textBoxDescription.Text);
                this.selectedCompetence.ressources.Add(resource);
                listBoxResources.Items.Add(resource.title);
            }
        }

        private void listBoxResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResources.SelectedIndex == -1) return;
            richTextBoxDescription.Text = selectedCompetence.ressources[listBoxResources.SelectedIndex].content;
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            var selectedRessource = selectedCompetence.ressources[listBoxResources.SelectedIndex];
            if (listBoxResources.SelectedItem != null)
            {
                bool success = await HttpRequests.DeleteRessource(this.selectedCompetence._id, selectedRessource._id);
                if (success)
                {
                    this.selectedCompetence.ressources.RemoveAt(listBoxResources.SelectedIndex);
                    listBoxResources.Items.RemoveAt(listBoxResources.SelectedIndex);
                    richTextBoxDescription.Clear();
                }
            }

        }
    }
}
