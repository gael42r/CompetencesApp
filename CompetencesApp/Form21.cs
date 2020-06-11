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

            //Affichage attributs user

            labelPrenom.Text = studentuser.firstName;
            labelNom.Text = studentuser.surname.ToUpper();

            foreach(Promotion promo in studentuser.promos)
            {
                comboBoxPromotion.Items.Add(promo.name);
            }
            comboBoxPromotion.SelectedIndex = 0;


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
            //Affichage
        }

        private void buttonMyCompetences_Click(object sender, EventArgs e)
        {
            //Affichage
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //Affichage
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (listBoxCompetences.SelectedIndex == -1) return;

            var competence = competences[listBoxCompetences.SelectedIndex];
            var userComp = studentuser.comps.Find((comp) => comp.competenceId == competence._id);
            
            if(userComp != null)
            {
                label2.Text = "UserCompetence existe deja";
                // Tu crée fenetre avec en param un obj UserCOmpetence et un obj Competence
            }
            else
            {
                label2.Text = "On cree une user competence";
                //users/:id/competences   et tu fournis competenceId -> competences[listBoxCompetences.SelectedIndex]._id";
                // Et je te renvoi un obj UserCompetence
                // Tu crée fenetre avec en param un obj UserCOmpetence et un obj Competence
            }
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
                    var userComp = studentuser.comps.Find((comp) => comp.competenceId == competenceblock._id);
                    if (userComp != null)
                    {
                        if (userComp.isValidated)
                        {
                            listBoxCompetences.Items.Add("Competence terminée : " + competenceblock.name);
                        }
                    }
                    else
                    {
                        listBoxCompetences.Items.Add(competenceblock.name);
                    }
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
    }
}
