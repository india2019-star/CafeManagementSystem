using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.allusercontrol
{
    public partial class uc_update : UserControl
    {
        public uc_update()
        {
            InitializeComponent();
        }

        private void uc_update_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        public void loaddata()
        {
            Datasetobject obj = new Datasetobject();
            DataSet ds = new DataSet();
            string query = "Select * From itemsinfo";
            ds = obj.getData(query);
            updatedatagrid.DataSource = ds.Tables[0];
        }

        private void searchboxupdate_TextChanged(object sender, EventArgs e)
        {
            string text = searchboxupdate.Text;
            string query = "Select * From itemsinfo where ItemName Like '"+text+"%'";
            Datasetobject dso = new Datasetobject();
            DataSet ds = new DataSet();
            ds = dso.getData(query);
            updatedatagrid.DataSource = ds.Tables[0];

        }
        int id;
        private void updatedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(updatedatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = updatedatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string category = updatedatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = Convert.ToInt32(updatedatagrid.Rows[e.RowIndex].Cells[3].Value.ToString());

            categoryboxupdate.Text = category;
            itemnameboxupdate.Text = name;
            priceboxupdate.Text = price.ToString();
        }

        private void updatebtnupdateuc_Click(object sender, EventArgs e)
        {
            
            if (categoryboxupdate.Text != "" && itemnameboxupdate.Text != "" && priceboxupdate.Text != "")
            {
                string category = categoryboxupdate.Text;
                string name = itemnameboxupdate.Text;
                int price = Convert.ToInt32(priceboxupdate.Text);
                string query = "Update itemsinfo Set ItemName = '" + name + "', ItemCategory = '" + category + "', ItemPrice = '" + price + "' WHERE id = '" + id + "'";
                Updateclass up = new Updateclass();
                bool result = up.updatedata(query);
                if (result == true)
                {
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry Updation Failed. Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loaddata();
                itemnameboxupdate.Clear();
                categoryboxupdate.Clear();
                priceboxupdate.Clear();
            }
            else
            {
                MessageBox.Show("Please Select a row from the table and then Update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uc_update_Enter(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
