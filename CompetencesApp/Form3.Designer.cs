namespace CompetencesApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonAutoEval = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResources = new System.Windows.Forms.Button();
            this.labelCompetence = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelResources = new System.Windows.Forms.Label();
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.trackBarStudent = new System.Windows.Forms.TrackBar();
            this.labelEvaluationStudent = new System.Windows.Forms.Label();
            this.labelEvaluationNumberStudent = new System.Windows.Forms.Label();
            this.labelProof = new System.Windows.Forms.Label();
            this.listBoxProof = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEvaluationNumberTeacher = new System.Windows.Forms.Label();
            this.labelEvaluationTeacher = new System.Windows.Forms.Label();
            this.buttonAddProof = new System.Windows.Forms.Button();
            this.buttonRemoveProof = new System.Windows.Forms.Button();
            this.textBoxProof = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonValidCompetence = new System.Windows.Forms.Button();
            this.panelStudent.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelStudent.Controls.Add(this.buttonAutoEval);
            this.panelStudent.Controls.Add(this.panel1);
            this.panelStudent.Controls.Add(this.buttonResources);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudent.Location = new System.Drawing.Point(0, 54);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(122, 410);
            this.panelStudent.TabIndex = 21;
            // 
            // buttonAutoEval
            // 
            this.buttonAutoEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAutoEval.BackColor = System.Drawing.Color.Transparent;
            this.buttonAutoEval.FlatAppearance.BorderSize = 0;
            this.buttonAutoEval.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAutoEval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAutoEval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAutoEval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoEval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAutoEval.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonAutoEval.Location = new System.Drawing.Point(0, 0);
            this.buttonAutoEval.Name = "buttonAutoEval";
            this.buttonAutoEval.Size = new System.Drawing.Size(122, 205);
            this.buttonAutoEval.TabIndex = 2;
            this.buttonAutoEval.Text = "Evaluation";
            this.buttonAutoEval.UseVisualStyleBackColor = false;
            this.buttonAutoEval.Click += new System.EventHandler(this.buttonAutoEval_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 329);
            this.panel1.TabIndex = 11;
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
            this.buttonResources.Location = new System.Drawing.Point(0, 205);
            this.buttonResources.Name = "buttonResources";
            this.buttonResources.Size = new System.Drawing.Size(122, 205);
            this.buttonResources.TabIndex = 3;
            this.buttonResources.Text = "Ressources Nécessaires";
            this.buttonResources.UseVisualStyleBackColor = false;
            this.buttonResources.Click += new System.EventHandler(this.buttonResources_Click);
            // 
            // labelCompetence
            // 
            this.labelCompetence.AutoSize = true;
            this.labelCompetence.BackColor = System.Drawing.Color.Transparent;
            this.labelCompetence.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompetence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelCompetence.Location = new System.Drawing.Point(11, 12);
            this.labelCompetence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompetence.Name = "labelCompetence";
            this.labelCompetence.Size = new System.Drawing.Size(157, 32);
            this.labelCompetence.TabIndex = 13;
            this.labelCompetence.Text = "Compétence";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.labelCompetence);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 54);
            this.panel2.TabIndex = 20;
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
            this.buttonClose.Location = new System.Drawing.Point(663, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 37;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.BackColor = System.Drawing.Color.Transparent;
            this.labelResources.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelResources.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelResources.Location = new System.Drawing.Point(142, 71);
            this.labelResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(119, 30);
            this.labelResources.TabIndex = 35;
            this.labelResources.Text = "Ressources";
            // 
            // listBoxResources
            // 
            this.listBoxResources.BackColor = System.Drawing.Color.Gray;
            this.listBoxResources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResources.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxResources.ForeColor = System.Drawing.Color.White;
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.ItemHeight = 21;
            this.listBoxResources.Location = new System.Drawing.Point(147, 102);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(187, 336);
            this.listBoxResources.TabIndex = 36;
            this.listBoxResources.SelectedIndexChanged += new System.EventHandler(this.listBoxResources_SelectedIndexChanged);
            // 
            // trackBarStudent
            // 
            this.trackBarStudent.BackColor = System.Drawing.Color.Silver;
            this.trackBarStudent.Location = new System.Drawing.Point(147, 124);
            this.trackBarStudent.Maximum = 100;
            this.trackBarStudent.Name = "trackBarStudent";
            this.trackBarStudent.Size = new System.Drawing.Size(527, 45);
            this.trackBarStudent.TabIndex = 22;
            this.trackBarStudent.TickFrequency = 5;
            this.trackBarStudent.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labelEvaluationStudent
            // 
            this.labelEvaluationStudent.AutoSize = true;
            this.labelEvaluationStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelEvaluationStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelEvaluationStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelEvaluationStudent.Location = new System.Drawing.Point(142, 71);
            this.labelEvaluationStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvaluationStudent.Name = "labelEvaluationStudent";
            this.labelEvaluationStudent.Size = new System.Drawing.Size(75, 30);
            this.labelEvaluationStudent.TabIndex = 14;
            this.labelEvaluationStudent.Text = "Elève :";
            // 
            // labelEvaluationNumberStudent
            // 
            this.labelEvaluationNumberStudent.AutoSize = true;
            this.labelEvaluationNumberStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelEvaluationNumberStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelEvaluationNumberStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelEvaluationNumberStudent.Location = new System.Drawing.Point(221, 71);
            this.labelEvaluationNumberStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvaluationNumberStudent.Name = "labelEvaluationNumberStudent";
            this.labelEvaluationNumberStudent.Size = new System.Drawing.Size(43, 30);
            this.labelEvaluationNumberStudent.TabIndex = 23;
            this.labelEvaluationNumberStudent.Text = "0%";
            // 
            // labelProof
            // 
            this.labelProof.AutoSize = true;
            this.labelProof.BackColor = System.Drawing.Color.Transparent;
            this.labelProof.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelProof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelProof.Location = new System.Drawing.Point(142, 178);
            this.labelProof.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProof.Name = "labelProof";
            this.labelProof.Size = new System.Drawing.Size(202, 30);
            this.labelProof.TabIndex = 24;
            this.labelProof.Text = "Preuve(s) de travail";
            // 
            // listBoxProof
            // 
            this.listBoxProof.BackColor = System.Drawing.Color.Gray;
            this.listBoxProof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProof.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxProof.ForeColor = System.Drawing.Color.White;
            this.listBoxProof.FormattingEnabled = true;
            this.listBoxProof.ItemHeight = 21;
            this.listBoxProof.Location = new System.Drawing.Point(147, 254);
            this.listBoxProof.Name = "listBoxProof";
            this.listBoxProof.Size = new System.Drawing.Size(527, 105);
            this.listBoxProof.TabIndex = 33;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(147, 412);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(256, 40);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEvaluationNumberTeacher
            // 
            this.labelEvaluationNumberTeacher.AutoSize = true;
            this.labelEvaluationNumberTeacher.BackColor = System.Drawing.Color.Transparent;
            this.labelEvaluationNumberTeacher.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelEvaluationNumberTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelEvaluationNumberTeacher.Location = new System.Drawing.Point(618, 71);
            this.labelEvaluationNumberTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvaluationNumberTeacher.Name = "labelEvaluationNumberTeacher";
            this.labelEvaluationNumberTeacher.Size = new System.Drawing.Size(43, 30);
            this.labelEvaluationNumberTeacher.TabIndex = 41;
            this.labelEvaluationNumberTeacher.Text = "0%";
            // 
            // labelEvaluationTeacher
            // 
            this.labelEvaluationTeacher.AutoSize = true;
            this.labelEvaluationTeacher.BackColor = System.Drawing.Color.Transparent;
            this.labelEvaluationTeacher.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelEvaluationTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelEvaluationTeacher.Location = new System.Drawing.Point(486, 71);
            this.labelEvaluationTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvaluationTeacher.Name = "labelEvaluationTeacher";
            this.labelEvaluationTeacher.Size = new System.Drawing.Size(128, 30);
            this.labelEvaluationTeacher.TabIndex = 39;
            this.labelEvaluationTeacher.Text = "Professeur :";
            // 
            // buttonAddProof
            // 
            this.buttonAddProof.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddProof.BackgroundImage")));
            this.buttonAddProof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddProof.FlatAppearance.BorderSize = 0;
            this.buttonAddProof.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddProof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddProof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonAddProof.Location = new System.Drawing.Point(588, 175);
            this.buttonAddProof.Name = "buttonAddProof";
            this.buttonAddProof.Size = new System.Drawing.Size(40, 40);
            this.buttonAddProof.TabIndex = 38;
            this.buttonAddProof.UseVisualStyleBackColor = true;
            this.buttonAddProof.Click += new System.EventHandler(this.buttonAddProof_Click);
            // 
            // buttonRemoveProof
            // 
            this.buttonRemoveProof.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemoveProof.BackgroundImage")));
            this.buttonRemoveProof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveProof.FlatAppearance.BorderSize = 0;
            this.buttonRemoveProof.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRemoveProof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveProof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveProof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRemoveProof.Location = new System.Drawing.Point(634, 175);
            this.buttonRemoveProof.Name = "buttonRemoveProof";
            this.buttonRemoveProof.Size = new System.Drawing.Size(40, 40);
            this.buttonRemoveProof.TabIndex = 42;
            this.buttonRemoveProof.UseVisualStyleBackColor = true;
            this.buttonRemoveProof.Click += new System.EventHandler(this.buttonRemoveProof_Click);
            // 
            // textBoxProof
            // 
            this.textBoxProof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProof.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxProof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxProof.Location = new System.Drawing.Point(147, 222);
            this.textBoxProof.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxProof.Name = "textBoxProof";
            this.textBoxProof.Size = new System.Drawing.Size(527, 22);
            this.textBoxProof.TabIndex = 43;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.Gray;
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDescription.Location = new System.Drawing.Point(354, 102);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(320, 336);
            this.richTextBoxDescription.TabIndex = 44;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelDescription.Location = new System.Drawing.Point(349, 71);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(125, 30);
            this.labelDescription.TabIndex = 45;
            this.labelDescription.Text = "Description";
            // 
            // buttonValidCompetence
            // 
            this.buttonValidCompetence.BackColor = System.Drawing.Color.Peru;
            this.buttonValidCompetence.FlatAppearance.BorderSize = 0;
            this.buttonValidCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidCompetence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonValidCompetence.ForeColor = System.Drawing.Color.White;
            this.buttonValidCompetence.Location = new System.Drawing.Point(418, 412);
            this.buttonValidCompetence.Name = "buttonValidCompetence";
            this.buttonValidCompetence.Size = new System.Drawing.Size(256, 40);
            this.buttonValidCompetence.TabIndex = 46;
            this.buttonValidCompetence.Text = "Valider la compétence";
            this.buttonValidCompetence.UseVisualStyleBackColor = false;
            this.buttonValidCompetence.Click += new System.EventHandler(this.buttonValidCompetence_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 464);
            this.Controls.Add(this.buttonValidCompetence);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.listBoxResources);
            this.Controls.Add(this.labelResources);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxProof);
            this.Controls.Add(this.buttonRemoveProof);
            this.Controls.Add(this.labelEvaluationNumberTeacher);
            this.Controls.Add(this.labelEvaluationTeacher);
            this.Controls.Add(this.buttonAddProof);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxProof);
            this.Controls.Add(this.labelProof);
            this.Controls.Add(this.labelEvaluationNumberStudent);
            this.Controls.Add(this.labelEvaluationStudent);
            this.Controls.Add(this.trackBarStudent);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.Text = "Competences";
            this.panelStudent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button buttonAutoEval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResources;
        private System.Windows.Forms.Label labelCompetence;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBarStudent;
        private System.Windows.Forms.Label labelEvaluationStudent;
        private System.Windows.Forms.Label labelEvaluationNumberStudent;
        private System.Windows.Forms.Label labelProof;
        private System.Windows.Forms.ListBox listBoxProof;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEvaluationNumberTeacher;
        private System.Windows.Forms.Label labelEvaluationTeacher;
        private System.Windows.Forms.Button buttonAddProof;
        private System.Windows.Forms.Button buttonRemoveProof;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxProof;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonValidCompetence;
    }
}