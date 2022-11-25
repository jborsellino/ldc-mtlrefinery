namespace Suncor_LdtConduitesUI
{
    partial class ListeDesConduitesMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.champ2Text = new System.Windows.Forms.TextBox();
            this.champ2ComboBox = new System.Windows.Forms.ComboBox();
            this.champ1Text = new System.Windows.Forms.TextBox();
            this.champ1ComboBox = new System.Windows.Forms.ComboBox();
            this.uniteText = new System.Windows.Forms.TextBox();
            this.rechercheConduiteButton = new System.Windows.Forms.Button();
            this.serviceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sequentielText = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvConduites = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNombreConduitesAffichees = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ordreText = new System.Windows.Forms.TextBox();
            this.ingenieurText = new System.Windows.Forms.TextBox();
            this.dateMiseaJourText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modifierLaSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduites)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(2745, 303);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.champ2Text);
            this.groupBox1.Controls.Add(this.champ2ComboBox);
            this.groupBox1.Controls.Add(this.champ1Text);
            this.groupBox1.Controls.Add(this.champ1ComboBox);
            this.groupBox1.Controls.Add(this.uniteText);
            this.groupBox1.Controls.Add(this.rechercheConduiteButton);
            this.groupBox1.Controls.Add(this.serviceText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sequentielText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche de conduite";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resetButton.Location = new System.Drawing.Point(161, 110);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 26);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Réinitialiser";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // champ2Text
            // 
            this.champ2Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.champ2Text.Location = new System.Drawing.Point(162, 85);
            this.champ2Text.Name = "champ2Text";
            this.champ2Text.Size = new System.Drawing.Size(111, 22);
            this.champ2Text.TabIndex = 9;
            // 
            // champ2ComboBox
            // 
            this.champ2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.champ2ComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.champ2ComboBox.FormattingEnabled = true;
            this.champ2ComboBox.Location = new System.Drawing.Point(12, 86);
            this.champ2ComboBox.Name = "champ2ComboBox";
            this.champ2ComboBox.Size = new System.Drawing.Size(144, 21);
            this.champ2ComboBox.TabIndex = 7;
            // 
            // champ1Text
            // 
            this.champ1Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.champ1Text.Location = new System.Drawing.Point(162, 60);
            this.champ1Text.Name = "champ1Text";
            this.champ1Text.Size = new System.Drawing.Size(111, 22);
            this.champ1Text.TabIndex = 6;
            // 
            // champ1ComboBox
            // 
            this.champ1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.champ1ComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.champ1ComboBox.FormattingEnabled = true;
            this.champ1ComboBox.Location = new System.Drawing.Point(12, 61);
            this.champ1ComboBox.Name = "champ1ComboBox";
            this.champ1ComboBox.Size = new System.Drawing.Size(144, 21);
            this.champ1ComboBox.TabIndex = 4;
            // 
            // uniteText
            // 
            this.uniteText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uniteText.Location = new System.Drawing.Point(12, 35);
            this.uniteText.MaxLength = 3;
            this.uniteText.Name = "uniteText";
            this.uniteText.Size = new System.Drawing.Size(65, 22);
            this.uniteText.TabIndex = 1;
            this.uniteText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uniteText_KeyPress);
            // 
            // rechercheConduiteButton
            // 
            this.rechercheConduiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rechercheConduiteButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rechercheConduiteButton.Location = new System.Drawing.Point(12, 110);
            this.rechercheConduiteButton.Name = "rechercheConduiteButton";
            this.rechercheConduiteButton.Size = new System.Drawing.Size(144, 26);
            this.rechercheConduiteButton.TabIndex = 10;
            this.rechercheConduiteButton.Text = "Recherche";
            this.rechercheConduiteButton.UseVisualStyleBackColor = false;
            this.rechercheConduiteButton.Click += new System.EventHandler(this.rechercheConduiteButton_Click);
            // 
            // serviceText
            // 
            this.serviceText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.serviceText.Location = new System.Drawing.Point(83, 35);
            this.serviceText.MaxLength = 8;
            this.serviceText.Name = "serviceText";
            this.serviceText.Size = new System.Drawing.Size(46, 22);
            this.serviceText.TabIndex = 2;
            this.serviceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serviceText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(86, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(140, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Séquentiel ou Conduite";
            // 
            // sequentielText
            // 
            this.sequentielText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sequentielText.Location = new System.Drawing.Point(135, 35);
            this.sequentielText.Name = "sequentielText";
            this.sequentielText.Size = new System.Drawing.Size(138, 22);
            this.sequentielText.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvConduites);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Size = new System.Drawing.Size(2422, 303);
            this.splitContainer2.SplitterDistance = 274;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvConduites
            // 
            this.dgvConduites.AllowUserToAddRows = false;
            this.dgvConduites.AllowUserToDeleteRows = false;
            this.dgvConduites.AllowUserToResizeColumns = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(182)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(92)))), ((int)(((byte)(146)))));
            this.dgvConduites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvConduites.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConduites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvConduites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConduites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConduites.Location = new System.Drawing.Point(0, 0);
            this.dgvConduites.MultiSelect = false;
            this.dgvConduites.Name = "dgvConduites";
            this.dgvConduites.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(182)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(92)))), ((int)(((byte)(146)))));
            this.dgvConduites.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvConduites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConduites.Size = new System.Drawing.Size(2422, 274);
            this.dgvConduites.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNombreConduitesAffichees});
            this.statusStrip.Location = new System.Drawing.Point(0, 281);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(2745, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelNombreConduitesAffichees
            // 
            this.toolStripStatusLabelNombreConduitesAffichees.Name = "toolStripStatusLabelNombreConduitesAffichees";
            this.toolStripStatusLabelNombreConduitesAffichees.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelNombreConduitesAffichees.Text = "toolStripStatusLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modifierLaSelectionButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateMiseaJourText);
            this.groupBox2.Controls.Add(this.ingenieurText);
            this.groupBox2.Controls.Add(this.ordreText);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 105);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier la sélection";
            // 
            // ordreText
            // 
            this.ordreText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ordreText.Location = new System.Drawing.Point(127, 21);
            this.ordreText.MaxLength = 255;
            this.ordreText.Name = "ordreText";
            this.ordreText.Size = new System.Drawing.Size(90, 22);
            this.ordreText.TabIndex = 2;
            // 
            // ingenieurText
            // 
            this.ingenieurText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ingenieurText.Location = new System.Drawing.Point(127, 45);
            this.ingenieurText.MaxLength = 100;
            this.ingenieurText.Name = "ingenieurText";
            this.ingenieurText.Size = new System.Drawing.Size(90, 22);
            this.ingenieurText.TabIndex = 3;
            // 
            // dateMiseaJourText
            // 
            this.dateMiseaJourText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dateMiseaJourText.Location = new System.Drawing.Point(127, 69);
            this.dateMiseaJourText.MaxLength = 10;
            this.dateMiseaJourText.Name = "dateMiseaJourText";
            this.dateMiseaJourText.Size = new System.Drawing.Size(90, 22);
            this.dateMiseaJourText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(10, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ordre / Commentaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(56, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ing. / Resp.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(42, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Émission";
            // 
            // modifierLaSelectionButton
            // 
            this.modifierLaSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.modifierLaSelectionButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modifierLaSelectionButton.Location = new System.Drawing.Point(223, 21);
            this.modifierLaSelectionButton.Name = "modifierLaSelectionButton";
            this.modifierLaSelectionButton.Size = new System.Drawing.Size(58, 70);
            this.modifierLaSelectionButton.TabIndex = 12;
            this.modifierLaSelectionButton.Text = "GO!";
            this.modifierLaSelectionButton.UseVisualStyleBackColor = false;
            this.modifierLaSelectionButton.Click += new System.EventHandler(this.ModifierLaSelectionButton_Click);
            // 
            // ListeDesConduitesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2745, 303);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListeDesConduitesMainForm";
            this.Text = "Liste des conduites - Raffinerie de Montréal";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduites)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox champ2Text;
        private System.Windows.Forms.ComboBox champ2ComboBox;
        private System.Windows.Forms.TextBox champ1Text;
        private System.Windows.Forms.ComboBox champ1ComboBox;
        public System.Windows.Forms.TextBox uniteText;
        private System.Windows.Forms.Button rechercheConduiteButton;
        public System.Windows.Forms.TextBox serviceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox sequentielText;
        public System.Windows.Forms.DataGridView dgvConduites;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNombreConduitesAffichees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button modifierLaSelectionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox dateMiseaJourText;
        public System.Windows.Forms.TextBox ingenieurText;
        public System.Windows.Forms.TextBox ordreText;
    }
}
