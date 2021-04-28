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
    public partial class ClientAjout : Form
    {

        connection ado = new connection();
        public ClientAjout()
        {
            InitializeComponent();
            button4.Enabled = false;
            button3.Enabled = false;
        }

        private void ClientAjout_Load(object sender, EventArgs e)
        {
            ado.Connect();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cin_clt.Text == "" || nom_clt.Text == "" || tele_clt.Text == "" || email_clt.Text == "")
            {
                MessageBox.Show("remplir tout les champs svp");
                return;
            }//making sure no input box is empty, gotta be full :)
            ado.cmd.CommandText = "insert into client(cin_clt, raisonsocial,tele_clt,email_clt) " +
                "values ('" + cin_clt.Text + "','" + nom_clt.Text + "','" +
                tele_clt.Text + "','" + email_clt.Text + "')";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery(); //adding new data to database

            MessageBox.Show("done");

            cin_clt.Text = "";
            nom_clt.Text = "";
            tele_clt.Text = "";
            email_clt.Text = "";
            //clearing textboxes for new entry
        }
    }
}
