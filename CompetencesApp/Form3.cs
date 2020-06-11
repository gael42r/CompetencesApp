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
    public partial class Form3 : Form2
    {
        private UserCompetence usercompetence;

        private User user;

        private List<Resource> resources;

        private float studentnumber;
        private float teachernumber;


        public Form3(Competence competence, UserCompetence usercompetence, User user)
        {
            this.resources = competence.ressources;
            this.usercompetence = usercompetence;
            this.user = user;
            InitializeComponent();

            //Affichage
            HideRessources();
            ShowEvaluation();
            //Informations
            labelCompetence.Text = competence.name;

            studentnumber = usercompetence.userPercent;
            labelEvaluationNumberStudent.Text = studentnumber.ToString() + "%";

            teachernumber = usercompetence.teacherPercent;
            labelEvaluationNumberTeacher.Text = teachernumber.ToString() + "%";

            //Bouton de validation de compétence
            if (this.usercompetence.isValidated)
            {
                buttonValidCompetence.BackColor = Color.ForestGreen;
                buttonValidCompetence.Text = "Invalider la compétence";
                if(!(this.user is Teacher))
                {
                    buttonValidCompetence.Text = "Validée";
                }
            }
            else
            {
                buttonValidCompetence.BackColor = Color.Firebrick;
                buttonValidCompetence.Text = "Valider la compétence";
                if (!(this.user is Teacher))
                {
                    buttonValidCompetence.Text = "En attente de validation";
                }
            }



            if (this.user is Teacher)
            {
                trackBarStudent.Value = Convert.ToInt32(teachernumber);
            }
            else
            {
                trackBarStudent.Value = Convert.ToInt32(studentnumber);
                buttonValidCompetence.Enabled = false;
            }

            this.usercompetence.doclist.ForEach((elem) => { listBoxProof.Items.Add(elem.link); });

            //Ajout des ressource dans listBoxResources
            foreach (Resource res in competence.ressources)
            {
                listBoxResources.Items.Add(res.title);
            }

            //Pour éviter probleme si une listbox est vide
            if(resources.Count != 0)
            {
                listBoxResources.SelectedIndex = 0;
            }

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if(this.user is Teacher)
            {
                teachernumber = trackBarStudent.Value;
                labelEvaluationNumberTeacher.Text = teachernumber.ToString() + "%";
            }
            else
            {
                studentnumber = trackBarStudent.Value;
                labelEvaluationNumberStudent.Text = studentnumber.ToString() + "%";
            }
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            //Affichage
            ShowRessources();
            HideEvaluation();
        }

        private void buttonAutoEval_Click(object sender, EventArgs e)
        {
            //Affichage
            HideRessources();
            ShowEvaluation();
        }

        private async void buttonAddProof_Click(object sender, EventArgs e)
        {
            var doc = await HttpRequests.PostDocument(usercompetence._id, textBoxProof.Text);
            this.usercompetence.doclist.Add(doc);

            listBoxProof.Items.Add(textBoxProof.Text);
        }

        private void buttonRemoveProof_Click(object sender, EventArgs e)
        {
            if(listBoxProof.SelectedItem != null)
            {
                foreach (Document docu in this.usercompetence.doclist)
                {
                    if (docu.link == listBoxProof.SelectedItem.ToString())
                    {
                        HttpRequests.DeleteDocument(this.usercompetence._id, docu._id);
                        listBoxProof.Items.Remove(listBoxProof.SelectedItem);
                        return;
                    }
                }
            } 
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            usercompetence.userPercent = studentnumber;
            usercompetence.teacherPercent = teachernumber;
            var response = await HttpRequests.PatchUserCompetence( this.usercompetence, this.user is Teacher);
            //this.usercompetence = response;

            //int index = this.UserReference.comps.FindIndex(element => element._id == response._id);
            //this.UserReference.comps[index] = response;
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private async void buttonClose_Click_1(object sender, EventArgs e)
        {
            usercompetence.userPercent = studentnumber;
            usercompetence.teacherPercent = teachernumber;
            var response = await HttpRequests.PatchUserCompetence(this.usercompetence, this.user.isTeacher || this.user.isAdmin);
            //this.usercompetence = response;

            //int index = this.UserReference.comps.FindIndex(element => element._id == response._id);
            //this.UserReference.comps[index] = response;
            this.Close();
        }

        private void listBoxResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currRes = resources[listBoxResources.SelectedIndex];
            richTextBoxDescription.Text = currRes.content;
        }

        private void buttonValidCompetence_Click(object sender, EventArgs e)
        {
            if (this.usercompetence.isValidated)
            {
                this.usercompetence.isValidated = false;
                buttonValidCompetence.BackColor = Color.Firebrick;
                buttonValidCompetence.Text = "Valider la compétence";
            }
            else
            {
                this.usercompetence.isValidated = true;
                buttonValidCompetence.BackColor = Color.ForestGreen;
                buttonValidCompetence.Text = "Invalider la compétence";
            }
        }

        private void ShowRessources()
        {
            labelResources.Show();
            listBoxResources.Show();

            richTextBoxDescription.Show();
            labelDescription.Show();

            
        }

        private void HideEvaluation()
        {
            labelEvaluationStudent.Hide();
            labelEvaluationNumberStudent.Hide();
            buttonSave.Hide();
            buttonValidCompetence.Hide();
            trackBarStudent.Hide();

            labelProof.Hide();
            buttonAddProof.Hide();
            buttonRemoveProof.Hide();
            textBoxProof.Hide();
            listBoxProof.Hide();

            labelEvaluationTeacher.Hide();
            labelEvaluationNumberTeacher.Hide();
        }

        private void HideRessources()
        {
            labelResources.Hide();
            listBoxResources.Hide();

            richTextBoxDescription.Hide();
            labelDescription.Hide();


        }

        private void ShowEvaluation()
        {
            labelEvaluationStudent.Show();
            labelEvaluationNumberStudent.Show();
            buttonSave.Show();
            buttonValidCompetence.Show();
            trackBarStudent.Show();

            labelProof.Show();
            buttonAddProof.Show();
            buttonRemoveProof.Show();
            textBoxProof.Show();
            listBoxProof.Show();

            labelEvaluationTeacher.Show();
            labelEvaluationNumberTeacher.Show();
        }
    }
}
