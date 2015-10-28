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
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            int age = 0;
            int weight = 0;
            Int32.TryParse(ageBox.Text, out age);
            Int32.TryParse(weightBox.Text, out weight);
            ((MainForm)this.Parent).test = new Test(nameBox.Text, age, weight);
            this.Visible = false;
            ((MainForm)this.Parent).SetNameLBL(nameBox.Text);
            this.Parent.Controls["testForm1"].Visible = true;
            
        }
    }
}
