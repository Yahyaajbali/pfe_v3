﻿
namespace test_framework
{
    partial class ClientListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridClt = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBoxClt = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.email_clt = new System.Windows.Forms.TextBox();
            this.tele_clt = new System.Windows.Forms.TextBox();
            this.nom_clt = new System.Windows.Forms.TextBox();
            this.cin_clt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClt)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.SkyBlue;
            this.button10.Location = new System.Drawing.Point(35, 505);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(183, 52);
            this.button10.TabIndex = 30;
            this.button10.Text = "Consulter BL";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.SkyBlue;
            this.button5.Location = new System.Drawing.Point(226, 505);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 52);
            this.button5.TabIndex = 28;
            this.button5.Text = "Consulter Factures";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridClt
            // 
            this.dataGridClt.AllowUserToAddRows = false;
            this.dataGridClt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridClt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridClt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClt.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridClt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridClt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridClt.Location = new System.Drawing.Point(137, 119);
            this.dataGridClt.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridClt.Name = "dataGridClt";
            this.dataGridClt.ReadOnly = true;
            this.dataGridClt.RowHeadersWidth = 51;
            this.dataGridClt.Size = new System.Drawing.Size(709, 378);
            this.dataGridClt.TabIndex = 27;
            this.dataGridClt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClt_CellClick);
            this.dataGridClt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClt_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "code client";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CIN ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Raison Social";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GSM";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "e-mail";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // searchBoxClt
            // 
            this.searchBoxClt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBoxClt.Location = new System.Drawing.Point(533, 86);
            this.searchBoxClt.Margin = new System.Windows.Forms.Padding(4);
            this.searchBoxClt.Name = "searchBoxClt";
            this.searchBoxClt.Size = new System.Drawing.Size(129, 21);
            this.searchBoxClt.TabIndex = 26;
            this.searchBoxClt.TextChanged += new System.EventHandler(this.searchBoxClt_TextChanged);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.MidnightBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.SkyBlue;
            this.button7.Location = new System.Drawing.Point(670, 80);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 31);
            this.button7.TabIndex = 25;
            this.button7.Text = "chercher";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.MidnightBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.SkyBlue;
            this.button8.Location = new System.Drawing.Point(696, 505);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(220, 52);
            this.button8.TabIndex = 24;
            this.button8.Text = "afficher tout les clients";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::test_framework.Properties.Resources.icons8_login_rounded_30;
            this.button1.Location = new System.Drawing.Point(885, 565);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAdd.Controls.Add(this.button12);
            this.panelAdd.Controls.Add(this.button4);
            this.panelAdd.Controls.Add(this.button3);
            this.panelAdd.Controls.Add(this.button11);
            this.panelAdd.Controls.Add(this.email_clt);
            this.panelAdd.Controls.Add(this.tele_clt);
            this.panelAdd.Controls.Add(this.nom_clt);
            this.panelAdd.Controls.Add(this.cin_clt);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.panelAdd.Location = new System.Drawing.Point(-4, -4);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(4);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(1065, 635);
            this.panelAdd.TabIndex = 34;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdd_Paint);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::test_framework.Properties.Resources.icons8_login_rounded_30;
            this.button12.Location = new System.Drawing.Point(937, 576);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 30);
            this.button12.TabIndex = 42;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.SkyBlue;
            this.button4.Location = new System.Drawing.Point(397, 443);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 36);
            this.button4.TabIndex = 41;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.SkyBlue;
            this.button3.Location = new System.Drawing.Point(505, 443);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 40;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.MidnightBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.SkyBlue;
            this.button11.Location = new System.Drawing.Point(607, 443);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 36);
            this.button11.TabIndex = 38;
            this.button11.Text = "Ajouter";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // email_clt
            // 
            this.email_clt.Location = new System.Drawing.Point(529, 340);
            this.email_clt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_clt.Name = "email_clt";
            this.email_clt.Size = new System.Drawing.Size(121, 21);
            this.email_clt.TabIndex = 37;
            // 
            // tele_clt
            // 
            this.tele_clt.Location = new System.Drawing.Point(529, 285);
            this.tele_clt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tele_clt.Name = "tele_clt";
            this.tele_clt.Size = new System.Drawing.Size(121, 21);
            this.tele_clt.TabIndex = 36;
            // 
            // nom_clt
            // 
            this.nom_clt.Location = new System.Drawing.Point(529, 226);
            this.nom_clt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nom_clt.Name = "nom_clt";
            this.nom_clt.Size = new System.Drawing.Size(121, 21);
            this.nom_clt.TabIndex = 35;
            // 
            // cin_clt
            // 
            this.cin_clt.Location = new System.Drawing.Point(529, 166);
            this.cin_clt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cin_clt.Name = "cin_clt";
            this.cin_clt.Size = new System.Drawing.Size(121, 21);
            this.cin_clt.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "GSM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nom / Raison Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "CIN / ID FISCALE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Liste des Client";
            // 
            // ClientListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1056, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridClt);
            this.Controls.Add(this.searchBoxClt);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientListe";
            this.Text = "ClientListe";
            this.Load += new System.EventHandler(this.ClientListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClt)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridClt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox searchBoxClt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox email_clt;
        private System.Windows.Forms.TextBox tele_clt;
        private System.Windows.Forms.TextBox nom_clt;
        private System.Windows.Forms.TextBox cin_clt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}