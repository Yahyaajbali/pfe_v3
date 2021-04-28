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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LaunchDesign();
        }

        private void LaunchDesign()
        {
            panelArticle.Visible = false;
            panelFournisseur.Visible = false;
            panelClient.Visible = false;
        }

        private void HideSub()
        {
            if (panelArticle.Visible == true) panelArticle.Visible = false;
            if (panelClient.Visible == true) panelClient.Visible = false;
            if (panelFournisseur.Visible == true) panelFournisseur.Visible = false;
        }

        private void ShowSub(Panel panel)
        {
            if (panel.Visible == false) panel.Visible = true;
            else panel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideSub();
            ShowSub(panelArticle);
            

        }

        private Form activeForm = null;
        private void OpenForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new ArticleSearch());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm(new ArticleCatalogue());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenForm(new ArticleAdd());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSub();
            ShowSub(panelClient);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            HideSub();
            ShowSub(panelFournisseur);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenForm(new ClientListe());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenForm(new ClientAjout());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenForm(new FournisseurListe());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new FournisseurAjout());
        }
    }
}
