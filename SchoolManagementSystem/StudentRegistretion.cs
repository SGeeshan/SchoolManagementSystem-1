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
    public partial class StudentRegistretion : Form
    {
        public StudentRegistretion()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtNameWithInitial.Text == "" || txtAddress.Text == "" || dateTimePicker1.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtParent.Text == "" || txtParentMobile.Text == "")
                {
                    MessageBox.Show("Please Fill All Details");
                }
                else
                {
                    string gender = "";
                    if (radMale.Checked)
                    {
                        gender = "Male";
                    }
                    if (radFemale.Checked)
                    {
                        gender = "Female";
                    }

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True");
                    con.Open();
                    string str = "INSERT INTO Student(full_name,initial,dob,gender,address,mobile,email,parent_name,parent_mobile) VALUES('" + txtFullName.Text + "','" + txtNameWithInitial.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + txtAddress.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtParent.Text + "','" + txtParentMobile.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    string str1 = "SELECT TOP(1) st_id FROM Student ORDER BY 1 DESC";
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader read = cmd1.ExecuteReader();
                    read.Read();
                    string id = read["st_id"].ToString();

                    MessageBox.Show("" + txtNameWithInitial.Text + "'s Data Added " + "Your Index number is " + id);
                    read.Close();
                    con.Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            StudentRegistretion NewForm = new StudentRegistretion();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
