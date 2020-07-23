using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True");
            con.Open();
            string sql = "SELECT Id FROM Test WHERE name='" + txtname.Text + "' and password='" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Home h = new Home();
                h.ShowDialog();
             
            }
            else
            {
                MessageBox.Show("Invalide");
            }
        }
    }
}
