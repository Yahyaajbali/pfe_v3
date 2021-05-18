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
    public partial class article_alim : Form
    {
        public article_alim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        connection ado = new connection();
        private void article_alim_Load(object sender, EventArgs e)
        {
            ado.Connect();

            ado.cmd.CommandText = "select design_art from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox2.Items.Add(ado.dr["design_art"]);
            }
            ado.dr.Close();
        }
        int qteold = 0;
        int qtenew = 0;
        int qtefnl = 0;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ado.cmd.CommandText = "select ref_art, qte_stock, prix_ht_stock from Article where design_art = '" + comboBox2.Text+"'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                qteold = int.Parse(ado.dr["qte_stock"].ToString());
                textBox5.Text = ado.dr["ref_art"].ToString();
                textBox6.Text = ado.dr["qte_stock"].ToString();
                textBox8.Text = ado.dr["prix_ht_stock"].ToString();
            }
            ado.dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qtenew = int.Parse(textBox7.Text);
            qtefnl = qteold + qtenew;

            ado.cmd.CommandText = "update article set qte_stock = " + qtefnl + ",prix_ht_stock =" + textBox8.Text + " where ref_art = " + textBox5.Text;
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
        }
    }
}
