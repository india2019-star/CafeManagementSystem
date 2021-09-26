using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            
            if(usernametextboxregister.Text != "" && passwordregister.Text != "" && confirmpasswordregister.Text != "" && passwordregister.Text == confirmpasswordregister.Text)
            {
                string username = usernametextboxregister.Text;
                string password = passwordregister.Text;
                string query1 = "Select * from userinfo where username = '" + username + "'";
                Datasetobject dso = new Datasetobject();
                DataSet ds = new DataSet();
                ds = dso.getData(query1);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "Insert into userinfo VALUES('" + username + "', '" + password + "')";
                    Setdata sd = new Setdata();
                    sd.setData(query);
                }
                
                
            }
            else
            {
                MessageBox.Show("Fields Cannot be empty or check password and confirm password fields. They must be same.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            usernametextboxregister.Clear();
            passwordregister.Clear();
            confirmpasswordregister.Clear();


        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
