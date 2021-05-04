using System;
using System.Windows.Forms;

namespace test_framework
{
    public partial class ArticleCatalogue : Form
    {
        private connection ado = new connection();

        public ArticleCatalogue()
        {
            InitializeComponent();
        }

        private void ShowSub(Panel panel)
        {
            if (panel.Visible == false) panel.Visible = true;
            else panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridArt.Rows.Clear();
            ado.cmd.CommandText = "select * from article where ref_Art = " + int.Parse(searchBoxArt.Text);
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridArt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(), ado.dr.GetValue(3).ToString(),
                    ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private void ArticleCatalogue_Load(object sender, EventArgs e)
        {
            ado.Connect();

            dataGridArt.Rows.Clear();
            ado.cmd.CommandText = "select * from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridArt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(), ado.dr.GetValue(3).ToString(),
                    ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridArt.Rows.Clear();
            ado.cmd.CommandText = "select * from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridArt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(), ado.dr.GetValue(3).ToString(),
                    ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }
    }
}