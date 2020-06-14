using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencesApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = "";
                var userlogin = await HttpRequests.UserLogin(textBoxUser.Text, textBoxPassword.Text);
                this.Hide();

                if (userlogin is Admin)
                {
                    //On lance la form admin
                    Form22 adminform = new Form22(userlogin);
                    this.Close();
                    try
                    {
                        adminform.ShowDialog();
                    }
                    catch
                    {

                    }
                }
                else if (userlogin is Teacher)
                {
                    Form23 studentform = new Form23(userlogin);
                    this.Close();
                    try
                    {
                        studentform.ShowDialog();
                    }
                    catch { }

                }
                else
                {
                    //On lance la form élève
                    Form21 studentform = new Form21(userlogin);
                    this.Close();
                    try
                    {
                        studentform.ShowDialog();
                    }
                    catch { }
                }
            }
            catch
            {
                labelError.Text = "Identifiant ou mot de passe incorrect.";
                textBoxUser.Clear();
                textBoxPassword.Clear();
            }
              
        }
    }
}
