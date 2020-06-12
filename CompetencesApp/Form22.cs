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

        private List<Competence> competenceNotInBlock = new List<Competence>();
        private List<Competence> competenceInBlock = new List<Competence>();

        private List<Competence> competenceOwnedByTeacher = new List<Competence>();
        private List<Competence> competenceNotOwnedByTeacher = new List<Competence>();


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

            comboBoxCompetenceBlock.SelectedIndex = -1;
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
            int selectedIndex;
            bool success;
            switch (this.currentWindow)
            {
                case 0:
                    selectedIndex = comboBoxPromotion.SelectedIndex;
                    if (selectedIndex == -1) return;
                    var selectedPromotion = this.adminuser.promos[selectedIndex];
                    if (selectedPromotion == null) return;
                    success = await HttpRequests.DeletePromotion(selectedPromotion._id);
                    if (success)
                    {
                        this.adminuser.promos.RemoveAt(selectedIndex);
                        comboBoxPromotion.Items.RemoveAt(selectedIndex);
                    }
                    // Delete promotion
                    break;
                case 1:
                    selectedIndex = comboBoxUsers.SelectedIndex;
                    if (selectedIndex == -1) return;
                    var selectedUser = this.adminuser.users[selectedIndex];
                    if (selectedUser == null) return;
                    success = await HttpRequests.DeleteUser(selectedUser._id);
                    if (success)
                    {
                        this.adminuser.users.RemoveAt(selectedIndex);
                        comboBoxUsers.Items.RemoveAt(selectedIndex);
                    }
                    // Delete User
                    break;
                case 2:
                    selectedIndex = comboBoxCompetenceBlock.SelectedIndex;
                    if (selectedIndex == -1) return;
                    var selectedCompetenceBlock = this.adminuser.competenceblocks[selectedIndex];
                    if (selectedCompetenceBlock == null) return;
                    success = await HttpRequests.DeleteCompetenceBlock(selectedCompetenceBlock._id);
                    if (success)
                    {
                        this.adminuser.competenceblocks.RemoveAt(selectedIndex);
                        comboBoxCompetenceBlock.Items.RemoveAt(selectedIndex);
                    }
                    // Delete CompetenceBlock
                    break;
                case 3:
                    selectedIndex = comboBoxCompetences.SelectedIndex;
                    if (selectedIndex == -1) return;
                    var selectedCompetence = this.adminuser.competences[selectedIndex];
                    if (selectedCompetence == null) return;
                    success = await HttpRequests.DeleteCompetence(selectedCompetence._id);
                    if (success)
                    {
                        this.adminuser.competences.RemoveAt(selectedIndex);
                        comboBoxCompetences.Items.RemoveAt(selectedIndex);
                    }
                    // Delete Competence
                    break;
                default:
                    break;
            }
        }

        private void comboBoxCompetences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCompetenceBlock_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxCompetenceBlock.SelectedIndex == -1) return;
            int selectedIndex = comboBoxCompetenceBlock.SelectedIndex;
            CompetenceBlock selectedCompetenceBlock = this.adminuser.competenceblocks[selectedIndex];
            if (selectedCompetenceBlock == null) return;

            List<Competence> competenceNotInBlock = new List<Competence>();

            this.adminuser.competences.ForEach((competence) =>
            {
                if (!BlockContainsCompetence(selectedCompetenceBlock, competence._id)) competenceNotInBlock.Add(competence);
            });
            listBoxNoPromotionUsers.Items.Clear();
            listBoxPromotionUsers.Items.Clear();

            competenceNotInBlock.ForEach((competence) => listBoxNoPromotionUsers.Items.Add(competence.name));
            selectedCompetenceBlock.competence.ForEach((competence) => listBoxPromotionUsers.Items.Add(competence.name));
            this.competenceNotInBlock = competenceNotInBlock;
            List<Competence> competenceInBlock = new List<Competence>();
            selectedCompetenceBlock.competence.ForEach((competence) => competenceInBlock.Add(competence));
            this.competenceInBlock = competenceInBlock;
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

            userNotInPromotion.ForEach((user) => listBoxNoPromotionUsers.Items.Add(user.surname + " " + user.firstName));
            selectedPromotion.users.ForEach((user) => listBoxPromotionUsers.Items.Add(user.surname + " " + user.firstName));
            this.usersNotInPromotion = userNotInPromotion;
            List<User> promotionUsers = new List<User>(); // On fait copy sinon assignation = reference
            selectedPromotion.users.ForEach((user) => promotionUsers.Add(user));
            this.usersInPromotion = promotionUsers;

        }

        private async void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedIndex == -1) return;
            int selectedIndex = comboBoxUsers.SelectedIndex;
            User selectedUser = this.adminuser.users[selectedIndex];
            if (selectedUser == null) return;
            if (!(selectedUser.isTeacher)) return;
            Teacher selectedTeacher = selectedUser as Teacher;

            label1.Text = selectedTeacher.teacherCompetence.ToString();
            List<Competence> competenceNotOwned = new List<Competence>();

            this.adminuser.competences.ForEach((competence) =>
            {
                if (!TeacherOwnCompetence(selectedTeacher, competence._id)) competenceNotOwned.Add(competence);
            });

            listBoxNoPromotionUsers.Items.Clear();
            listBoxPromotionUsers.Items.Clear();
            
            //userNotInPromotion.ForEach((user) => listBoxNoPromotionUsers.Items.Add(user.surname + " " + user.firstName));
            //selectedPromotion.users.ForEach((user) => listBoxPromotionUsers.Items.Add(user.surname + " " + user.firstName));
            //this.usersNotInPromotion = userNotInPromotion;
            // List<User> promotionUsers = new List<User>(); // On fait copy sinon assignation = reference
            // selectedPromotion.users.ForEach((user) => promotionUsers.Add(user));
            // this.usersInPromotion = promotionUsers;

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

        private bool BlockContainsCompetence(CompetenceBlock competenceBlock, string competenceId)
        {
            bool contains = false;
            if (competenceBlock.competence == null) return false;
            competenceBlock.competence.ForEach((competence) =>
            {
                if (competence._id == competenceId) contains = true;
            });
            return contains;
        }

        private bool TeacherOwnCompetence(Teacher teacher, string competenceId)
        {
            bool contains = false;
            if (teacher.comps == null) return false;
            teacher.teacherCompetence.ForEach((competence) =>
            {
                if (competence._id == competenceId) contains = true;
            });
            return contains;
        }

        private void addUserPromotionButton_Click(object sender, EventArgs e)
        {

            if (listBoxNoPromotionUsers.SelectedIndex == -1) return;
            int selectedIndex = listBoxNoPromotionUsers.SelectedIndex;
            switch (this.currentWindow)
            {
                case 0:
                    User selectedUser = usersNotInPromotion[selectedIndex];
                    if (selectedUser == null) return;
                    usersNotInPromotion.RemoveAt(selectedIndex);
                    usersInPromotion.Add(selectedUser);

                    listBoxPromotionUsers.Items.Add(selectedUser.surname + " "+selectedUser.firstName); 
                    break;
                case 2:
                    Competence selectedCompetence = competenceNotInBlock[selectedIndex];
                    if (selectedCompetence == null) return;
                    competenceNotInBlock.RemoveAt(selectedIndex);
                    competenceInBlock.Add(selectedCompetence);

                    listBoxPromotionUsers.Items.Add(selectedCompetence.name);
                    break;
                default:
                    return;

            }
            listBoxNoPromotionUsers.Items.RemoveAt(selectedIndex);
        }

        private void removeUserPromotionButton_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxPromotionUsers.SelectedIndex;
            if (selectedIndex == -1) return;
            switch (this.currentWindow)
            {
                case 0:
                    User selectedUser = usersInPromotion[selectedIndex];
                    if (selectedUser == null) return;
                    usersInPromotion.RemoveAt(selectedIndex);
                    usersNotInPromotion.Add(selectedUser);

                    listBoxNoPromotionUsers.Items.Add(selectedUser.surname + " " + selectedUser.firstName);
                    break;
                case 2:
                    Competence selectedCompetence = competenceInBlock[selectedIndex];
                    if (selectedCompetence == null) return;
                    competenceInBlock.RemoveAt(selectedIndex);
                    competenceNotInBlock.Add(selectedCompetence);
                    listBoxNoPromotionUsers.Items.Add(selectedCompetence.name);
                    break;
                default:
                    return;

            }
            listBoxPromotionUsers.Items.RemoveAt(selectedIndex);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            switch (this.currentWindow)
            {
                case 0:
                    selectedIndex = comboBoxPromotion.SelectedIndex;
                    if (selectedIndex == -1) return;
                    Promotion selectedPromotion = this.adminuser.promos[selectedIndex];
                    if (selectedPromotion == null) return;
                    await HttpRequests.PatchPromotionUsers(selectedPromotion._id, usersInPromotion);
                    List<User> promoUsers = new List<User>();
                    usersInPromotion.ForEach((user) => promoUsers.Add(user));
                    this.adminuser.promos[selectedIndex].users = promoUsers;
                    break;
                case 2:
                    selectedIndex = comboBoxCompetenceBlock.SelectedIndex;
                    if (selectedIndex == -1) return;
                    CompetenceBlock selectedBlock = this.adminuser.competenceblocks[selectedIndex];
                    if (selectedBlock == null) return;
                    await HttpRequests.PatchCompetenceBlockCompetence(selectedBlock._id, this.competenceInBlock);
                    List<Competence> competences = new List<Competence>();
                    competenceInBlock.ForEach((competence) => competences.Add(competence));
                    this.adminuser.competenceblocks[selectedIndex].competence = competences;
                    break;
                default:

                    break;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (this.currentWindow)
            {
                case -1:
                    break;
                case 0:
                    // Add promotion
                    FormAddPromotion addpromotion = new FormAddPromotion(this.adminuser,comboBoxPromotion);
                    addpromotion.ShowDialog();
                    break;
                case 1:
                    // Add User
                    FormAddUser adduser = new FormAddUser(this.adminuser, comboBoxUsers);
                    adduser.ShowDialog();
                    break;
                case 2:
                    // Add CompetenceBlock
                    FormAddCompetenceBlock addcompetenceblock = new FormAddCompetenceBlock(this.adminuser, comboBoxCompetenceBlock);
                    addcompetenceblock.ShowDialog();
                    break;
                case 3:
                    // Add Competence
                    FormAddCompetence addcompetence = new FormAddCompetence(this.adminuser, comboBoxCompetences);
                    addcompetence.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }

}
