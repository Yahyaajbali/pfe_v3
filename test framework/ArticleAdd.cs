using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace test_framework
{
    public partial class ArticleAdd : Form
    {
        private connection ado = new connection();

        public ArticleAdd()
        {
            InitializeComponent();

            QrCodeEncodingOptions options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "select idf_frs from fournisseur where raison_social = '" + comboBox2.Text + "'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                textBox2.Text = ado.dr["idf_frs"].ToString();
            }
            ado.dr.Close();
        }

        private void ArticleAdd_Load(object sender, EventArgs e)
        {
            ado.Connect();
            comboBox2.Items.Clear();
            ado.cmd.CommandText = "select raison_social from fournisseur";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox2.Items.Add(ado.dr["raison_social"]);
            }
            ado.dr.Close();

            ado.cmd.CommandText = "select idf_rayon from rayon";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox1.Items.Add(ado.dr["idf_rayon"]);
            }
            ado.dr.Close();

            ado.cmd.CommandText = "select design_art from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                comboBox3.Items.Add(ado.dr["design_art"]);
            }
            ado.dr.Close();

        }

        private int lastFact = 0;
        private EncodingOptions options;

       private int RetrieveId()
        {
            int ID = 0;
            ado.cmd.CommandText = "select max(ref_art) as max from article";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                ID = int.Parse(ado.dr["max"].ToString());
            }
            return ID;
        }

        int qtt = 0;

        private int Retrieve(string s)
        {
            int c = 0;
            ado.cmd.CommandText = "select qte_stock from article where design_art = '"+s+"'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                c = int.Parse(ado.dr["qte_stock"].ToString());
            }
            ado.dr.Close();
            return c;
        }
        private void button12_Click(object sender, EventArgs e)
        {
           

            double pht = 0;
            double totalPHT = 0;

            for (int count = 0; count < dataGridView1.Rows.Count; count++)
            {
                pht = Convert.ToDouble(dataGridView1.Rows[count].Cells["Column4"].Value) * Convert.ToDouble(dataGridView1.Rows[count].Cells["Column3"].Value);
                totalPHT += pht;
            }

            double mntTVA = totalPHT * 0.2;
            double TTC = mntTVA + totalPHT;

            ado.cmd.CommandText = "insert into facture_frs(idf_frs,                      date_fac_frs, total_pht_fac_frs, taux_tva_fac_frs, montant_tva_fac_frs, total_ttc_fac_frs) values (" +
                                                        int.Parse(textBox2.Text) + "," + dateTimePicker1.Text + " ," + totalPHT + ",      " + 20 + ",                " + mntTVA + ", " + TTC + ")";

            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
            
            ado.cmd.CommandText = "select max(idf_fac_frs) as last from facture_frs";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                lastFact = int.Parse(ado.dr["last"].ToString());
            }
            ado.dr.Close();
            int rayon = int.Parse(comboBox1.Text);
            int rowCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {

                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()));
                var res2 = imageToByteArray(result);
                var img2str = Convert.ToBase64String(res2);
                string design = dataGridView1.Rows[i].Cells[0].Value.ToString();

                qtt = Retrieve(design);
                int qttnv = qtt + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                ado.cmd.CommandText = "update article set idf_rayon = " + rayon + " ,qte_stock = " + qttnv + " ,prix_ht_stock = " + float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + ",taux_TVA = " + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + " ,qr ='" + img2str + "' where design_art = '" + dataGridView1.Rows[i].Cells[0].Value.ToString()+"'";


                ado.cmd.Connection = ado.cn;
                ado.cmd.ExecuteNonQuery();

                int lastIdArt = RetrieveId();

                ado.cmd.CommandText = "insert into ligne_fac_frs(ref_art,idf_fac_frs,qte_achete,prix_achat) values (" +
                                        lastIdArt + "," +
                                        lastFact + "," + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "," +
                                        int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + ")";
            }
            MessageBox.Show("ajout terminer");
            vider();
            dataGridView1.Rows.Clear();
            
        }

        

        private void vider()
        {
            //textBox4.Clear();
            comboBox3.Text = ""; textBox6.Clear(); textBox5.Clear(); textBox7.Clear(); textBox11.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = double.Parse(textBox5.Text) * double.Parse(textBox6.Text);
            dataGridView1.Rows.Add(comboBox3.Text, textBox6.Text, total, float.Parse(textBox7.Text), textBox11.Text);
            vider();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vider();
        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ado.cmd.CommandText= "select prix_ht_stock from article where design_art = '"+comboBox3.Text+"'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                textBox7.Text = ado.dr["prix_ht_stock"].ToString();
            }
            ado.dr.Close();
        }
    }
}