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
    public partial class FormAddPromotion : Form2
    {
        Admin userAdmin;
        ComboBox comboBox;
        public FormAddPromotion(Admin userAdmin,ComboBox comboBoxModified)
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
            var promotion = await HttpRequests.PostCreatePromotion(textBoxNom.Text);
            this.userAdmin.promos.Add(promotion);
            this.comboBox.Items.Add(promotion.name);
            this.Close();
        }
    }
}
