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
    public partial class Form22 : Form2
    {
        private User adminuser;
        public Form22(User adminuser)
        {
            InitializeComponent();

            this.adminuser = adminuser;

            //Affichage attributs user

            labelPrenom.Text = adminuser.firstName;
            labelNom.Text = adminuser.surname.ToUpper();

            foreach (Promotion promo in adminuser.promos)
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
    }
}
