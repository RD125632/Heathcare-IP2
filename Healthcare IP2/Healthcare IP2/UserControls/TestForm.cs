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
        private delegate void SetSpeedLabel(string txt);
        private delegate void SetDistanceLabel(string txt);
        private delegate void SetTimeLabel(string txt);

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
                    break;
                }

            }
        }

        public void SetSpeedLBL(string txt)
        {
            if( speedLBL.InvokeRequired)
            {
                Invoke(new SetSpeedLabel(SetSpeedLBL), new object[] { txt });
            }
            else
            {
                speedLBL.Text = txt;
            }
        }

        public void SetDistanceLBL(string txt)
        {
            if (speedLBL.InvokeRequired)
            {
                Invoke(new SetDistanceLabel(SetDistanceLBL), new object[] { txt });
            }
            else
            {
                distanceLBL.Text = txt;
            }
        }

        public void SetTimeLBL(string txt)
        {
            if (speedLBL.InvokeRequired)
            {
                Invoke(new SetTimeLabel(SetTimeLBL), new object[] { txt });
            }
            else
            {
                timeLBL.Text = txt;
            }
        }

        public void HandleBikeData(string[] values)
        {
            String[] data = values[0].Split(' ');
            foreach(String s in data)
            {
                Console.WriteLine(s);
            }

            //fill fields
            SetSpeedLBL(data[2]);
            SetDistanceLBL(data[3]);
            SetTimeLBL(data[6]);
            try
            {


                speedPoints.Add(new DataPoint(Convert.ToDateTime(data[6]).ToOADate(), Convert.ToDouble(data[2])));
                rpmPoints.Add(new DataPoint(Convert.ToDateTime(data[6]).ToOADate(), Convert.ToDouble(data[1])));
                bpmPoints.Add(new DataPoint(Convert.ToDateTime(data[6]).ToOADate(), Convert.ToDouble(data[0])));
                //fill graph speed
                this.pulseChart.Series[0].Points.Clear();
                this.pulseChart.Series[1].Points.Clear();
                this.pulseChart.Series[2].Points.Clear();

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
            catch(Exception)
            {
                Console.WriteLine("nothing to see here");
            }
            
          }

        private void startBTN_Click(object sender, EventArgs e)
        {
            startBTN.Visible = false;
            workerThread = new Thread(() => threadLoop());
            workerThread.Start();
        }
    }
}
