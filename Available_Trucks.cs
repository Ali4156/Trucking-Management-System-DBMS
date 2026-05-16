using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Available_Trucks : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public Available_Trucks()
        {
            InitializeComponent();

            // BACK BUTTON STYLE
            backBtn.Text = "";

            backBtn.FlatStyle =
            FlatStyle.Flat;

            backBtn.FlatAppearance.BorderSize = 0;

            backBtn.BackColor =
            System.Drawing.Color.White;

            backBtn.UseVisualStyleBackColor = false;
        }

        // FORM LOAD
        private void Available_Trucks_Load(
        object sender,
        EventArgs e)
        {
            LoadDat();
        }

        // LOAD DATA
        public void LoadDat()
        {
            try
            {
                SqlDataAdapter da =
                new SqlDataAdapter(

                "SELECT * FROM Truck",

                con);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvTruck.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DISPLAY BUTTON
        private void button1_Click(
        object sender,
        EventArgs e)
        {
            LoadDat();
        }

        // DATAGRID CLICK
        private void dgvTruck_CellContentClick_1(
        object sender,
        DataGridViewCellEventArgs e)
        {

        }

        // BACK BUTTON
        private void backBtn_Click(
        object sender,
        EventArgs e)
        {
            Dashboard d =
            new Dashboard();

            d.Show();

            this.Hide();
        }
        
    }
}