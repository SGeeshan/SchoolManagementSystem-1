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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string encodePassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64 Encode" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = encodePassword(txtPassword.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True");
            con.Open();
            string sql = "INSERT INTO Test(Id,name,password) VALUES(5,'"+txtName.Text+"','"+pass+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
        }
    }
}
