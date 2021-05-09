using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace test_framework
{
    public partial class ArticleSearch : Form
    {
        private connection ado = new connection();

        public ArticleSearch()
        {
            InitializeComponent();
        }

        private FilterInfoCollection FilterInfoCollection;
        private VideoCaptureDevice captureDevice;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                MessageBox.Show("search box is empty");
                return;
            }
            ado.cmd.CommandText = "select * from article where ref_art =" + int.Parse(searchBox.Text);
            ado.cmd.Connection = ado.cn;
            byte[] strQr;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                ref_art.Text = (ado.dr.GetValue(0)).ToString();
                rayon.Text = (ado.dr.GetValue(1)).ToString();
                design_art.Text = (ado.dr.GetValue(2)).ToString();
                qte_stock.Text = (ado.dr.GetValue(3)).ToString();
                prix_ht_stock.Text = (ado.dr.GetValue(4)).ToString();
                strQr = Convert.FromBase64String(ado.dr["qr"].ToString());
                var Qr = byteArrayToImage(byteArrayIn: strQr);
                pictureBox1.Image = Qr;
            }                   //take whats in searchbox and match with database, then print the result in labels
            ado.dr.Close();     //closes the reader
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ArticleSearch_Load(object sender, EventArgs e)
        {
            ado.Connect();
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
            {
                comboBox1.Items.Add(filterInfo.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

                if (result != null)
                {
                    label2.Text = result.ToString();
                    ado.cmd.CommandText = "select * from article where ref_art =" + int.Parse(label2.Text);
                    ado.cmd.Connection = ado.cn;
                    ado.dr = ado.cmd.ExecuteReader();
                    while (ado.dr.Read())
                    {
                        ref_art.Text = (ado.dr.GetValue(0)).ToString();
                        rayon.Text = (ado.dr.GetValue(1)).ToString();
                        design_art.Text = (ado.dr.GetValue(2)).ToString();
                        qte_stock.Text = (ado.dr.GetValue(3)).ToString();
                        prix_ht_stock.Text = (ado.dr.GetValue(4)).ToString();
                    }
                    ado.dr.Close();
                    timer1.Stop();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }
    }
}