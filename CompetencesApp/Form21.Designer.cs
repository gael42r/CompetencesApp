namespace CompetencesApp
{
    partial class Form21
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            this.labelCompetences = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPromotion = new System.Windows.Forms.Label();
            this.comboBoxPromotion = new System.Windows.Forms.ComboBox();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonMyCompetences = new System.Windows.Forms.Button();
            this.labelProf_Eleve = new System.Windows.Forms.Label();
            this.labelNbComp = new System.Windows.Forms.Label();
            this.labelNbCompVal = new System.Windows.Forms.Label();
            this.listBoxCompetences = new System.Windows.Forms.ListBox();
            this.listBoxCompetencesBlocks = new System.Windows.Forms.ListBox();
            this.labelCompetencesBlocks = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonDeconnection = new System.Windows.Forms.Button();
            this.labelStatut = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCompetences
            // 
            this.labelCompetences.AutoSize = true;
            this.labelCompetences.BackColor = System.Drawing.Color.Transparent;
            this.labelCompetences.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompetences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelCompetences.Location = new System.Drawing.Point(567, 210);
            this.labelCompetences.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompetences.Name = "labelCompetences";
            this.labelCompetences.Size = new System.Drawing.Size(144, 30);
            this.labelCompetences.TabIndex = 24;
            this.labelCompetences.Text = "Compétences";
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.buttonValider.FlatAppearance.BorderSize = 0;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(150, 548);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(820, 40);
            this.buttonValider.TabIndex = 23;
            this.buttonValider.Text = "Ouvrir";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.buttonMinimize);
            this.panel2.Controls.Add(this.labelPrenom);
            this.panel2.Controls.Add(this.labelNom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(122, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 122);
            this.panel2.TabIndex = 19;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(841, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(810, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize.TabIndex = 10;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelPrenom.Location = new System.Drawing.Point(20, 12);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(138, 45);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelNom.Location = new System.Drawing.Point(20, 63);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(100, 45);
            this.labelNom.TabIndex = 25;
            this.labelNom.Text = "NOM";
            // 
            // labelPromotion
            // 
            this.labelPromotion.AutoSize = true;
            this.labelPromotion.BackColor = System.Drawing.Color.Transparent;
            this.labelPromotion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelPromotion.Location = new System.Drawing.Point(145, 135);
            this.labelPromotion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPromotion.Name = "labelPromotion";
            this.labelPromotion.Size = new System.Drawing.Size(119, 30);
            this.labelPromotion.TabIndex = 12;
            this.labelPromotion.Text = "Promotion";
            // 
            // comboBoxPromotion
            // 
            this.comboBoxPromotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPromotion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.comboBoxPromotion.FormattingEnabled = true;
            this.comboBoxPromotion.Location = new System.Drawing.Point(150, 169);
            this.comboBoxPromotion.Name = "comboBoxPromotion";
            this.comboBoxPromotion.Size = new System.Drawing.Size(820, 29);
            this.comboBoxPromotion.TabIndex = 11;
            this.comboBoxPromotion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPromotion_SelectedIndexChanged);
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelStudent.Controls.Add(this.panel1);
            this.panelStudent.Controls.Add(this.buttonProfile);
            this.panelStudent.Controls.Add(this.buttonMyCompetences);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(122, 600);
            this.panelStudent.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 329);
            this.panel1.TabIndex = 11;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.Location = new System.Drawing.Point(0, 0);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(122, 122);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profil";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonMyCompetences
            // 
            this.buttonMyCompetences.BackColor = System.Drawing.Color.Transparent;
            this.buttonMyCompetences.FlatAppearance.BorderSize = 0;
            this.buttonMyCompetences.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonMyCompetences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMyCompetences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMyCompetences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyCompetences.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMyCompetences.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonMyCompetences.Location = new System.Drawing.Point(0, 121);
            this.buttonMyCompetences.Name = "buttonMyCompetences";
            this.buttonMyCompetences.Size = new System.Drawing.Size(122, 80);
            this.buttonMyCompetences.TabIndex = 3;
            this.buttonMyCompetences.Text = "Mes compétences";
            this.buttonMyCompetences.UseVisualStyleBackColor = false;
            this.buttonMyCompetences.Click += new System.EventHandler(this.buttonMyCompetences_Click);
            // 
            // labelProf_Eleve
            // 
            this.labelProf_Eleve.AutoSize = true;
            this.labelProf_Eleve.BackColor = System.Drawing.Color.Transparent;
            this.labelProf_Eleve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProf_Eleve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelProf_Eleve.Location = new System.Drawing.Point(229, 135);
            this.labelProf_Eleve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProf_Eleve.Name = "labelProf_Eleve";
            this.labelProf_Eleve.Size = new System.Drawing.Size(0, 30);
            this.labelProf_Eleve.TabIndex = 27;
            // 
            // labelNbComp
            // 
            this.labelNbComp.AutoSize = true;
            this.labelNbComp.BackColor = System.Drawing.Color.Transparent;
            this.labelNbComp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelNbComp.Location = new System.Drawing.Point(415, 176);
            this.labelNbComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNbComp.Name = "labelNbComp";
            this.labelNbComp.Size = new System.Drawing.Size(0, 30);
            this.labelNbComp.TabIndex = 30;
            // 
            // labelNbCompVal
            // 
            this.labelNbCompVal.AutoSize = true;
            this.labelNbCompVal.BackColor = System.Drawing.Color.Transparent;
            this.labelNbCompVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbCompVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelNbCompVal.Location = new System.Drawing.Point(499, 210);
            this.labelNbCompVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNbCompVal.Name = "labelNbCompVal";
            this.labelNbCompVal.Size = new System.Drawing.Size(0, 30);
            this.labelNbCompVal.TabIndex = 31;
            // 
            // listBoxCompetences
            // 
            this.listBoxCompetences.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxCompetences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCompetences.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxCompetences.ForeColor = System.Drawing.Color.White;
            this.listBoxCompetences.FormattingEnabled = true;
            this.listBoxCompetences.ItemHeight = 21;
            this.listBoxCompetences.Location = new System.Drawing.Point(572, 243);
            this.listBoxCompetences.Name = "listBoxCompetences";
            this.listBoxCompetences.Size = new System.Drawing.Size(398, 273);
            this.listBoxCompetences.TabIndex = 22;
            // 
            // listBoxCompetencesBlocks
            // 
            this.listBoxCompetencesBlocks.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxCompetencesBlocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCompetencesBlocks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxCompetencesBlocks.ForeColor = System.Drawing.Color.White;
            this.listBoxCompetencesBlocks.FormattingEnabled = true;
            this.listBoxCompetencesBlocks.ItemHeight = 21;
            this.listBoxCompetencesBlocks.Location = new System.Drawing.Point(150, 243);
            this.listBoxCompetencesBlocks.Name = "listBoxCompetencesBlocks";
            this.listBoxCompetencesBlocks.Size = new System.Drawing.Size(398, 273);
            this.listBoxCompetencesBlocks.TabIndex = 32;
            this.listBoxCompetencesBlocks.SelectedIndexChanged += new System.EventHandler(this.listBoxCompetencesBlocks_SelectedIndexChanged);
            // 
            // labelCompetencesBlocks
            // 
            this.labelCompetencesBlocks.AutoSize = true;
            this.labelCompetencesBlocks.BackColor = System.Drawing.Color.Transparent;
            this.labelCompetencesBlocks.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompetencesBlocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelCompetencesBlocks.Location = new System.Drawing.Point(145, 210);
            this.labelCompetencesBlocks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompetencesBlocks.Name = "labelCompetencesBlocks";
            this.labelCompetencesBlocks.Size = new System.Drawing.Size(228, 30);
            this.labelCompetencesBlocks.TabIndex = 33;
            this.labelCompetencesBlocks.Text = "Blocs de compétences";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(149, 540);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 21);
            this.labelError.TabIndex = 34;
            // 
            // buttonDeconnection
            // 
            this.buttonDeconnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonDeconnection.FlatAppearance.BorderSize = 0;
            this.buttonDeconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeconnection.ForeColor = System.Drawing.Color.White;
            this.buttonDeconnection.Location = new System.Drawing.Point(150, 548);
            this.buttonDeconnection.Name = "buttonDeconnection";
            this.buttonDeconnection.Size = new System.Drawing.Size(820, 40);
            this.buttonDeconnection.TabIndex = 35;
            this.buttonDeconnection.Text = "Déconnexion";
            this.buttonDeconnection.UseVisualStyleBackColor = false;
            this.buttonDeconnection.Click += new System.EventHandler(this.buttonDeconnection_Click);
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.BackColor = System.Drawing.Color.Transparent;
            this.labelStatut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelStatut.Location = new System.Drawing.Point(145, 135);
            this.labelStatut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(173, 30);
            this.labelStatut.TabIndex = 36;
            this.labelStatut.Text = "Statut : Etudiant";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.buttonDeconnection);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelCompetencesBlocks);
            this.Controls.Add(this.listBoxCompetencesBlocks);
            this.Controls.Add(this.labelNbCompVal);
            this.Controls.Add(this.labelNbComp);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelPromotion);
            this.Controls.Add(this.labelProf_Eleve);
            this.Controls.Add(this.comboBoxPromotion);
            this.Controls.Add(this.labelCompetences);
            this.Controls.Add(this.listBoxCompetences);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelStudent);
            this.Name = "Form21";
            this.Text = "Competences";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompetences;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPromotion;
        private System.Windows.Forms.ComboBox comboBoxPromotion;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonMyCompetences;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelProf_Eleve;
        private System.Windows.Forms.Label labelNbComp;
        private System.Windows.Forms.Label labelNbCompVal;
        private System.Windows.Forms.ListBox listBoxCompetences;
        private System.Windows.Forms.ListBox listBoxCompetencesBlocks;
        private System.Windows.Forms.Label labelCompetencesBlocks;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDeconnection;
        private System.Windows.Forms.Label labelStatut;
    }
}