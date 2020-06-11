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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            //var task = HttpRequests.GetResponseAsync();
            //var items = await task;

            //items.ForEach((item) =>
            //{
            //    listBoxCompetences.Items.Add(item.title);
            //});

            //Console.WriteLine(items);

        }
    }
}
