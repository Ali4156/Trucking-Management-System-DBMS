using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public login()
        {
            InitializeComponent();

            // password hide
            l2.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void l1_TextChanged(object sender, EventArgs e)
        {

        }

        private void l2_TextChanged(object sender, EventArgs e)
        {

        }

        // ADMIN LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            // empty fields check
            if (l1.Text.Trim() == "" ||
                l2.Text.Trim() == "")
            {
                MessageBox.Show(
                "Please enter username and password");

                return;
            }

            try
            {
                con.Open();

                string qu =
                "SELECT COUNT(*) FROM Member " +
                "WHERE username=@u " +
                "AND password=@p " +
                "AND role='Admin'";

                SqlCommand cmd =
                new SqlCommand(qu, con);

                cmd.Parameters.AddWithValue(
                "@u", l1.Text.Trim());

                cmd.Parameters.AddWithValue(
                "@p", l2.Text.Trim());

                int count =
                (int)cmd.ExecuteScalar();

                // correct login
                if (count > 0)
                {
                    MessageBox.Show(
                    "Admin Login Successful");

                    Dashboard d =
                    new Dashboard();

                    d.Show();

                    this.Hide();
                }

                // wrong login
                else
                {
                    MessageBox.Show(
                    "Enter Correct Username or Password");
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        // USER LOGIN
        private void button2_Click(object sender, EventArgs e)
        {
            // empty fields check
            if (l1.Text.Trim() == "" ||
                l2.Text.Trim() == "")
            {
                MessageBox.Show(
                "Please enter username and password");

                return;
            }

            try
            {
                con.Open();

                string qu =
                "SELECT COUNT(*) FROM Member " +
                "WHERE username=@u " +
                "AND password=@p " +
                "AND role='User'";

                SqlCommand cmd =
                new SqlCommand(qu, con);

                cmd.Parameters.AddWithValue(
                "@u", l1.Text.Trim());

                cmd.Parameters.AddWithValue(
                "@p", l2.Text.Trim());

                int count =
                (int)cmd.ExecuteScalar();

                // correct login
                if (count > 0)
                {
                    MessageBox.Show(
                    "User Login Successful");

                    vieew_shipment v =
                    new vieew_shipment();

                    v.Show();

                    this.Hide();
                }

                // wrong login
                else
                {
                    MessageBox.Show(
                    "Enter Correct Username or Password");
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}