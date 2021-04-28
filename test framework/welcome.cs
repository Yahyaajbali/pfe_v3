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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        connection ado = new connection();
        private void welcome_Load(object sender, EventArgs e)
        {
            ado.Connect();
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
            panelMainApp.Controls.Add(childForm);
            panelMainApp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ado.dt.Rows.Clear();
            ado.cmd.CommandText = "select count(*) from users where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            ado.cmd.Connection = ado.cn;
            ado.sda.SelectCommand = ado.cmd;
            ado.sda.Fill(ado.dt);
            //MessageBox.Show(ado.dt.Rows[0][0].ToString());
            if (ado.dt.Rows[0][0].ToString() == "1")
            {
                OpenForm(new Form1());
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("username or password incorrect");
                textBox1.Clear();
                textBox2.Clear();
                ado.dt.Rows.Clear();
                return;
            }
        }
    }
}
