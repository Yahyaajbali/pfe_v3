﻿using System;
using System.Windows.Forms;

namespace test_framework
{
    public partial class SfBl : Form
    {
        private connection ado = new connection();

        public SfBl()
        {
            InitializeComponent();
        }

        private void SfBl_Load(object sender, EventArgs e)
        {
            ado.Connect();

            ado.cmd.CommandText = "select idf_bl,date_liv, total_pht_bl, taux_tva_bl, montant_tva_bl, total_ttc_bl,commande.idf_cmnd, client.raisonsocial from bon_livraison inner join commande on commande.idf_cmnd = bon_livraison.idf_cmnd inner join client on client.code_clt = commande.code_clt where client.code_clt = " + ClientStuff.client;
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Numero BL";
            dataGridView1.Columns[1].Name = "Date BL";
            dataGridView1.Columns[2].Name = "Total HT";
            dataGridView1.Columns[3].Name = "Taux TVA";
            dataGridView1.Columns[4].Name = "Montant TVA";
            dataGridView1.Columns[5].Name = "Total TTC";
            dataGridView1.Columns[6].Name = "Numero de commande";
            dataGridView1.Columns[7].Name = "Raison Social";

            dataGridView1.Columns[0].Width = 136;
            dataGridView1.Columns[1].Width = 136;
            dataGridView1.Columns[2].Width = 136;
            dataGridView1.Columns[3].Width = 136; 
            dataGridView1.Columns[5].Width = 136; dataGridView1.Columns[7].Width = 136;
            dataGridView1.Columns[4].Width = 136; dataGridView1.Columns[6].Width = 136;
            
            while (ado.dr.Read())
            {
                label1.Text = "Bon de Livraison du client : "+ado.dr["raisonsocial"]+" .";
                dataGridView1.Rows.Add(ado.dr["idf_bl"], ado.dr["date_liv"], ado.dr["total_pht_bl"], ado.dr["taux_tva_bl"], ado.dr["montant_tva_bl"], ado.dr["total_ttc_bl"], ado.dr["idf_cmnd"], ado.dr["raisonsocial"]);
            }
            ado.dr.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ado.cmd.CommandText = "select idf_bl,ligne_bl.ref_art, article.design_art, qte_liv,prix_liv from ligne_bl inner join article on article.ref_art = ligne_bl.ref_art where idf_bl = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Numero BL";
            dataGridView1.Columns[1].Name = "Reference article";
            dataGridView1.Columns[2].Name = "Designation Article";
            dataGridView1.Columns[3].Name = "Qte Livré";
            dataGridView1.Columns[4].Name = "Prix HT";

            while (ado.dr.Read())
            {
                label1.Text = "Details du Bon de Livraison Numero : "+ado.dr["idf_bl"]+" .";
                dataGridView1.Rows.Add(ado.dr["idf_bl"], ado.dr["ref_art"], ado.dr["design_art"], ado.dr["qte_liv"], ado.dr["prix_liv"]);
            }
            ado.dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ado.cmd.CommandText = "select idf_bl,date_liv, total_pht_bl, taux_tva_bl, montant_tva_bl, total_ttc_bl,commande.idf_cmnd, client.raisonsocial from bon_livraison inner join commande on commande.idf_cmnd = bon_livraison.idf_cmnd inner join client on client.code_clt = commande.code_clt where client.code_clt = " + ClientStuff.client;
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Numero BL";
            dataGridView1.Columns[1].Name = "Date BL";
            dataGridView1.Columns[2].Name = "Total HT";
            dataGridView1.Columns[3].Name = "Taux TVA";
            dataGridView1.Columns[4].Name = "Montant TVA";
            dataGridView1.Columns[5].Name = "Total TTC";
            dataGridView1.Columns[6].Name = "Numero de commande";
            dataGridView1.Columns[7].Name = "Raison Social";

            while (ado.dr.Read())
            {
                label1.Text = "Bon de Livraison du client : " + ado.dr["raisonsocial"] + " .";
                dataGridView1.Rows.Add(ado.dr["idf_bl"], ado.dr["date_liv"], ado.dr["total_pht_bl"], ado.dr["taux_tva_bl"], ado.dr["montant_tva_bl"], ado.dr["total_ttc_bl"], ado.dr["idf_cmnd"], ado.dr["raisonsocial"]);
            }
            ado.dr.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int idf_bl = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "select bon_livraison.idf_bl as [numero BL],bon_livraison.date_liv as [date livraison],client.raisonsocial as [raison social],client.email_clt as [email client],client.code_clt as [code client],client.cin_clt as [cin client],article.design_art as [designation],article.ref_art as [reference]," +
                                  "ligne_bl.qte_liv as [quantite],ligne_bl.prix_liv as[PUHT],bon_livraison.montant_tva_bl as [montant TVA],bon_livraison.taux_tva_bl as [taux TVA],bon_livraison.total_pht_bl as [total PHT],bon_livraison.total_ttc_bl as [total TTC]" +
                                  "from bon_livraison inner join commande on commande.idf_cmnd = bon_livraison.idf_cmnd inner join client on client.code_clt = commande.code_clt inner join ligne_bl on ligne_bl.idf_bl = bon_livraison.idf_bl inner join article on article.ref_art = ligne_bl.ref_art where bon_livraison.idf_bl =" + idf_bl;
            ado.cmd.Connection = ado.cn;
            ado.sda.SelectCommand = ado.cmd;
            ado.sda.Fill(ado.dt);
            BL reportbl = new BL();
            Reports viewer = new Reports();
            reportbl.SetDataSource(ado.dt);
            viewer.crystalReportViewer1.ReportSource = reportbl;
            viewer.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idf_bl = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}