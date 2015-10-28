using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader r;
        private StreamWriter w;

        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("localhost",8888);
            r = new StreamReader(client.GetStream());
            w = new StreamWriter(client.GetStream());

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
