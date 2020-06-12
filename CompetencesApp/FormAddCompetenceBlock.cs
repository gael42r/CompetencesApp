﻿using System;
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
    public partial class FormAddCompetenceBlock : Form2
    {
        public FormAddCompetenceBlock()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var competenceblock = await HttpRequests.PostCreateCompetenceBlock(textBoxNom.Text, textBoxDescription.Text);

            this.Close();
        }
    }
}