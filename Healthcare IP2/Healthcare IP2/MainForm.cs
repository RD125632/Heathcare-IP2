using Healthcare_IP2.JsonObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_IP2
{
    public partial class MainForm : Form
    {
        public BikeCommHandler bikeHandler;
        public Test test;

        public MainForm()
        {
            InitializeComponent();
            bikeHandler = new BikeCommHandler();
            bikeHandler.initComm("COM4");
        }

        public void SetNameLBL(string str)
        {
            nameFORMLBL.Text = str;
        }

        private void closeLBLBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLBLBTN_MouseLeave(object sender, EventArgs e)
        {
            closeLBLBTN.ForeColor = Color.Gainsboro;
        }

        private void closeLBLBTN_MouseEnter(object sender, EventArgs e)
        {
            closeLBLBTN.ForeColor = Color.White;
        }
    }
}
