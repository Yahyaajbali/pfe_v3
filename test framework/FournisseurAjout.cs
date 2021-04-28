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
    public partial class FournisseurAjout : Form
    {
        connection ado = new connection();
        public FournisseurAjout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ICE.Text == "" || raison_social.Text == "" || tele_frs.Text == "" || email_frs.Text == "" || registre_com.Text == "" || id_fiscale.Text == "" || adresse.Text == "" || ville.Text == "")
            {
                MessageBox.Show("remplir tout les champs svp");
                return;
            }//making sure no input box is empty, gotta be full :)
            ado.cmd.CommandText = "insert into fournisseur(ICE, raison_social,tele_frs,email_frs,registre_com,Id_Fiscale,adresse,ville) " +
                "values (" + ICE.Text + "','" + raison_social.Text + "','" + tele_frs.Text + "','" +
                email_frs.Text + "','" + registre_com.Text + "','" + id_fiscale.Text + "','" + adresse.Text + "','" +
                ville.Text + "')";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery(); //adding new data to database

            MessageBox.Show("done");

            ICE.Text = "";
            raison_social.Text = "";
            tele_frs.Text = "";
            email_frs.Text = "";
            registre_com.Text = "";
            id_fiscale.Text = "";
            adresse.Text = "";
            ville.Text = ""; //clearing textboxes for new entry
        }

        private void FournisseurAjout_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
