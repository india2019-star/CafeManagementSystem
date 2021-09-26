using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guestlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            DBConnection db = new DBConnection();
            SqlConnection conn = db.GetConnection();
            conn.Open();
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string query = "Select * from userinfo where username=@username and password =@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            int cnt = 0;
            while(reader.Read())
            {
                cnt++;
            }
            if(cnt > 0)
            {
                Dashboard ds = new Dashboard("Admin",conn);
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Not Found or wrong username and password. Please try again or Register.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegistration adg = new AdminRegistration();
            adg.Show();
            this.Hide();
        }
    }
}
