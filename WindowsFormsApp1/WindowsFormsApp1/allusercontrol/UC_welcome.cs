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
    public partial class UC_welcome : UserControl
    {
        public UC_welcome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                hindcafelabel.Location = new Point(94, 320);
                hindcafelabel.ForeColor = Color.Orange;
                num++;
            }
            else if(num == 1)
            {
                hindcafelabel.Location = new Point(166, 320);
                hindcafelabel.ForeColor = Color.Red;
                num++;
            }
            else if(num == 2)
            {
                hindcafelabel.Location = new Point(268, 320);
                hindcafelabel.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void UC_welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
