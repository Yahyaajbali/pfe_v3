using System;
using System.Drawing;
using System.IO;
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
                strQr = Convert.FromBase64String(ado.dr["qr"].ToString());
                var Qr = byteArrayToImage(byteArrayIn: strQr);
                dataGridArt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(), ado.dr.GetValue(3).ToString(),
                    ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(), Qr);
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private byte[] strQr;

        private void ArticleCatalogue_Load(object sender, EventArgs e)
        {
            ado.Connect();

            dataGridArt.Rows.Clear();
            ado.cmd.CommandText = "select * from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                strQr = Convert.FromBase64String(ado.dr["qr"].ToString());
                var Qr = byteArrayToImage(byteArrayIn: strQr);
                dataGridArt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(), ado.dr.GetValue(3).ToString(),
                    ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(), Qr);
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridArt.Rows.Clear();
            ado.cmd.CommandText = "select * from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                strQr = Convert.FromBase64String(ado.dr["qr"].ToString());
                var Qr = byteArrayToImage(byteArrayIn: strQr);
                dataGridArt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(), ado.dr.GetValue(3).ToString(),
                    ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString(), Qr);
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }
    }
}