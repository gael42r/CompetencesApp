namespace CompetencesApp
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonPromotionCompetenceBlocks = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonCompetenceBlock = new System.Windows.Forms.Button();
            this.buttonCompetence = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPromotion = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.comboBoxCompetences = new System.Windows.Forms.ComboBox();
            this.comboBoxCompetenceBlock = new System.Windows.Forms.ComboBox();
            this.comboBoxPromotion = new System.Windows.Forms.ComboBox();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelCombo = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxNoPromotionUsers = new System.Windows.Forms.ListBox();
            this.listBoxPromotionUsers = new System.Windows.Forms.ListBox();
            this.addUserPromotionButton = new System.Windows.Forms.Button();
            this.removeUserPromotionButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatut = new System.Windows.Forms.Label();
            this.buttonDeconnection = new System.Windows.Forms.Button();
            this.panelStudent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelStudent.Controls.Add(this.buttonPromotionCompetenceBlocks);
            this.panelStudent.Controls.Add(this.buttonUser);
            this.panelStudent.Controls.Add(this.buttonCompetenceBlock);
            this.panelStudent.Controls.Add(this.buttonCompetence);
            this.panelStudent.Controls.Add(this.panel1);
            this.panelStudent.Controls.Add(this.buttonPromotion);
            this.panelStudent.Controls.Add(this.buttonProfile);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(122, 600);
            this.panelStudent.TabIndex = 18;
            // 
            // buttonPromotionCompetenceBlocks
            // 
            this.buttonPromotionCompetenceBlocks.BackColor = System.Drawing.Color.Transparent;
            this.buttonPromotionCompetenceBlocks.FlatAppearance.BorderSize = 0;
            this.buttonPromotionCompetenceBlocks.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPromotionCompetenceBlocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPromotionCompetenceBlocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPromotionCompetenceBlocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPromotionCompetenceBlocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPromotionCompetenceBlocks.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonPromotionCompetenceBlocks.Location = new System.Drawing.Point(0, 425);
            this.buttonPromotionCompetenceBlocks.Name = "buttonPromotionCompetenceBlocks";
            this.buttonPromotionCompetenceBlocks.Size = new System.Drawing.Size(122, 80);
            this.buttonPromotionCompetenceBlocks.TabIndex = 32;
            this.buttonPromotionCompetenceBlocks.Text = "Promotions et blocs";
            this.buttonPromotionCompetenceBlocks.UseVisualStyleBackColor = false;
            this.buttonPromotionCompetenceBlocks.Click += new System.EventHandler(this.buttonPromotionCompetenceBlocks_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUser.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonUser.Location = new System.Drawing.Point(0, 121);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(122, 80);
            this.buttonUser.TabIndex = 31;
            this.buttonUser.Text = "Utilisateurs";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonCompetenceBlock
            // 
            this.buttonCompetenceBlock.BackColor = System.Drawing.Color.Transparent;
            this.buttonCompetenceBlock.FlatAppearance.BorderSize = 0;
            this.buttonCompetenceBlock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCompetenceBlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCompetenceBlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCompetenceBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompetenceBlock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompetenceBlock.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonCompetenceBlock.Location = new System.Drawing.Point(0, 349);
            this.buttonCompetenceBlock.Name = "buttonCompetenceBlock";
            this.buttonCompetenceBlock.Size = new System.Drawing.Size(122, 80);
            this.buttonCompetenceBlock.TabIndex = 30;
            this.buttonCompetenceBlock.Text = "Blocs de compétences";
            this.buttonCompetenceBlock.UseVisualStyleBackColor = false;
            this.buttonCompetenceBlock.Click += new System.EventHandler(this.buttonCompetenceBlock_Click);
            // 
            // buttonCompetence
            // 
            this.buttonCompetence.BackColor = System.Drawing.Color.Transparent;
            this.buttonCompetence.FlatAppearance.BorderSize = 0;
            this.buttonCompetence.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCompetence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCompetence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompetence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompetence.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonCompetence.Location = new System.Drawing.Point(0, 273);
            this.buttonCompetence.Name = "buttonCompetence";
            this.buttonCompetence.Size = new System.Drawing.Size(122, 80);
            this.buttonCompetence.TabIndex = 30;
            this.buttonCompetence.Text = "Compétences";
            this.buttonCompetence.UseVisualStyleBackColor = false;
            this.buttonCompetence.Click += new System.EventHandler(this.buttonCompetence_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 329);
            this.panel1.TabIndex = 11;
            // 
            // buttonPromotion
            // 
            this.buttonPromotion.BackColor = System.Drawing.Color.Transparent;
            this.buttonPromotion.FlatAppearance.BorderSize = 0;
            this.buttonPromotion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPromotion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPromotion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPromotion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPromotion.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonPromotion.Location = new System.Drawing.Point(0, 197);
            this.buttonPromotion.Name = "buttonPromotion";
            this.buttonPromotion.Size = new System.Drawing.Size(122, 80);
            this.buttonPromotion.TabIndex = 28;
            this.buttonPromotion.Text = "Promotions et étudiants";
            this.buttonPromotion.UseVisualStyleBackColor = false;
            this.buttonPromotion.Click += new System.EventHandler(this.buttonPromotion_Click);
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
            this.labelPrenom.TabIndex = 27;
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
            this.labelNom.TabIndex = 28;
            this.labelNom.Text = "NOM";
            // 
            // comboBoxCompetences
            // 
            this.comboBoxCompetences.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCompetences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetences.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxCompetences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.comboBoxCompetences.FormattingEnabled = true;
            this.comboBoxCompetences.Location = new System.Drawing.Point(150, 169);
            this.comboBoxCompetences.Name = "comboBoxCompetences";
            this.comboBoxCompetences.Size = new System.Drawing.Size(696, 29);
            this.comboBoxCompetences.TabIndex = 36;
            this.comboBoxCompetences.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetences_SelectedIndexChanged);
            // 
            // comboBoxCompetenceBlock
            // 
            this.comboBoxCompetenceBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetenceBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxCompetenceBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.comboBoxCompetenceBlock.FormattingEnabled = true;
            this.comboBoxCompetenceBlock.Location = new System.Drawing.Point(150, 169);
            this.comboBoxCompetenceBlock.Name = "comboBoxCompetenceBlock";
            this.comboBoxCompetenceBlock.Size = new System.Drawing.Size(696, 29);
            this.comboBoxCompetenceBlock.TabIndex = 30;
            this.comboBoxCompetenceBlock.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetenceBlock_SelectedIndexChanged);
            // 
            // comboBoxPromotion
            // 
            this.comboBoxPromotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPromotion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.comboBoxPromotion.FormattingEnabled = true;
            this.comboBoxPromotion.Location = new System.Drawing.Point(150, 169);
            this.comboBoxPromotion.Name = "comboBoxPromotion";
            this.comboBoxPromotion.Size = new System.Drawing.Size(696, 29);
            this.comboBoxPromotion.TabIndex = 27;
            this.comboBoxPromotion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPromotion_SelectedIndexChanged);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(150, 169);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(696, 29);
            this.comboBoxUsers.TabIndex = 28;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.BackColor = System.Drawing.Color.Transparent;
            this.labelCombo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelCombo.Location = new System.Drawing.Point(145, 135);
            this.labelCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(119, 30);
            this.labelCombo.TabIndex = 26;
            this.labelCombo.Text = "Promotion";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(884, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 34;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(930, 162);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(145, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Eleves";
            // 
            // listBoxNoPromotionUsers
            // 
            this.listBoxNoPromotionUsers.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxNoPromotionUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNoPromotionUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNoPromotionUsers.ForeColor = System.Drawing.Color.White;
            this.listBoxNoPromotionUsers.FormattingEnabled = true;
            this.listBoxNoPromotionUsers.ItemHeight = 21;
            this.listBoxNoPromotionUsers.Location = new System.Drawing.Point(150, 243);
            this.listBoxNoPromotionUsers.Name = "listBoxNoPromotionUsers";
            this.listBoxNoPromotionUsers.Size = new System.Drawing.Size(363, 273);
            this.listBoxNoPromotionUsers.TabIndex = 38;
            // 
            // listBoxPromotionUsers
            // 
            this.listBoxPromotionUsers.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxPromotionUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPromotionUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxPromotionUsers.ForeColor = System.Drawing.Color.White;
            this.listBoxPromotionUsers.FormattingEnabled = true;
            this.listBoxPromotionUsers.ItemHeight = 21;
            this.listBoxPromotionUsers.Location = new System.Drawing.Point(607, 243);
            this.listBoxPromotionUsers.Name = "listBoxPromotionUsers";
            this.listBoxPromotionUsers.Size = new System.Drawing.Size(363, 273);
            this.listBoxPromotionUsers.TabIndex = 39;
            // 
            // addUserPromotionButton
            // 
            this.addUserPromotionButton.BackColor = System.Drawing.Color.Transparent;
            this.addUserPromotionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUserPromotionButton.BackgroundImage")));
            this.addUserPromotionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserPromotionButton.FlatAppearance.BorderSize = 0;
            this.addUserPromotionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addUserPromotionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserPromotionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addUserPromotionButton.Location = new System.Drawing.Point(543, 302);
            this.addUserPromotionButton.Name = "addUserPromotionButton";
            this.addUserPromotionButton.Size = new System.Drawing.Size(40, 40);
            this.addUserPromotionButton.TabIndex = 40;
            this.addUserPromotionButton.UseVisualStyleBackColor = false;
            this.addUserPromotionButton.Click += new System.EventHandler(this.addUserPromotionButton_Click);
            // 
            // removeUserPromotionButton
            // 
            this.removeUserPromotionButton.BackColor = System.Drawing.Color.Transparent;
            this.removeUserPromotionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeUserPromotionButton.BackgroundImage")));
            this.removeUserPromotionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeUserPromotionButton.FlatAppearance.BorderSize = 0;
            this.removeUserPromotionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.removeUserPromotionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserPromotionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.removeUserPromotionButton.Location = new System.Drawing.Point(543, 348);
            this.removeUserPromotionButton.Name = "removeUserPromotionButton";
            this.removeUserPromotionButton.Size = new System.Drawing.Size(40, 40);
            this.removeUserPromotionButton.TabIndex = 41;
            this.removeUserPromotionButton.UseVisualStyleBackColor = false;
            this.removeUserPromotionButton.Click += new System.EventHandler(this.removeUserPromotionButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(150, 548);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(820, 40);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "Sauvegarder";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(602, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "Eleves dans la promotion";
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
            this.labelStatut.Size = new System.Drawing.Size(238, 30);
            this.labelStatut.TabIndex = 45;
            this.labelStatut.Text = "Statut : Administrateur";
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
            this.buttonDeconnection.TabIndex = 44;
            this.buttonDeconnection.Text = "Déconnexion";
            this.buttonDeconnection.UseVisualStyleBackColor = false;
            this.buttonDeconnection.Click += new System.EventHandler(this.buttonDeconnection_Click);
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.buttonDeconnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBoxCompetences);
            this.Controls.Add(this.removeUserPromotionButton);
            this.Controls.Add(this.comboBoxPromotion);
            this.Controls.Add(this.comboBoxCompetenceBlock);
            this.Controls.Add(this.addUserPromotionButton);
            this.Controls.Add(this.listBoxPromotionUsers);
            this.Controls.Add(this.listBoxNoPromotionUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.labelCombo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelStudent);
            this.Name = "Form22";
            this.Text = "Competences";
            this.panelStudent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ComboBox comboBoxPromotion;
        private System.Windows.Forms.Button buttonCompetenceBlock;
        private System.Windows.Forms.Button buttonCompetence;
        private System.Windows.Forms.Button buttonPromotion;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.ComboBox comboBoxCompetenceBlock;
        private System.Windows.Forms.Label labelCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox comboBoxCompetences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxNoPromotionUsers;
        private System.Windows.Forms.ListBox listBoxPromotionUsers;
        private System.Windows.Forms.Button addUserPromotionButton;
        private System.Windows.Forms.Button removeUserPromotionButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPromotionCompetenceBlocks;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.Button buttonDeconnection;
    }
}