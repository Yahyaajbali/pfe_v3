using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_framework
{
    public partial class ArticleAdd : Form
    {
        connection ado = new connection();
        public ArticleAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            ado.cmd.CommandText = "select idf_fac_frs from facture_frs where idf_frs = " + comboBox2.Text;
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox3.Items.Add(ado.dr["idf_fac_frs"]);
            }
            ado.dr.Close();
        }

        private void ArticleAdd_Load(object sender, EventArgs e)
        {
            ado.Connect();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" ||
                   textBox6.Text == "" || textBox7.Text == "" ||
                   textBox8.Text == "" || textBox9.Text == "" || textBox11.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("empty textboxes");
                return;
            }
            ado.cmd.CommandText = "insert into facture_frs(idf_frs,idf_fac_frs, date_fac_frs) values (" + int.Parse(comboBox2.Text) + "," + int.Parse(textBox1.Text) + ",'" + dateTimePicker1.Text + "')";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();

            ado.cmd.CommandText = "insert into article(ref_art,idf_rayon,design_art,qte_stock,prix_ht_stock,taux_TVA) values (" + int.Parse(textBox4.Text) + "," + int.Parse(textBox8.Text) + ",'" + textBox9.Text + "'," + int.Parse(textBox6.Text)
                                  + "," + float.Parse(textBox7.Text)
                                  + "," + float.Parse(textBox11.Text) + ")";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();

            ado.cmd.CommandText = "insert into ligne_fac_frs(ref_art,idf_fac_frs, qte_achete,prix_achat) values (" + int.Parse(textBox4.Text) + "," + int.Parse(comboBox3.Text) +
                                  "," + int.Parse(textBox6.Text) + "," + float.Parse(textBox5.Text) + ")";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" ||
              textBox6.Text == "" || textBox7.Text == "" ||
              textBox8.Text == "" || textBox9.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("empty textboxes");
                return;
            }
            ado.cmd.CommandText = "insert into article(ref_art,idf_rayon,design_art,qte_stock,prix_ht_stock,taux_TVA) values (" + int.Parse(textBox4.Text) + "," + int.Parse(textBox8.Text) + ",'"
                                  + textBox9.Text + "'," + int.Parse(textBox6.Text)
                                  + "," + float.Parse(textBox7.Text)
                                  + "," + float.Parse(textBox11.Text) + ")";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();

            ado.cmd.CommandText = "insert into ligne_fac_frs(ref_art,idf_fac_frs, qte_achete,prix_achat) values (" + int.Parse(textBox4.Text) + "," + int.Parse(comboBox3.Text) +
                                  "," + int.Parse(textBox6.Text) + "," + float.Parse(textBox5.Text) + ")";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
        }
    }
}
