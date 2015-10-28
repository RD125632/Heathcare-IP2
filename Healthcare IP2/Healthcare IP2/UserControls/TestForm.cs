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
        private Thread workerThread, trainingThread;
        private int BPMrest, BPMmax;


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

        private void warmupLoop()
        {
            // Start at 50 Watt
            ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.COMMAND);
            ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.CMD_POWER + " 50");
            int second = 0;
            int minute = 0;
            int temp = 0;

            while (true)
            {
                if (minute > 7)
                {
                    
                }
                else
                {
                    if (second == 60)
                    {
                        second = 0;
                        minute++;

                        if (Int32.Parse(label5.Text) < 150)
                        {
                           temp = Int32.Parse(label5.Text) + 17;
                        }

                        try
                        {
                            ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.COMMAND);
                            ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.CMD_POWER + " " + temp);
                        }
                        catch (Exception)
                        {
                            ((MainForm)this.Parent).bikeHandler.closeComm();
                        }

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        second++;
                    }
                    timeLBL.Text = minute + ":" + second;
                }
            }
        }

        private void HandleBikeData(string[] data)
        {
            if(!speedPoints.Any())
            {
                BPMrest = Convert.ToInt32(data[0]);
            }
            else
            {
                if(Convert.ToInt32(data[0]) > BPMmax)
                {
                    BPMmax = Convert.ToInt32(data[0]);
                }
            }


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

            trainingThread = new Thread(() => warmupLoop());
            trainingThread.Start();

        }
    }
}
