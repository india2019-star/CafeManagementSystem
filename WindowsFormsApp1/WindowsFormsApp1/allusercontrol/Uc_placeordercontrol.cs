using DGVPrinterHelper;
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
    public partial class Uc_placeordercontrol : UserControl
    {
        public Uc_placeordercontrol()
        {
            InitializeComponent();
        }

        private void categorycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listplaceorder.Items.Clear();
            string categorytext = categorycombobox.Text;
            string query = "Select ItemName From itemsinfo where ItemCategory = '" + categorytext + "'";
            Datasetobject dso = new Datasetobject();
            DataSet ds = new DataSet();
            ds = dso.getData(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                listplaceorder.Items.Add(ds.Tables[0].Rows[i][0]);
            }

        }

        private void searchplaceorderbox_TextChanged(object sender, EventArgs e)
        {
            listplaceorder.Items.Clear();
            string categorytext = categorycombobox.Text;
            string query = "Select ItemName From itemsinfo where ItemCategory = '" + categorytext + "' AND ItemName LIKE '"+searchplaceorderbox.Text+"%'";
            Datasetobject dso = new Datasetobject();
            DataSet ds = new DataSet();
            ds = dso.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listplaceorder.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        int total = 0;
        private void additemplaceorderbtn_Click(object sender, EventArgs e)
        {
            if (totalplaceorder.Text != "" && totalplaceorder.Text != "0")
            {
                
                    int n = gridviewplaceorder.Rows.Add();
                    gridviewplaceorder.Rows[n].Cells[0].Value = itemnameplaceorder.Text;
                    gridviewplaceorder.Rows[n].Cells[1].Value = itempriceplaceorder.Text;
                    gridviewplaceorder.Rows[n].Cells[2].Value = quantityplaceorder.Text;
                    gridviewplaceorder.Rows[n].Cells[3].Value = totalplaceorder.Text;

                    total = total + Convert.ToInt32(totalplaceorder.Text);
                    rupeesplaceorder.Text = total.ToString();
               
            }
            else
            {
                MessageBox.Show("Minimum Quantity Should be greater than zero", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listplaceorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityplaceorder.ResetText();
            totalplaceorder.Clear();

            string selecteditemfromlistbox = listplaceorder.GetItemText(listplaceorder.SelectedItem);
            itemnameplaceorder.Text = selecteditemfromlistbox;
            string query = "Select ItemPrice from itemsinfo where ItemCategory = '" + categorycombobox.Text + "' AND ItemName = '" + selecteditemfromlistbox + "'";
            Datasetobject dso = new Datasetobject();
            DataSet ds = new DataSet();
            ds = dso.getData(query);
            try
            {
                itempriceplaceorder.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch(Exception e1)
            {
                Console.WriteLine("Sorry Please try again");
                Console.WriteLine(e1);
            }
            
        }

        private void quantityplaceorder_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(quantityplaceorder.Value.ToString());
            totalplaceorder.Text = (quantity * (Convert.ToInt32(itempriceplaceorder.Text))).ToString();
            
            
        }
        
        private void gridviewplaceorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        int amount = 0;
        private void gridviewplaceorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = Convert.ToInt32(gridviewplaceorder.Rows[e.RowIndex].Cells[3].Value.ToString());
                

            }
            catch (Exception e1)
            {
                MessageBox.Show("Exception Occurred, Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void removeitemplaceorderbtn_Click(object sender, EventArgs e)
        {
            try
            {
                gridviewplaceorder.Rows.RemoveAt(this.gridviewplaceorder.SelectedRows[0].Index);
                total = total - amount;
                rupeesplaceorder.Text = "Rs. " + total;

            }
            catch(Exception e1)
            {
                MessageBox.Show("Exception Occurred, Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void printitemplaceorderbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Billing Details";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Amount to be Paid is Rs: " + total;
            printer.FooterSpacing = 20;
            printer.PrintDataGridView(gridviewplaceorder);

            total = 0;
            gridviewplaceorder.Rows.Clear();
            rupeesplaceorder.Text = "Rs: " + total;
        }
    }
}
