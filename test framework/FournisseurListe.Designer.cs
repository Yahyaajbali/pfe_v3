
namespace test_framework
{
    partial class FournisseurListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridFrs = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBoxFrs = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.ICE = new System.Windows.Forms.TextBox();
            this.raison_social = new System.Windows.Forms.TextBox();
            this.tele_frs = new System.Windows.Forms.TextBox();
            this.email_frs = new System.Windows.Forms.TextBox();
            this.registre_com = new System.Windows.Forms.TextBox();
            this.id_fiscale = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelAjout = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrs)).BeginInit();
            this.panelAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFrs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SkyBlue;
            this.dataGridFrs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFrs.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridFrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFrs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7,
            this.column8,
            this.column9});
            this.dataGridFrs.Location = new System.Drawing.Point(25, 120);
            this.dataGridFrs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridFrs.Name = "dataGridFrs";
            this.dataGridFrs.RowHeadersWidth = 51;
            this.dataGridFrs.Size = new System.Drawing.Size(1012, 378);
            this.dataGridFrs.TabIndex = 19;
            this.dataGridFrs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFrs_CellDoubleClick);
            // 
            // column1
            // 
            this.column1.HeaderText = "ID";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            this.column1.Width = 125;
            // 
            // column2
            // 
            this.column2.HeaderText = "ICE";
            this.column2.MinimumWidth = 6;
            this.column2.Name = "column2";
            this.column2.Width = 125;
            // 
            // column3
            // 
            this.column3.HeaderText = "Raison Social";
            this.column3.MinimumWidth = 6;
            this.column3.Name = "column3";
            this.column3.Width = 125;
            // 
            // column4
            // 
            this.column4.HeaderText = "GSM";
            this.column4.MinimumWidth = 6;
            this.column4.Name = "column4";
            this.column4.Width = 125;
            // 
            // column5
            // 
            this.column5.HeaderText = "E-mail";
            this.column5.MinimumWidth = 6;
            this.column5.Name = "column5";
            this.column5.Width = 125;
            // 
            // column6
            // 
            this.column6.HeaderText = "Registre Commercial";
            this.column6.MinimumWidth = 6;
            this.column6.Name = "column6";
            this.column6.Width = 125;
            // 
            // column7
            // 
            this.column7.HeaderText = "ID Fiscale";
            this.column7.MinimumWidth = 6;
            this.column7.Name = "column7";
            this.column7.Width = 125;
            // 
            // column8
            // 
            this.column8.HeaderText = "Adresse";
            this.column8.MinimumWidth = 6;
            this.column8.Name = "column8";
            this.column8.Width = 125;
            // 
            // column9
            // 
            this.column9.HeaderText = "Ville";
            this.column9.MinimumWidth = 6;
            this.column9.Name = "column9";
            this.column9.Width = 125;
            // 
            // searchBoxFrs
            // 
            this.searchBoxFrs.Location = new System.Drawing.Point(743, 60);
            this.searchBoxFrs.Margin = new System.Windows.Forms.Padding(4);
            this.searchBoxFrs.Name = "searchBoxFrs";
            this.searchBoxFrs.Size = new System.Drawing.Size(132, 25);
            this.searchBoxFrs.TabIndex = 17;
            this.searchBoxFrs.TextChanged += new System.EventHandler(this.searchBoxFrs_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MidnightBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.SkyBlue;
            this.button6.Location = new System.Drawing.Point(884, 58);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 16;
            this.button6.Text = "chercher";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.SkyBlue;
            this.button5.Location = new System.Drawing.Point(730, 506);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 52);
            this.button5.TabIndex = 15;
            this.button5.Text = "afficher tout les fournisseurs";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::test_framework.Properties.Resources.icons8_login_rounded_30;
            this.button12.Location = new System.Drawing.Point(946, 578);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 30);
            this.button12.TabIndex = 43;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // ICE
            // 
            this.ICE.Location = new System.Drawing.Point(515, 85);
            this.ICE.Margin = new System.Windows.Forms.Padding(4);
            this.ICE.Name = "ICE";
            this.ICE.Size = new System.Drawing.Size(132, 25);
            this.ICE.TabIndex = 43;
            // 
            // raison_social
            // 
            this.raison_social.Location = new System.Drawing.Point(515, 137);
            this.raison_social.Margin = new System.Windows.Forms.Padding(4);
            this.raison_social.Name = "raison_social";
            this.raison_social.Size = new System.Drawing.Size(132, 25);
            this.raison_social.TabIndex = 44;
            // 
            // tele_frs
            // 
            this.tele_frs.Location = new System.Drawing.Point(515, 294);
            this.tele_frs.Margin = new System.Windows.Forms.Padding(4);
            this.tele_frs.Name = "tele_frs";
            this.tele_frs.Size = new System.Drawing.Size(132, 25);
            this.tele_frs.TabIndex = 45;
            // 
            // email_frs
            // 
            this.email_frs.Location = new System.Drawing.Point(515, 346);
            this.email_frs.Margin = new System.Windows.Forms.Padding(4);
            this.email_frs.Name = "email_frs";
            this.email_frs.Size = new System.Drawing.Size(132, 25);
            this.email_frs.TabIndex = 46;
            // 
            // registre_com
            // 
            this.registre_com.Location = new System.Drawing.Point(515, 398);
            this.registre_com.Margin = new System.Windows.Forms.Padding(4);
            this.registre_com.Name = "registre_com";
            this.registre_com.Size = new System.Drawing.Size(132, 25);
            this.registre_com.TabIndex = 47;
            // 
            // id_fiscale
            // 
            this.id_fiscale.Location = new System.Drawing.Point(515, 452);
            this.id_fiscale.Margin = new System.Windows.Forms.Padding(4);
            this.id_fiscale.Name = "id_fiscale";
            this.id_fiscale.Size = new System.Drawing.Size(132, 25);
            this.id_fiscale.TabIndex = 48;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(515, 189);
            this.adresse.Margin = new System.Windows.Forms.Padding(4);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(268, 25);
            this.adresse.TabIndex = 49;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(515, 242);
            this.ville.Margin = new System.Windows.Forms.Padding(4);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(219, 25);
            this.ville.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "ICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Raison Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "GSM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Registre Commercial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID fiscale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 59;
            this.label9.Text = "Ville";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.SkyBlue;
            this.button3.Location = new System.Drawing.Point(501, 508);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 51);
            this.button3.TabIndex = 61;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MidnightBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.SkyBlue;
            this.button7.Location = new System.Drawing.Point(393, 508);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 51);
            this.button7.TabIndex = 62;
            this.button7.Text = "Supprimer";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::test_framework.Properties.Resources.icons8_login_rounded_30;
            this.button1.Location = new System.Drawing.Point(929, 593);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(609, 508);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 51);
            this.button2.TabIndex = 64;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelAjout
            // 
            this.panelAjout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAjout.Controls.Add(this.button2);
            this.panelAjout.Controls.Add(this.button1);
            this.panelAjout.Controls.Add(this.button7);
            this.panelAjout.Controls.Add(this.button3);
            this.panelAjout.Controls.Add(this.label9);
            this.panelAjout.Controls.Add(this.label8);
            this.panelAjout.Controls.Add(this.label1);
            this.panelAjout.Controls.Add(this.label6);
            this.panelAjout.Controls.Add(this.label5);
            this.panelAjout.Controls.Add(this.label4);
            this.panelAjout.Controls.Add(this.label3);
            this.panelAjout.Controls.Add(this.label2);
            this.panelAjout.Controls.Add(this.ville);
            this.panelAjout.Controls.Add(this.adresse);
            this.panelAjout.Controls.Add(this.id_fiscale);
            this.panelAjout.Controls.Add(this.registre_com);
            this.panelAjout.Controls.Add(this.email_frs);
            this.panelAjout.Controls.Add(this.tele_frs);
            this.panelAjout.Controls.Add(this.raison_social);
            this.panelAjout.Controls.Add(this.ICE);
            this.panelAjout.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.panelAjout.Location = new System.Drawing.Point(-9, -1);
            this.panelAjout.Margin = new System.Windows.Forms.Padding(4);
            this.panelAjout.Name = "panelAjout";
            this.panelAjout.Size = new System.Drawing.Size(1068, 641);
            this.panelAjout.TabIndex = 44;
            // 
            // FournisseurListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1059, 636);
            this.Controls.Add(this.panelAjout);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.dataGridFrs);
            this.Controls.Add(this.searchBoxFrs);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FournisseurListe";
            this.Text = "FournisseurListe";
            this.Load += new System.EventHandler(this.FournisseurListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrs)).EndInit();
            this.panelAjout.ResumeLayout(false);
            this.panelAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn column9;
        private System.Windows.Forms.TextBox searchBoxFrs;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox ICE;
        private System.Windows.Forms.TextBox raison_social;
        private System.Windows.Forms.TextBox tele_frs;
        private System.Windows.Forms.TextBox email_frs;
        private System.Windows.Forms.TextBox registre_com;
        private System.Windows.Forms.TextBox id_fiscale;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelAjout;
    }
}