﻿using System.Data;
using System.Data.SqlClient;

namespace test_framework
{
    internal class connection
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataTable dt = new DataTable();

        public void Connect()
        {
            if (cn.State == ConnectionState.Closed)
            {
                //yahya's
               // cn.ConnectionString = "Data Source=DESKTOP-GM7PTVC\\SQLEXPRESS01;Initial Catalog=gestion_stock;Integrated Security=True";
                //kwtr's
                cn.ConnectionString= "Data Source=DESKTOP-SFCSVTU\\SQLEXPRESS;Initial Catalog=magasin;Integrated Security=True";
                cn.Open();
            }
        }

        public void Disconnect()
        {
            cn.Close();
        }
    }
}