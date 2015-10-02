namespace Healthcare_IP2.UserControls
{
    partial class TestForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nameLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedLBL = new System.Windows.Forms.Label();
            this.distanceLBL = new System.Windows.Forms.Label();
            this.timeLBL = new System.Windows.Forms.Label();
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLBL
            // 
            this.nameLBL.BackColor = System.Drawing.Color.Transparent;
            this.nameLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameLBL.Location = new System.Drawing.Point(12, 13);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(73, 36);
            this.nameLBL.TabIndex = 2;
            this.nameLBL.Text = "Live";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(184, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(438, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Distance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(728, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // speedLBL
            // 
            this.speedLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.speedLBL.BackColor = System.Drawing.Color.Transparent;
            this.speedLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLBL.ForeColor = System.Drawing.Color.LightCoral;
            this.speedLBL.Location = new System.Drawing.Point(184, 69);
            this.speedLBL.Name = "speedLBL";
            this.speedLBL.Size = new System.Drawing.Size(122, 36);
            this.speedLBL.TabIndex = 9;
            this.speedLBL.Text = "100";
            this.speedLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // distanceLBL
            // 
            this.distanceLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.distanceLBL.BackColor = System.Drawing.Color.Transparent;
            this.distanceLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLBL.ForeColor = System.Drawing.Color.LightCoral;
            this.distanceLBL.Location = new System.Drawing.Point(447, 69);
            this.distanceLBL.Name = "distanceLBL";
            this.distanceLBL.Size = new System.Drawing.Size(122, 36);
            this.distanceLBL.TabIndex = 10;
            this.distanceLBL.Text = "120";
            this.distanceLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeLBL
            // 
            this.timeLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLBL.BackColor = System.Drawing.Color.Transparent;
            this.timeLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL.ForeColor = System.Drawing.Color.LightCoral;
            this.timeLBL.Location = new System.Drawing.Point(728, 69);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(122, 36);
            this.timeLBL.TabIndex = 12;
            this.timeLBL.Text = "10:00";
            this.timeLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pulseChart
            // 
            this.pulseChart.BackColor = System.Drawing.Color.Transparent;
            this.pulseChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.pulseChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.pulseChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.pulseChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.pulseChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea4);
            this.pulseChart.Location = new System.Drawing.Point(18, 184);
            this.pulseChart.Name = "pulseChart";
            this.pulseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.pulseChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Khaki};
            series4.BorderWidth = 10;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Speed";
            series4.XValueMember = "Time";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series4.YValueMembers = "Speed";
            this.pulseChart.Series.Add(series4);
            this.pulseChart.Size = new System.Drawing.Size(896, 458);
            this.pulseChart.TabIndex = 13;
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.DimGray;
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.startBTN.Location = new System.Drawing.Point(18, 55);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(56, 29);
            this.startBTN.TabIndex = 14;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.pulseChart);
            this.Controls.Add(this.timeLBL);
            this.Controls.Add(this.distanceLBL);
            this.Controls.Add(this.speedLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLBL);
            this.Name = "TestForm";
            this.Size = new System.Drawing.Size(932, 660);
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label speedLBL;
        private System.Windows.Forms.Label distanceLBL;
        private System.Windows.Forms.Label timeLBL;
        public System.Windows.Forms.DataVisualization.Charting.Chart pulseChart;
        private System.Windows.Forms.Button startBTN;
    }
}
