using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Driver : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;Initial Catalog=TruckingSystem;Integrated Security=True");

        public Driver()
        {
            InitializeComponent();

            // Status ComboBox
            d5.Items.Clear();

            d5.Items.Add("Available");
            d5.Items.Add("Busy");
            d5.Items.Add("On Leave");

            d5.SelectedIndex = 0;
        }

        // REGISTER BUTTON
        private void d6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "INSERT INTO Driver(driver_name, license_number, phone, status) VALUES(@name,@license,@phone,@status)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", d1.Text);
                cmd.Parameters.AddWithValue("@license", d2.Text);
                cmd.Parameters.AddWithValue("@phone", d3.Text);
                cmd.Parameters.AddWithValue("@status", d5.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Driver Registered Successfully");

                // Clear Fields
                d1.Clear();
                d2.Clear();
                d3.Clear();

                d5.SelectedIndex = 0;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void d5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();

            d.Show();

            this.Hide();
        }

        private void Driver_Load(object sender, EventArgs e)
        {

        }
    }
}