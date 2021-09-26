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

namespace WindowsFormsApp1.allusercontrol
{
    public partial class UC_additems : UserControl
    {
        
        public UC_additems()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string query = "Insert into itemsinfo (ItemName,ItemCategory,ItemPrice) VALUES('" + itemnametxt.Text + "','" + categorytextbox.Text + "', " + itempricetxt.Text + ")";
            
            Setdata sd = new Setdata();
            sd.setData(query);
            clearAllFields();
        }
        public void clearAllFields()
        {
            categorytextbox.SelectedIndex = -1;
            itemnametxt.Clear();
            itempricetxt.Clear();
        }

        private void UC_additems_Load(object sender, EventArgs e)
        {

        }

        private void UC_additems_Leave(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
