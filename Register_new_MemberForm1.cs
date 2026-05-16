using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register_new_member : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=ALI\SQLEXPRESS01;
        Initial Catalog=TruckingSystem;
        Integrated Security=True");

        public Register_new_member()
        {
            InitializeComponent();

            // ROLE COMBOBOX
            r5.Items.Add("Admin");

            r5.Items.Add("User");

            r5.SelectedIndex = 0;

            // PASSWORD HIDE
            r3.UseSystemPasswordChar = true;

            r4.UseSystemPasswordChar = true;
        }

        // REGISTER BUTTON
        private void r8_Click(object sender,
        EventArgs e)
        {
            // EMPTY CHECK
            if (r1.Text.Trim() == "" ||
                r2.Text.Trim() == "" ||
                r3.Text.Trim() == "" ||
                r4.Text.Trim() == "" ||
                r6.Text.Trim() == "" ||
                r7.Text.Trim() == "")
            {
                MessageBox.Show(
                "Please fill all fields");

                return;
            }

            // PASSWORD MATCH
            if (r3.Text != r4.Text)
            {
                MessageBox.Show(
                "Passwords do not match");

                return;
            }

            try
            {
                con.Open();

                // CHECK USERNAME
                string checkQuery =
                "SELECT COUNT(*) FROM Member " +
                "WHERE username=@username";

                SqlCommand checkCmd =
                new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue(
                "@username",
                r2.Text.Trim());

                int count =
                (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show(
                    "Username already exists");

                    con.Close();

                    return;
                }

                // INSERT QUERY
                string query =
                "INSERT INTO Member " +
                "(full_name, username, password, role, phone_number, email) " +
                "VALUES " +
                "(@name, @username, @password, @role, @phone, @email)";

                SqlCommand cmd =
                new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                "@name",
                r1.Text.Trim());

                cmd.Parameters.AddWithValue(
                "@username",
                r2.Text.Trim());

                cmd.Parameters.AddWithValue(
                "@password",
                r3.Text.Trim());

                cmd.Parameters.AddWithValue(
                "@role",
                r5.SelectedItem.ToString());

                cmd.Parameters.AddWithValue(
                "@phone",
                r6.Text.Trim());

                cmd.Parameters.AddWithValue(
                "@email",
                r7.Text.Trim());

                int result =
                cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(
                    "Registration Successful");

                    // CLEAR FIELDS
                    r1.Clear();

                    r2.Clear();

                    r3.Clear();

                    r4.Clear();

                    r6.Clear();

                    r7.Clear();

                    r5.SelectedIndex = 0;
                }

                else
                {
                    MessageBox.Show(
                    "Registration Failed");
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }

        private void backBtn(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();

            d.Show();

            this.Hide();
        }

        private void r6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}