using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;


namespace Healthcare_IP2.UserControls
{
    public partial class TestForm : UserControl
    {
        private List<DataPoint> speedPoints = new List<DataPoint>();
        private List<DataPoint> bpmPoints = new List<DataPoint>();
        private List<DataPoint> rpmPoints = new List<DataPoint>();
        private Thread workerThread;

        public TestForm()
        {
            InitializeComponent();
        }

        private void threadLoop()
        {
            while (true)
            {
                Thread.Sleep(1000);

                try
                {
                    ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.STATUS);
                }
                catch (Exception)
                {
                    ((MainForm)this.Parent).bikeHandler.closeComm();
                }

            }
        }

        private void HandleBikeData(string[] data)
        {

            //fill fields
            this.speedLBL.Text = data[0];
            this.distanceLBL.Text = data[1];
            this.timeLBL.Text = data[2];

            //fill graph speed
            speedPoints.Add(new DataPoint(Convert.ToDateTime(data[6]).ToOADate(), Convert.ToDouble(data[2])));
            rpmPoints.Add(new DataPoint(Convert.ToDateTime(data[6]).ToOADate(), Convert.ToDouble(data[1])));
            bpmPoints.Add(new DataPoint(Convert.ToDateTime(data[6]).ToOADate(), Convert.ToDouble(data[0])));

            this.pulseChart.Series[0].Points.Clear();

            for (int i = 0; i < speedPoints.Count; i++)
            {
                this.pulseChart.Series[0].Points.Add(speedPoints[i]);
                this.pulseChart.Series[1].Points.Add(rpmPoints[i]);
                this.pulseChart.Series[2].Points.Add(bpmPoints[i]);

                if (speedPoints.Count > 25)
                {
                    speedPoints.RemoveAt(0);
                    rpmPoints.RemoveAt(0);
                    bpmPoints.RemoveAt(0);
                }
            }
            this.pulseChart.Update();
          }

        private void startBTN_Click(object sender, EventArgs e)
        {
            startBTN.Visible = false;
            workerThread = new Thread(() => threadLoop());
            workerThread.Start();
        }
    }
}
