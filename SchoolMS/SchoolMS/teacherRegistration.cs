using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace SchoolMS
{
    public partial class teacherRegistration : Form
    {
        public teacherRegistration()
        {
            InitializeComponent();
        }

        static string Encript(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToString(data);
            }
        }

        private void btnTSubmint_Click(object sender, EventArgs e)
        {
            string pass = Encript(txtPassword.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AdeeSL\Documents\SchoolMS.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Teacher(fulName,initial,dob,address,mobile,email,doe,userName,password) values ('" + txtFullName.Text + "','" + txtNameWithInitials.Text + "','" + dateDOB.Format + "','" + txtAddress1.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + dateDOE.Format + "','" + txtuserName.Text + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
           
            
        }
    }
}
