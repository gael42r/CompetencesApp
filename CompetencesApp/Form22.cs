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
        private List<User> usersNotInPromotion = new List<User>();
        private List<User> usersInPromotion = new List<User>();


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
            comboBoxPromotion.SelectedIndex = -1;
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
            this.usersInPromotion.Clear();
            this.usersNotInPromotion.Clear();
            listBoxNoPromotionUsers.Items.Clear();
            listBoxPromotionUsers.Items.Clear();

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

        private void comboBoxCompetences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPromotion.SelectedIndex == -1) return;
            int selectedIndex = comboBoxPromotion.SelectedIndex;
            Promotion selectedPromotion = this.adminuser.promos[selectedIndex];
            if (selectedPromotion == null) return;

            List<User> userNotInPromotion = new List<User>();

            this.adminuser.users.ForEach((user) =>
            {
                if (!PromotionContainsUser(selectedPromotion, user._id) && !(user.isAdmin|| user.isTeacher)) userNotInPromotion.Add(user);
            });
            listBoxNoPromotionUsers.Items.Clear();
            listBoxPromotionUsers.Items.Clear();

            userNotInPromotion.ForEach((user) => listBoxNoPromotionUsers.Items.Add(user.firstName));
            selectedPromotion.users.ForEach((user) => listBoxPromotionUsers.Items.Add(user.firstName));
            this.usersNotInPromotion = userNotInPromotion;
            List<User> promotionUsers = new List<User>(); // On fait copy sinon assignation = reference
            selectedPromotion.users.ForEach((user) => promotionUsers.Add(user));
            this.usersInPromotion = promotionUsers;

        }


        private bool PromotionContainsUser(Promotion promo,string userId)
        {
            bool contains = false;
            if (promo.users == null) return false;
            promo.users.ForEach((promoUser) =>
            {
                if (promoUser._id == userId) contains = true;
            });
            return contains;
        }

        private void addUserPromotionButton_Click(object sender, EventArgs e)
        {
            if (listBoxNoPromotionUsers.SelectedIndex == -1) return;
            int selectedIndex = listBoxNoPromotionUsers.SelectedIndex;
            User selectedUser = usersNotInPromotion[selectedIndex];
            if (selectedUser == null) return;
            usersNotInPromotion.RemoveAt(selectedIndex);
            usersInPromotion.Add(selectedUser);
            listBoxPromotionUsers.Items.Add(selectedUser.firstName); // Nom a changer si besoin
            listBoxNoPromotionUsers.Items.RemoveAt(selectedIndex);
        }

        private void removeUserPromotionButton_Click(object sender, EventArgs e)
        {
            if (listBoxPromotionUsers.SelectedIndex == -1) return;
            int selectedIndex = listBoxPromotionUsers.SelectedIndex;
            User selectedUser = usersInPromotion[selectedIndex];
            if (selectedUser == null) return;
            usersInPromotion.RemoveAt(selectedIndex);
            usersNotInPromotion.Add(selectedUser);
            listBoxNoPromotionUsers.Items.Add(selectedUser.firstName); // Nom a changer si besoin
            listBoxPromotionUsers.Items.RemoveAt(selectedIndex);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxPromotion.SelectedIndex;
            if (selectedIndex == -1) return;
            Promotion selectedPromotion = this.adminuser.promos[selectedIndex];
            if (selectedPromotion == null) return;
            await HttpRequests.PatchPromotionUsers(selectedPromotion._id,usersInPromotion);
            List<User> promoUsers = new List<User>();
            usersInPromotion.ForEach((user) => promoUsers.Add(user));
            this.adminuser.promos[selectedIndex].users = promoUsers;
        }
    }

}
