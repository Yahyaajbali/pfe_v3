using System;
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

        private connection ado = new connection();

        private void article_alim_Load(object sender, EventArgs e)
        {
            ado.Connect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "insert into article(design_art, prix_ht_stock,qte_stock) values ('" + textBox1.Text + "'," + float.Parse(textBox8.Text) + ",0)";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();

            MessageBox.Show("Done");
        }
    }
}