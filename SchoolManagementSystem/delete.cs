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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementSystemDataSet.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.schoolManagementSystemDataSet.Test);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Enter ID");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True"))
                {
                    string sql = "DELETE FROM Test WHERE Id='" + txtDelete.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                txtDelete.Text = "";
            }
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
    }
}
