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
    public partial class deleteuc : UserControl
    {
        public deleteuc()
        {
            InitializeComponent();
        }

        private void deleteuc_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            Datasetobject obj = new Datasetobject();
            DataSet ds = new DataSet();
            string query = "Select * From itemsinfo";
            ds = obj.getData(query);
            deletedatagrid.DataSource = ds.Tables[0];
        }

        private void itemsearchdelete_TextChanged(object sender, EventArgs e)
        {
            string text = itemsearchdelete.Text;
            string query = "Select * From itemsinfo where ItemName Like '" + text + "%'";
            Datasetobject dso = new Datasetobject();
            DataSet ds = new DataSet();
            ds = dso.getData(query);
            deletedatagrid.DataSource = ds.Tables[0];
        }
        int id = -1;
        private void deletedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(deletedatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                string query = "Delete From itemsinfo where id = '" + id + "'";
                Updateclass upc = new Updateclass();
                bool result = upc.updatedata(query);
                if (result == true)
                {
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry Deletion Failed. Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a row from the table to delete. Please Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loaddata();
            itemsearchdelete.Clear();
        }

        private void deleteuc_Enter(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
