using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALI\SQLEXPRESS01;Initial Catalog=TruckingSystem;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void TRUCK_Click(object sender, EventArgs e)
        {
            truck t = new truck();   // open truck form
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        
            Driver d = new Driver();   // open Driver form
            d.Show();
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Shipment s = new Shipment();   // open Shipment form
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      Available_Trucks at = new Available_Trucks();   // open Available Trucks form
            at.Show();  
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Available_Drivers AD = new Available_Drivers();
    
            this.Hide();
            AD.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            login l = new login();

            l.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register_new_member rm =
new Register_new_member();

            rm.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            View_Members vm = new View_Members();

            vm.Show();

            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
