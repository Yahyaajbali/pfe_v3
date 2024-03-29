﻿using System;
using System.Windows.Forms;

namespace test_framework
{
    public partial class Commandes : Form
    {
        private connection ado = new connection();

        public Commandes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int qtestock = 0;
            ado.cmd.CommandText = "select qte_stock from Article where ref_art = " + int.Parse(textBox5.Text);
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                qtestock = int.Parse(ado.dr["qte_stock"].ToString());
            }
            ado.dr.Close();
            if (qtestock >= int.Parse(textBox7.Text))
            {
                dataGridView1.Rows.Add( textBox5.Text,comboBox2.Text, textBox7.Text, textBox8.Text, (float.Parse(textBox7.Text) * float.Parse(textBox8.Text)));
            }
            else
            {
                MessageBox.Show("quantite stock inferieur a quantite vendu!!");
                textBox7.Clear();
                return;
            }
        }

        private void Commandes_Load(object sender, EventArgs e)
        {
            ado.Connect();
            ado.cmd.CommandText = "select raisonsocial from client";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox1.Items.Add(ado.dr["raisonsocial"]);
            }
            ado.dr.Close();

            ado.cmd.CommandText = "select design_art from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox2.Items.Add(ado.dr["design_art"]);
            }
            ado.dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "select ref_art, qte_stock, prix_ht_stock from Article where design_art = '" + comboBox2.Text+"'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                textBox5.Text = ado.dr["ref_art"].ToString();
                textBox6.Text = ado.dr["qte_stock"].ToString();
                textBox8.Text = ado.dr["prix_ht_stock"].ToString();
            }
            ado.dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "select code_clt from Client where raisonsocial = '" + comboBox1.Text + "'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                textBox2.Text = ado.dr["code_clt"].ToString();
            }
            ado.dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); comboBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); comboBox2.Text = "";
            comboBox1.Text = "";
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double pht = 0;
            double sum1 = 0;
 
            for (int count = 0; count < dataGridView1.Rows.Count; count++)
            {
                pht = Convert.ToDouble(dataGridView1.Rows[count].Cells["Column4"].Value) * Convert.ToDouble(dataGridView1.Rows[count].Cells["Column3"].Value);
                sum1 += pht;
            }
            //textBox5.Text = sum1.ToString();
            double sum2 = sum1 * 0.2;
            //textBox6.Text = sum2.ToString();
            double totalttc = sum1 + sum2;

            ado.cmd.CommandText = "insert into commande(code_clt, date_cmnd) values(" + int.Parse(textBox2.Text) + ", '" + dateTimePicker1.Text + "')";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();

            int lastCMD = 0;
            ado.cmd.CommandText = "select max(idf_cmnd) from commande";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                lastCMD = int.Parse(ado.dr.GetValue(0).ToString());
            }
            ado.dr.Close();

            // MessageBox.Show(dateTimePicker1.Text);
            ado.cmd.CommandText = "insert into bon_livraison(idf_cmnd, date_liv, total_pht_bl, montant_tva_bl, taux_tva_bl, total_ttc_bl) values (" + lastCMD + ", '" + dateTimePicker1.Text + "' , " + sum1 + "," + sum2 + "," + 20 + "," + totalttc + ")";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();

            int lastIDF = 0;
            ado.cmd.CommandText = "select max(idf_bl) from bon_livraison";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                lastIDF = int.Parse(ado.dr.GetValue(0).ToString());
            }
            ado.dr.Close();

            //MessageBox.Show(lastID.ToString());
            int rowCount = dataGridView1.Rows.Count;
            //MessageBox.Show(rowCount.ToString());
            for (int i = 0; i < rowCount; i++)
            {
                ado.cmd.CommandText = "insert into ligne_bl(ref_art, idf_bl, qte_liv, prix_liv) values (" + int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString())
                                        + "," + lastIDF + ", " + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "," + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + ")";
                ado.cmd.Connection = ado.cn;
                ado.cmd.ExecuteNonQuery();

                ado.cmd.CommandText = "insert into ligne_cmnd_clt(ref_art, idf_cmnd, qte_commande) values (" + int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString())
                                        + "," + lastCMD + ", " + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + ")";
                ado.cmd.Connection = ado.cn;
                ado.cmd.ExecuteNonQuery();

                int beforeStock = 0;
                ado.cmd.CommandText = "select qte_stock from article where ref_art =" + dataGridView1.Rows[i].Cells[0].Value;
                ado.cmd.Connection = ado.cn;
                ado.dr = ado.cmd.ExecuteReader();
                while (ado.dr.Read())
                {
                    beforeStock = int.Parse(ado.dr.GetValue(0).ToString());
                }
                ado.dr.Close();

                int currentStock = beforeStock - int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                ado.cmd.CommandText = "update Article set qte_stock = " + currentStock + "where ref_art = " + dataGridView1.Rows[i].Cells[0].Value;
                ado.cmd.Connection = ado.cn;
                ado.cmd.ExecuteNonQuery();
            }
            MessageBox.Show("ajout avec success");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ado.cmd.CommandText = "select qte_stock from Article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                textBox6.Text = ado.dr["qte_stock"].ToString();
            }
            ado.dr.Close();
        }
    }
}