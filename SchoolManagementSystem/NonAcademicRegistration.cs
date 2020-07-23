using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class NonAcademicRegistration : Form
    {
        public NonAcademicRegistration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUserName.Visible = true;
                txtPassword.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
            }
            else
            {
                txtUserName.Visible = false;
                txtPassword.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtNameWithInitial.Text == "" || txtAddress.Text == "" || dateTimePicker1.Text == "" || txtMobile.Text == "" || dateTimePicker2.Text == "" || comboBox1.Text == "" || (txtPassword.Visible==true && txtPassword.Text=="")||(txtUserName.Visible==true && txtUserName.Text==""))
                {
                    MessageBox.Show("Fill All Required Field");
                }

                else
                {
                    string admin = "";
                    string gender = "";

                    string password = txtPassword.Text;
                    passwordHashing pass = new passwordHashing();

                    if (radMale.Checked)
                    {
                        gender = "Male";
                    }
                    if (radFemale.Checked)
                    {
                        gender = "Female";
                    }

                    if (checkBox1.Checked)
                    {
                        admin = "T";
                    }

                    string job = comboBox1.SelectedItem.ToString();

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True");
                    con.Open();

                    string str = "INSERT INTO NonAcademic(full_name,initial,dob,gender,address,mobile,email,doe,subject,user_name,password,is_admin) VALUES('" + txtFullName.Text + "','" + txtNameWithInitial.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + txtAddress.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + dateTimePicker2.Text + "','" + job + "','" + txtUserName.Text + "','" + pass.encodePassword(password) + "','" + admin + "')";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    string str1 = "SELECT TOP(1) nac_id FROM NonAcademic ORDER BY 1 DESC";
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader read = cmd1.ExecuteReader();
                    read.Read();
                    string id = read["nac_id"].ToString();

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
    }
}
