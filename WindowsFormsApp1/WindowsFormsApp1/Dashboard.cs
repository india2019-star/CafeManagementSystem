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
    public partial class Dashboard : Form
    {
        SqlConnection conn;
        private string usercategory;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string usercategory)
        {
            InitializeComponent();
            this.usercategory = usercategory;
            if (usercategory == "Guest")
            {
                additemsbtn.Hide();
                updateitemsbtn.Hide();
                removeitemsbtn.Hide();
            }
            
        }
        public Dashboard(string usercategory, SqlConnection conn)
        {
            InitializeComponent();
            this.usercategory = usercategory;
            this.conn = conn;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uc_update1.Visible = true;
            uc_update1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_additems1.Visible = true;
            uC_additems1.BringToFront();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            if(usercategory == "Guest")
            {
                Form1 ff = new Form1();
                ff.Show();
                this.Hide();
            }
            else if (usercategory == "Admin")
            {
                conn.Close();
                Form1 ff = new Form1();
                ff.Show();
                this.Hide();

            }

            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_welcome1.Visible = true;
            uC_welcome1.BringToFront();
            uC_additems1.Visible = false;
            uc_placeordercontrol1.Visible = false;
            uc_update1.Visible = false;
        }

        private void uC_additems1_Load(object sender, EventArgs e)
        {
            
        }

        private void placeorderbtn_Click(object sender, EventArgs e)
        {
            uC_welcome1.SendToBack();
           guna2Transition1.ShowSync(uc_placeordercontrol1);
            uc_placeordercontrol1.Visible = true;
            uc_placeordercontrol1.BringToFront();
        }

        private void uC_placeorder1_Load(object sender, EventArgs e)
        {

        }

        private void uc_placeordercontrol1_Load(object sender, EventArgs e)
        {

        }

        private void removeitemsbtn_Click(object sender, EventArgs e)
        {
            deleteuc1.Visible = true;
            deleteuc1.BringToFront();
        }
    }
}
