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
using Healthcare_IP2.JsonObjects;

namespace Healthcare_IP2.UserControls
{
    public partial class TestForm : UserControl
    {
        private List<DataPoint> speedPoints = new List<DataPoint>();
        private List<DataPoint> bpmPoints = new List<DataPoint>();
        private List<DataPoint> rpmPoints = new List<DataPoint>();

        private delegate void SetSpeedLabel(string txt);
        private delegate void SetDistanceLabel(string txt);
        private delegate void SetTimeLabel(string txt);
        private delegate void SetLabel5(string txt);
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
                if (((MainForm)this.Parent).Controls["testForm1"].Visible == true)
                {
                    try
                    {
                        ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.STATUS);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                else
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
        private void warmupLoop()
        {
            // Start at 50 Watt
            ((MainForm)this.Parent).bikeHandler.sendData(BikeCommHandler.CMD_POWER + " 50\n");
            int second = 0;
            int minute = 0;
            int temp = 0;

            while (true)
            {
                if (minute > 3)
                {                    
                    MainForm activeForm = (MainForm)Form.ActiveForm;
                    activeForm.Invoke((MethodInvoker)delegate ()
                    {
                        activeForm.Controls["testForm1"].Visible = false;
                        ((ResultForm)activeForm.Controls["resultForm1"]).setRates(BPMrest, BPMmax, minute);
                    });
                    break;
                }
                else
                {
                    if (second == 60)
                    {
                        second = 0;
                        minute++;

                        if (Int32.Parse(label5.Text) < 150)
                        {
                           temp = Int32.Parse(label5.Text) + 15;
                            SetLBL5(temp.ToString());
                        }

                        try
                        {
                            Console.WriteLine("PW " + temp);
                            Thread.Sleep(100);
                            ((MainForm)this.Parent).bikeHandler.sendData("PW " + temp + "\n");

                        }
                        catch (Exception)
                        {
                            ((MainForm)this.Parent).bikeHandler.closeComm();
                        }

                        
                    }
                    else
                    {
                        second++;
                        Thread.Sleep(100);
                    }
                    SetTimeLBL(minute + ":" + second);
                }
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



        public void SetLBL5(string txt)
        {
            if (speedLBL.InvokeRequired)
            {
                Invoke(new SetLabel5(SetLBL5), new object[] { txt });
            }
            else
            {
                label5.Text = txt;
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

            if (!speedPoints.Any())
            {
                BPMrest = Convert.ToInt32(data[0]);
            }
            else
            {
                if (Convert.ToInt32(data[0]) > BPMmax)
                {
                    BPMmax = Convert.ToInt32(data[0]);
                }
            }

            //fill fields
            SetSpeedLBL(data[2]);
            SetDistanceLBL(data[3]);
            //SetTimeLBL(data[6]);
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

            trainingThread = new Thread(() => warmupLoop());
            trainingThread.Start();

        }
    }
}
