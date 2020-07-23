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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            passwordHashing pass = new passwordHashing();
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                string str = "SELECT ac_id,nac_id FROM Academic,NonAcademic WHERE user_name='" + txtUserName.Text + "' and password='" + pass.encodePassword(txtPassword.Text) + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Success");

                }
                else
                {
                    MessageBox.Show("Invalide");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
