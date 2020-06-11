using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencesApp
{
    public partial class Form22 : Form2
    {
        private Admin adminuser;
        private int currentWindow; // Fenetre -1 : Profil, 0 : Promotion, 1: Utilisateurs, 2: Bloc de competence, 3: Competences

        public Form22(Admin adminuser)
        {
            InitializeComponent();

            this.adminuser = adminuser;

            //Affichage attributs user

            labelPrenom.Text = adminuser.firstName;
            labelNom.Text = adminuser.surname.ToUpper();

            adminuser.promos.ForEach((promo) => comboBoxPromotion.Items.Add(promo.name));

            adminuser.users.ForEach((user) => comboBoxUsers.Items.Add(user.surname.ToUpper() +" " +user.firstName));

            adminuser.competenceblocks.ForEach((competenceblock) => comboBoxCompetenceBlock.Items.Add(competenceblock.name));

            adminuser.competences.ForEach((competence) => comboBoxCompetences.Items.Add(competence.name));


            HideAll();
            ShowPromotions();

            this.ShowDialog();
        }

        private void ShowPromotions()
        {
            comboBoxPromotion.Show();
            currentWindow = 0;
            labelCombo.Text = "Promotion : "; // Je pense que c'est + pertinent de changer le nom ici car ça ne change jamais de pos
        }
        private void ShowUsers()
        {
            comboBoxUsers.Show();
            currentWindow = 1;
            labelCombo.Text = "Utilisateurs : ";
        }

        private void ShowCompetenceBlocks()
        {
            comboBoxCompetenceBlock.Show();
            currentWindow = 2;
            labelCombo.Text = "Blocs de compétence : ";
        }

        private void ShowCompetences()
        {
            comboBoxCompetences.Show();
            currentWindow = 3;
            labelCombo.Text = "Compétences : ";
        }


        private void HideAll()
        {
            comboBoxPromotion.Hide();

            comboBoxUsers.Hide();

            comboBoxCompetenceBlock.Hide();

            comboBoxCompetences.Hide();

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPromotion_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowPromotions();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowUsers();

        }

        private void buttonCompetenceBlock_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowCompetenceBlocks();
        }

        private void buttonCompetence_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowCompetences();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            switch (this.currentWindow)
            {
                case -1:
                    break;
                case 0:
                    int selectedIndex = comboBoxPromotion.SelectedIndex;
                    if (selectedIndex == -1) return;
                    var selectedPromotion = this.adminuser.promos[selectedIndex];
                    if (selectedPromotion == null) return;
                    bool sucess = await HttpRequests.DeletePromotion(selectedPromotion._id);
                    if (sucess)
                    {
                        this.adminuser.promos.RemoveAt(selectedIndex);
                        comboBoxPromotion.Items.RemoveAt(selectedIndex);
                    }
                    // Delete promotion
                    break;
                case 1:
                    // Delete User
                    break;
                case 2:
                    // Delete CompetenceBlock
                    break;
                case 3:
                    // Delete Competence
                    break;
                default:
                    break;
            }
        }
    }
}
