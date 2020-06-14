using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencesApp
{
    public partial class Form21 : Form2
    {
        private User studentuser;
        private List<CompetenceBlock> competenceBlocks;
        private List<Competence> competences;

        public Form21(User studentuser)
        {
            InitializeComponent();
            this.studentuser = studentuser;

            //Affichage Mes Competences
            HideProfile();
            ShowMesCompetences();

            //Affichage attributs user

            labelPrenom.Text = studentuser.firstName;
            labelNom.Text = studentuser.surname.ToUpper();

            foreach(Promotion promo in studentuser.promos)
            {
                comboBoxPromotion.Items.Add(promo.name);
            }
            if (comboBoxPromotion.Items.Count != 0) comboBoxPromotion.SelectedIndex = 0;


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

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ShowProfile();
            HideMesCompetences();
        }

        private void buttonMyCompetences_Click(object sender, EventArgs e)
        {
            HideProfile();
            ShowMesCompetences();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            HideProfile();
            HideMesCompetences();
        }

        private async void buttonValider_Click(object sender, EventArgs e)
        {
            if (listBoxCompetences.SelectedIndex == -1) return;

            var competence = competences[listBoxCompetences.SelectedIndex];
            var userComp = studentuser.comps.Find((comp) => comp.competenceId == competence._id);
            
            if(userComp == null)
            {
               // labelError.Text = "On cree une user competence";
                userComp = await HttpRequests.PostCompetenceId(competences[listBoxCompetences.SelectedIndex]._id, studentuser._id);
                studentuser.comps.Add(userComp); //faire pareil pour preuves
                //users/:id/competences   et tu fournis competenceId -> competences[listBoxCompetences.SelectedIndex]._id";
                // Et je te renvoi un obj UserCompetence
                // Tu crée fenetre avec en param un obj UserCOmpetence et un obj Competence
            }
            userComp.doclist = await HttpRequests.GetDocumentsByUserCompetenceId(userComp._id);



            //
            competence.ressources = await HttpRequests.GetResourceByCompetenceId(competence._id);
            //


            Form3 formcompetence = new Form3(competence, userComp, this.studentuser);
            formcompetence.ShowDialog();
        }

        private async void comboBoxPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCompetencesBlocks.Items.Clear();
            listBoxCompetences.Items.Clear();
            try
            {               
                var promo = this.studentuser.promos.Find(item => item.name == comboBoxPromotion.Text);
                var response = await HttpRequests.GetPromotionsCompetenceBlocksById(promo._id);
                competenceBlocks = response;
                foreach (CompetenceBlock competenceblock in response)
                {
                    listBoxCompetencesBlocks.Items.Add(competenceblock.name);
                }
            }
            catch 
            {

            }
        }

        private async void listBoxCompetencesBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCompetences.Items.Clear();
            try
            {
                var currBlock = competenceBlocks[listBoxCompetencesBlocks.SelectedIndex];
                var response = await HttpRequests.GetCompetenceBlocksCompetencesById(currBlock._id);
                competences = response;

                foreach (Competence competenceblock in response)
                {
                    /*var userComp = studentuser.comps.Find((comp) => comp.competenceId == competenceblock._id);
                    if (userComp != null)
                    {
                        
                    }
                    else
                    {
                        listBoxCompetences.Items.Add(competenceblock.name);
                    }*/
                    listBoxCompetences.Items.Add(competenceblock.name);
                }

            }
            catch
            {

            }


        }


        //private void buttonValider_MouseHover(object sender, EventArgs e)
        //{
        //    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
        //    ToolTip1.SetToolTip(buttonValider, "test");

        //}


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

        private void ShowMesCompetences()
        {
            labelPromotion.Show();
            comboBoxPromotion.Show();

            labelCompetencesBlocks.Show();
            listBoxCompetencesBlocks.Show();

            labelCompetences.Show();
            listBoxCompetences.Show();

            buttonValider.Show();
        }

        private void HideMesCompetences()
        {
            labelPromotion.Hide();
            comboBoxPromotion.Hide();

            labelCompetencesBlocks.Hide();
            listBoxCompetencesBlocks.Hide();

            labelCompetences.Hide();
            listBoxCompetences.Hide();

            buttonValider.Hide();
        }

        private void buttonDeconnection_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
