using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class vieew_shipment : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public vieew_shipment()
        {
            InitializeComponent();

            txtSearch.Text = "Enter Shipment ID";
        }

        private void dataGridView1_CellContentClick(
        object sender,
        DataGridViewCellEventArgs e)
        {

        }

        // SEARCH BUTTON
        private void btnSearch_Click(
        object sender,
        EventArgs e)
        {
            if (txtSearch.Text.Trim() == "" ||
                txtSearch.Text == "Enter Shipment ID")
            {
                MessageBox.Show(
                "Enter Shipment ID");

                return;
            }

            try
            {
                con.Open();

                string query =
                "SELECT * FROM Shipment " +
                "WHERE shipment_id = @id";

                SqlCommand cmd =
                new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                "@id",
                txtSearch.Text.Trim());

                SqlDataAdapter da =
                new SqlDataAdapter(cmd);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                    "Shipment ID not found");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        // REMOVE PLACEHOLDER
        private void txtSearch_Enter(
        object sender,
        EventArgs e)
        {
            if (txtSearch.Text ==
                "Enter Shipment ID")
            {
                txtSearch.Text = "";
            }
        }

        private void loginBackBtn(object sender, EventArgs e)
        {
            login l = new login();

            l.Show();

            this.Hide();
        }

        private void vieew_shipment_Load(object sender, EventArgs e)
        {

        }
    }
}