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
    public partial class ClientListe : Form
    {
        connection ado = new connection();
 
        public ClientListe()
        {
            InitializeComponent();
            panelAdd.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridClt.Rows.Clear();
            ado.cmd.CommandText = "select * from client where code_clt like '%" + searchBoxClt.Text + "%' or cin_clt like '%" + searchBoxClt.Text + "%' or raisonsocial like '%" + searchBoxClt.Text + "%' or tele_clt like '%" + searchBoxClt.Text + "%' or email_clt like '%" + searchBoxClt.Text + "%'";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridClt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private void ClientListe_Load(object sender, EventArgs e)
        {
            ado.Connect();
            dataGridClt.Rows.Clear();
            ado.cmd.CommandText = "select * from client";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridClt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridClt.Rows.Clear();
            ado.cmd.CommandText = "select * from client";
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                dataGridClt.Rows.Add(ado.dr.GetValue(0).ToString(), ado.dr.GetValue(2).ToString(),
                    ado.dr.GetValue(3).ToString(), ado.dr.GetValue(4).ToString(), ado.dr.GetValue(5).ToString());
            }//gets input from the searchbox and matches it to the database then prints the matched data in the datagrid
            ado.dr.Close();//closes the reader
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (cin_clt.Text == "" || nom_clt.Text == "" || tele_clt.Text == "" || email_clt.Text == "")
            {
                MessageBox.Show("remplir tout les champs svp");
                return;
            }//making sure no input box is empty, gotta be full :)
            ado.cmd.CommandText = "update client set cin_clt = '" + cin_clt.Text + "', raisonsocial = '" + nom_clt.Text + "', tele_clt = '" + tele_clt.Text + "', email_clt = '" + email_clt.Text + "' where code_clt = " + currentClt;
            //"insert into client(cin_clt, nom_clt,tele_clt,email_clt) " +
            //    "values (" + cin_clt.Text + "','" + nom_clt.Text + "','" +
            //    tele_clt.Text + "','" + email_clt.Text + "')";
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery(); //adding new data to database

            MessageBox.Show("done");
        }
        private int currentClt = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "delete from client where code_clt =" + currentClt;
            ado.cmd.Connection = ado.cn;
            ado.cmd.ExecuteNonQuery();
            MessageBox.Show("suppression faite");
        }
        private void ShowSub(Panel panel)
        {
            if (panel.Visible == false) panel.Visible = true;
            else panel.Visible = false;
        }

        private void dataGridClt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ado.cmd.CommandText = "select * from client where code_clt =" + dataGridClt.Rows[e.RowIndex].Cells[0].Value;
            ado.cmd.Connection = ado.cn;
            ado.dr = ado.cmd.ExecuteReader();
            while (ado.dr.Read())
            {
                currentClt = int.Parse(ado.dr["code_clt"].ToString());
                cin_clt.Text = ado.dr["cin_clt"].ToString();
                nom_clt.Text = ado.dr["raisonsocial"].ToString();
                tele_clt.Text = ado.dr["tele_clt"].ToString();
                email_clt.Text = ado.dr["email_clt"].ToString();
            }
            ado.dr.Close();
            ShowSub(panelAdd);
            button11.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
        }

        private void dataGridClt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientStuff.client = Convert.ToInt32(dataGridClt.Rows[e.RowIndex].Cells[0].Value);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SfCommande>().Count() == 1)
            {
                Application.OpenForms.OfType<SfCommande>().First().Close();
            }
            SfCommande sousform3 = new SfCommande();
            sousform3.ShowDialog();
        }
    }
}
