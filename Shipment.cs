using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Shipment : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public Shipment()
        {
            InitializeComponent();

            LoadTruck();

            LoadDriver();

            LoadStatus();
        }

        // LOAD AVAILABLE TRUCKS
        void LoadTruck()
        {
            try
            {
                con.Open();

                string query =
                "SELECT truck_number FROM Truck " +
                "WHERE status = 'Active'";

                SqlCommand cmd =
                new SqlCommand(query, con);

                SqlDataReader dr =
                cmd.ExecuteReader();

                s2.Items.Clear();

                while (dr.Read())
                {
                    s2.Items.Add(
                    dr["truck_number"].ToString());
                }

                dr.Close();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        // LOAD AVAILABLE DRIVERS
        void LoadDriver()
        {
            try
            {
                con.Open();

                string query =
                "SELECT driver_name FROM Driver " +
                "WHERE status = 'Available'";

                SqlCommand cmd =
                new SqlCommand(query, con);

                SqlDataReader dr =
                cmd.ExecuteReader();

                s3.Items.Clear();

                while (dr.Read())
                {
                    s3.Items.Add(
                    dr["driver_name"].ToString());
                }

                dr.Close();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        // LOAD SHIPMENT STATUS
        void LoadStatus()
        {
            s6.Items.Clear();

            s6.Items.Add("Pending");

            s6.Items.Add("In Transit");

            s6.Items.Add("Delivered");

            s6.SelectedIndex = 0;
        }

        private void s7_Click(object sender, EventArgs e)
        {
            try
            {
                // EMPTY CHECK
                if (s1.Text.Trim() == "" ||
                    s2.Text == "" ||
                    s3.Text == "" ||
                    s8.Text.Trim() == "" ||
                    s4.Text.Trim() == "")
                {
                    MessageBox.Show(
                    "Please fill all fields");

                    return;
                }

                con.Open();

                SqlCommand cmd = new SqlCommand(

                "INSERT INTO Shipment " +
                "(shipment_id, truck_id, driver_id, shipment_from, destination, shipment_date, shipment_status) " +

                "VALUES (@id,@truck,@driver,@from,@des,@date,@status)", con);

                cmd.Parameters.AddWithValue(
                "@id", s1.Text);

                cmd.Parameters.AddWithValue(
                "@truck", s2.Text);

                cmd.Parameters.AddWithValue(
                "@driver", s3.Text);

                cmd.Parameters.AddWithValue(
                "@from", s8.Text);

                cmd.Parameters.AddWithValue(
                "@des", s4.Text);

                cmd.Parameters.AddWithValue(
                "@date",
                Convert.ToDateTime(s5.Text));

                cmd.Parameters.AddWithValue(
                "@status", s6.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                "Shipment Registered Successfully");

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        // BACK BUTTON
        private void backBtn_Click(object sender,
        EventArgs e)
        {
            Dashboard d = new Dashboard();

            d.Show();

            this.Hide();
        }

        private void s2_SelectedIndexChanged(object sender,
        EventArgs e)
        {

        }

        private void s6_SelectedIndexChanged(object sender,
        EventArgs e)
        {

        }

        private void S1_TextChanged(object sender,
        EventArgs e)
        {

        }

        private void Shipment_Load(object sender, EventArgs e)
        {

        }
    }
}