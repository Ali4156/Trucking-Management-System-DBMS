using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class View_Members : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public View_Members()
        {
            InitializeComponent();

            LoadMembers();
        }

        private void dataGridView1_CellContentClick(
        object sender,
        DataGridViewCellEventArgs e)
        {

        }

        void LoadMembers()
        {
            try
            {
                con.Open();

                string query =
                "SELECT * FROM Member";

                SqlDataAdapter da =
                new SqlDataAdapter(query, con);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        private void backBtn_Click(
        object sender,
        EventArgs e)
        {
            Dashboard d = new Dashboard();

            d.Show();

            this.Hide();
        }

        private void View_Members_Load(object sender, EventArgs e)
        {

        }
    }
}