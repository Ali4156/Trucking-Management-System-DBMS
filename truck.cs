using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class truck : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public truck()
        {
            InitializeComponent();

            // COMBOBOX STATUS
            t4.Items.Clear();

            t4.Items.Add("Active");

            t4.Items.Add("Maintenance");

            t4.SelectedIndex = 0;

            // BACK BUTTON STYLE
            backBtn.Text = "⬅";

            backBtn.Font =
            new System.Drawing.Font("Arial", 18);

            backBtn.FlatStyle =
            FlatStyle.Flat;

            backBtn.FlatAppearance.BorderSize = 0;
        }

        // REGISTER TRUCK
        private void button1_Click(object sender,
        EventArgs e)
        {
            if (t1.Text.Trim() == "" ||
                t2.Text.Trim() == "" ||
                t3.Text.Trim() == "" ||
                t4.SelectedIndex == -1)
            {
                MessageBox.Show(
                "Please fill all fields");

                return;
            }

            int capacity;

            if (!int.TryParse(
                t3.Text.Trim(),
                out capacity))
            {
                MessageBox.Show(
                "Capacity must be number");

                return;
            }

            try
            {
                con.Open();

                string query =
                "INSERT INTO Truck " +
                "(truck_number, model, capacity, status) " +
                "VALUES (@num, @model, @cap, @status)";

                SqlCommand cmd =
                new SqlCommand(query, con);

                cmd.Parameters.Add(
                "@num",
                SqlDbType.VarChar).Value =
                t1.Text.Trim();

                cmd.Parameters.Add(
                "@model",
                SqlDbType.VarChar).Value =
                t2.Text.Trim();

                cmd.Parameters.Add(
                "@cap",
                SqlDbType.Int).Value =
                capacity;

                cmd.Parameters.Add(
                "@status",
                SqlDbType.VarChar).Value =
                t4.SelectedItem.ToString();

                int result =
                cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(
                    "Truck Registered Successfully");

                    // CLEAR TEXTBOXES
                    t1.Clear();

                    t2.Clear();

                    t3.Clear();

                    t4.SelectedIndex = 0;

                    // OPEN AVAILABLE TRUCKS
                    Available_Trucks at =
                    new Available_Trucks();

                    at.Show();

                    this.Hide();
                }

                else
                {
                    MessageBox.Show(
                    "Insert Failed");
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message);

                con.Close();
            }
        }

        // BACK BUTTON
        private void backBtn_Click_1(object sender,
        EventArgs e)
        {
            Dashboard d =
            new Dashboard();

            d.Show();

            this.Hide();
        }

        private void t1_TextChanged(object sender,
        EventArgs e)
        {

        }

        private void truck_Load(object sender,
        EventArgs e)
        {

        }
    }
}