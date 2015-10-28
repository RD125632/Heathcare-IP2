using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_IP2.JsonObjects;

namespace Healthcare_IP2.UserControls
{
    public partial class ResultForm : UserControl
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void setRates(int hrr, int hrm, int duration)
        {
            Test tempTest = ((MainForm)this.Parent).test;
            hrmLBL.Text = hrm + "";
            hrrLBL.Text = hrr + "";
            try
            {
                vomaxLBL.Text = ((((15 * (hrm / hrr)) * 1000) / tempTest.userWeight) / 7) + "";
            }
            catch (Exception e)
            {
                MessageBox.Show("De patient is dood! RUSTAAAAGH!!!");
            }
            
        }
    }
}
