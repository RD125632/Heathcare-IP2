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

        private delegate void SetRichTextBox(string s);

        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1",8888);
            r = new StreamReader(client.GetStream());
            w = new StreamWriter(client.GetStream());

        }

        public void SetRichText(string s)
        {
            if (richTextBox1.InvokeRequired)
            {
                Invoke(new SetRichTextBox(SetRichText), new object[] {s});

            }
            else
            {
                richTextBox1.AppendText(s+"\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += (o, args) =>
            {
                if (textBox1.Text != "")
                {
                    w.WriteLine("get|" + textBox1.Text);
                    w.Flush();
                    string str;
                    while ((str = r.ReadLine()) != null)
                    {
                        SetRichText(str);
                    }
                }
            };
            bgw.RunWorkerAsync();
        }
    }
}
