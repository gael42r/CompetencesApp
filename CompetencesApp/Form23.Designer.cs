namespace CompetencesApp
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonResources = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonCompetences = new System.Windows.Forms.Button();
            this.comboBoxCompetences = new System.Windows.Forms.ComboBox();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelCompetences = new System.Windows.Forms.Label();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelStatut = new System.Windows.Forms.Label();
            this.buttonDeconnection = new System.Windows.Forms.Button();
            this.textBoxResource = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelResourceTitle = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.labelShowDescription = new System.Windows.Forms.Label();
            this.labelResources = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 21;
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
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelStudent.Controls.Add(this.buttonResources);
            this.panelStudent.Controls.Add(this.panel1);
            this.panelStudent.Controls.Add(this.buttonProfile);
            this.panelStudent.Controls.Add(this.buttonCompetences);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(122, 600);
            this.panelStudent.TabIndex = 20;
            // 
            // buttonResources
            // 
            this.buttonResources.BackColor = System.Drawing.Color.Transparent;
            this.buttonResources.FlatAppearance.BorderSize = 0;
            this.buttonResources.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonResources.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResources.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResources.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonResources.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonResources.Location = new System.Drawing.Point(0, 197);
            this.buttonResources.Name = "buttonResources";
            this.buttonResources.Size = new System.Drawing.Size(122, 80);
            this.buttonResources.TabIndex = 12;
            this.buttonResources.Text = "Ressources";
            this.buttonResources.UseVisualStyleBackColor = false;
            this.buttonResources.Click += new System.EventHandler(this.buttonResources_Click);
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
            // buttonCompetences
            // 
            this.buttonCompetences.BackColor = System.Drawing.Color.Transparent;
            this.buttonCompetences.FlatAppearance.BorderSize = 0;
            this.buttonCompetences.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCompetences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCompetences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCompetences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompetences.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompetences.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonCompetences.Location = new System.Drawing.Point(0, 121);
            this.buttonCompetences.Name = "buttonCompetences";
            this.buttonCompetences.Size = new System.Drawing.Size(122, 80);
            this.buttonCompetences.TabIndex = 3;
            this.buttonCompetences.Text = "Compétences";
            this.buttonCompetences.UseVisualStyleBackColor = false;
            this.buttonCompetences.Click += new System.EventHandler(this.buttonCompetences_Click);
            // 
            // comboBoxCompetences
            // 
            this.comboBoxCompetences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetences.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxCompetences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.comboBoxCompetences.FormattingEnabled = true;
            this.comboBoxCompetences.Location = new System.Drawing.Point(150, 169);
            this.comboBoxCompetences.Name = "comboBoxCompetences";
            this.comboBoxCompetences.Size = new System.Drawing.Size(820, 29);
            this.comboBoxCompetences.TabIndex = 26;
            this.comboBoxCompetences.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetences_SelectedIndexChanged);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxStudent.ForeColor = System.Drawing.Color.White;
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.ItemHeight = 21;
            this.listBoxStudent.Location = new System.Drawing.Point(150, 243);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(820, 273);
            this.listBoxStudent.TabIndex = 33;
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
            this.buttonValider.TabIndex = 34;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelCompetences
            // 
            this.labelCompetences.AutoSize = true;
            this.labelCompetences.BackColor = System.Drawing.Color.Transparent;
            this.labelCompetences.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelCompetences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelCompetences.Location = new System.Drawing.Point(146, 135);
            this.labelCompetences.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompetences.Name = "labelCompetences";
            this.labelCompetences.Size = new System.Drawing.Size(144, 30);
            this.labelCompetences.TabIndex = 35;
            this.labelCompetences.Text = "Compétences";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelStudent.Location = new System.Drawing.Point(145, 210);
            this.labelStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(72, 30);
            this.labelStudent.TabIndex = 36;
            this.labelStudent.Text = "Elèves";
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.BackColor = System.Drawing.Color.Transparent;
            this.labelStatut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelStatut.Location = new System.Drawing.Point(145, 135);
            this.labelStatut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(193, 30);
            this.labelStatut.TabIndex = 38;
            this.labelStatut.Text = "Statut : Professeur";
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
            this.buttonDeconnection.TabIndex = 37;
            this.buttonDeconnection.Text = "Déconnexion";
            this.buttonDeconnection.UseVisualStyleBackColor = false;
            this.buttonDeconnection.Click += new System.EventHandler(this.buttonDeconnection_Click);
            // 
            // textBoxResource
            // 
            this.textBoxResource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResource.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxResource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxResource.Location = new System.Drawing.Point(150, 243);
            this.textBoxResource.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxResource.Name = "textBoxResource";
            this.textBoxResource.Size = new System.Drawing.Size(766, 22);
            this.textBoxResource.TabIndex = 44;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelDescription.Location = new System.Drawing.Point(145, 270);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(125, 30);
            this.labelDescription.TabIndex = 46;
            this.labelDescription.Text = "Description";
            // 
            // labelResourceTitle
            // 
            this.labelResourceTitle.AutoSize = true;
            this.labelResourceTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelResourceTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelResourceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelResourceTitle.Location = new System.Drawing.Point(145, 210);
            this.labelResourceTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResourceTitle.Name = "labelResourceTitle";
            this.labelResourceTitle.Size = new System.Drawing.Size(58, 30);
            this.labelResourceTitle.TabIndex = 47;
            this.labelResourceTitle.Text = "Titre";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDescription.Location = new System.Drawing.Point(378, 427);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(538, 150);
            this.richTextBoxDescription.TabIndex = 49;
            this.richTextBoxDescription.Text = "";
            // 
            // listBoxResources
            // 
            this.listBoxResources.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxResources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResources.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxResources.ForeColor = System.Drawing.Color.White;
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.ItemHeight = 21;
            this.listBoxResources.Location = new System.Drawing.Point(150, 427);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(199, 147);
            this.listBoxResources.TabIndex = 48;
            this.listBoxResources.SelectedIndexChanged += new System.EventHandler(this.listBoxResources_SelectedIndexChanged);
            // 
            // labelShowDescription
            // 
            this.labelShowDescription.AutoSize = true;
            this.labelShowDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelShowDescription.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelShowDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelShowDescription.Location = new System.Drawing.Point(373, 394);
            this.labelShowDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowDescription.Name = "labelShowDescription";
            this.labelShowDescription.Size = new System.Drawing.Size(125, 30);
            this.labelShowDescription.TabIndex = 53;
            this.labelShowDescription.Text = "Description";
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.BackColor = System.Drawing.Color.Transparent;
            this.labelResources.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelResources.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelResources.Location = new System.Drawing.Point(145, 394);
            this.labelResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(119, 30);
            this.labelResources.TabIndex = 50;
            this.labelResources.Text = "Ressources";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonAdd.Location = new System.Drawing.Point(930, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 40);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove.BackgroundImage")));
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRemove.Location = new System.Drawing.Point(930, 537);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(40, 40);
            this.buttonRemove.TabIndex = 55;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxDescription.Location = new System.Drawing.Point(150, 304);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(767, 86);
            this.textBoxDescription.TabIndex = 56;
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelShowDescription);
            this.Controls.Add(this.labelResources);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.listBoxResources);
            this.Controls.Add(this.labelResourceTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxResource);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.buttonDeconnection);
            this.Controls.Add(this.labelCompetences);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.comboBoxCompetences);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelStudent);
            this.Name = "Form23";
            this.Text = "Competences";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonCompetences;
        private System.Windows.Forms.Button buttonResources;
        private System.Windows.Forms.ComboBox comboBoxCompetences;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelCompetences;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.Button buttonDeconnection;
        private System.Windows.Forms.TextBox textBoxResource;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelResourceTitle;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.Label labelShowDescription;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}