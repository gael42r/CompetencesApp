using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencesApp
{
    public partial class FormAddUser : Form2
    {
        Admin userAdmin;
        ComboBox comboBox;
        public FormAddUser(Admin userAdmin, ComboBox comboBoxModified)
        {
            this.comboBox = comboBoxModified;
            this.userAdmin = userAdmin;

            InitializeComponent();
            comboBoxStatut.SelectedIndex = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isTeacher = false;
            bool isAdmin = false;

            switch (comboBoxStatut.SelectedIndex)
            {
                case 0: //Etudiant
                    isTeacher = false;
                    isAdmin = false;
                    break;
                case 1: //Professeur
                    isTeacher = true;
                    isAdmin = false;
                    break;
                case 2: //Administrateur
                    isTeacher = false;
                    isAdmin = true;
                    break;
                default:
                    break;
            }

            var user = await HttpRequests.PostCreateUser(textBoxUsername.Text, textBoxPrenom.Text, textBoxNom.Text, textBoxPassword.Text, isAdmin, isTeacher);
            this.userAdmin.users.Add(user);
            this.comboBox.Items.Add(user.surname + " " + user.firstName);
            this.Close();
        }
    }
}
