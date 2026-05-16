using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Available_Drivers : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public Available_Drivers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDriverData();
        }

        private void LoadDriverData()
        {
            try
            {
                con.Open();

                SqlDataAdapter da =
                new SqlDataAdapter("SELECT * FROM Driver", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView2.DataSource = dt;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();

            d.Show();

            this.Hide();
        }
    }
}