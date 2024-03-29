﻿using System;
using System.Windows.Forms;

namespace test_framework
{
    public partial class FournisseurListe : Form
    {
        private connection ado = new connection();

        public FournisseurListe()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridFrs.Rows.Clear();
            ado.cmd.CommandText = "select * from fournisseur where idf_frs like '%" + int.Parse(searchBoxFrs.Text) + "%' or ICE like like '%" + int.Parse(searchBoxFrs.Text) + "%' or raison_social like '%" + int.Parse(searchBoxFrs.Text) + "%' or tele_frs like '%" + int.Parse(searchBoxFrs.Text) + "%' or email_frs like '%" + int.Parse(searchBoxFrs.Text) + "%' or registre_com like '%" + int.Parse(searchBoxFrs.Text) + "%' or Id_fiscale like '%" + int.Parse(searchBoxFrs.Text) + "%' or ville like '%" + int.Parse(searchBoxFrs.Text) + "%' or adresse like '%" + int.Parse(searchBoxFrs.Text) + "%'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridFrs.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(1).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(),
                    ado.dr.GetValue(6).ToString(), ado.dr.GetValue(7).ToString(), ado.dr.GetValue(8).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

    //    dataGridClt.Rows.Clear();
    //        ado.cmd.CommandText = "select * from client where code_clt like '%" + searchBoxClt.Text + "%' or cin_clt like '%" + searchBoxClt.Text + "%' or raisonsocial like '%" + searchBoxClt.Text + "%' or tele_clt like '%" + searchBoxClt.Text + "%' or email_clt like '%" + searchBoxClt.Text + "%'";
    //        ado.cmd.Connection = ado.cn;
    //        ado.dr = ado.cmd.ExecuteReader();
    //        while (ado.dr.Read())
    //        {
    //            dataGridClt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(),
    //                ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
    //        }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
    //ado.dr.Close();//closes the reader

        private void FournisseurListe_Load(object sender, EventArgs e)
        {
            ado.Connect();

            button2.Enabled = false;
            panelAjout.Visible = false;

            dataGridFrs.Rows.Clear();
            ado.cmd.CommandText = "select * from fournisseur";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridFrs.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(1).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(),
                    ado.dr.GetValue(6).ToString(), ado.dr.GetValue(7).ToString(), ado.dr.GetValue(8).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridFrs.Rows.Clear();
            ado.cmd.CommandText = "select * from fournisseur";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridFrs.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(1).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(),
                    ado.dr.GetValue(6).ToString(), ado.dr.GetValue(7).ToString(), ado.dr.GetValue(8).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAjout.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ICE.Text == "" || raison_social.Text == "" || tele_frs.Text == "" || email_frs.Text == "" || registre_com.Text == "" || id_fiscale.Text == "" || adresse.Text == "" || ville.Text == "")
            {
                MessageBox.Show("remplir tout les champs svp");
                return;
            }//making sure no input box is empty, gotta be full :)
            ado.cmd.CommandText = "update fournisseur set ICE =" + ICE.Text + " , raison_social ='" + raison_social.Text + "' ,tele_frs" +
                " = '" + tele_frs.Text + "',email_frs= '" + email_frs.Text +
                "' ,registre_com= '" + registre_com.Text + "',Id_Fiscale='" + id_fiscale.Text + "' ,adresse='" + adresse.Text + "' " +
                ",ville= '" + ville.Text + "' where idf_frs =  " + currentFrs;

            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
            MessageBox.Show("modification applique");
        }

        private int currentFrs = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "delete from fournisseur where idf_frs =" + currentFrs;
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
            MessageBox.Show("suppression faite");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridFrs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ado.cmd.CommandText = "select * from fournisseur where idf_frs =" + dataGridFrs.Rows[e.RowIndex].Cells[0].Value;
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                currentFrs = int.Parse(ado.dr["idf_frs"].ToString());
                ICE.Text = ado.dr["ICE"].ToString();
                raison_social.Text = ado.dr["raison_social"].ToString();
                tele_frs.Text = ado.dr["tele_frs"].ToString();
                email_frs.Text = ado.dr["email_frs"].ToString();
                registre_com.Text = ado.dr["registre_com"].ToString();
                id_fiscale.Text = ado.dr["id_fiscale"].ToString();
                adresse.Text = ado.dr["adresse"].ToString();
                ville.Text = ado.dr["ville"].ToString();
            }
            ado.dr.Close();
            panelAjout.Visible = true;
        }

        private void searchBoxFrs_TextChanged(object sender, EventArgs e)
        {
            dataGridFrs.Rows.Clear();
            ado.cmd.CommandText = "select * from fournisseur where idf_frs like '%" + searchBoxFrs.Text + "%' or ICE like '%" + searchBoxFrs.Text + "%' or raison_social like '%" + searchBoxFrs.Text + "%' or tele_frs like '%" + searchBoxFrs.Text + "%' or email_frs like '%" + searchBoxFrs.Text + "%' or registre_com like '%" + searchBoxFrs.Text + "%' or Id_fiscale like '%" + searchBoxFrs.Text + "%' or ville like '%" + searchBoxFrs.Text + "%' or adresse like '%" + searchBoxFrs.Text + "%'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridFrs.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(1).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(),
                    ado.dr.GetValue(6).ToString(), ado.dr.GetValue(7).ToString(), ado.dr.GetValue(8).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }
    }
}