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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementSystemDataSet1.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.schoolManagementSystemDataSet1.Test);
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True"))
            {
                string sql = "SELECT * FROM Test";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Enter Index");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True"))
                {
                    string sql = "SELECT * FROM Test WHERE Id='" + txtSearch.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);

                   
                }
                txtSearch.Text = "";

            }
        }
    }
}
