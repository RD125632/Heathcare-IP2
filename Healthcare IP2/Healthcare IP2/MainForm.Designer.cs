namespace Healthcare_IP2
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.closeLBLBTN = new System.Windows.Forms.Label();
            this.nameFORMLBL = new System.Windows.Forms.Label();
            this.testForm1 = new Healthcare_IP2.UserControls.TestForm();
            this.userForm1 = new Healthcare_IP2.UserControls.UserForm();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.menuPanel.Controls.Add(this.nameFORMLBL);
            this.menuPanel.Controls.Add(this.closeLBLBTN);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(584, 43);
            this.menuPanel.TabIndex = 0;
            // 
            // closeLBLBTN
            // 
            this.closeLBLBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLBLBTN.AutoSize = true;
            this.closeLBLBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLBLBTN.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLBLBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeLBLBTN.Location = new System.Drawing.Point(541, -8);
            this.closeLBLBTN.Margin = new System.Windows.Forms.Padding(0);
            this.closeLBLBTN.Name = "closeLBLBTN";
            this.closeLBLBTN.Size = new System.Drawing.Size(42, 50);
            this.closeLBLBTN.TabIndex = 1;
            this.closeLBLBTN.Text = "x";
            this.closeLBLBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLBLBTN.Click += new System.EventHandler(this.closeLBLBTN_Click);
            this.closeLBLBTN.MouseEnter += new System.EventHandler(this.closeLBLBTN_MouseEnter);
            this.closeLBLBTN.MouseLeave += new System.EventHandler(this.closeLBLBTN_MouseLeave);
            // 
            // nameFORMLBL
            // 
            this.nameFORMLBL.AutoSize = true;
            this.nameFORMLBL.BackColor = System.Drawing.Color.Transparent;
            this.nameFORMLBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameFORMLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFORMLBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameFORMLBL.Location = new System.Drawing.Point(0, 0);
            this.nameFORMLBL.Name = "nameFORMLBL";
            this.nameFORMLBL.Size = new System.Drawing.Size(0, 36);
            this.nameFORMLBL.TabIndex = 3;
            this.nameFORMLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testForm1
            // 
            this.testForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testForm1.AutoSize = true;
            this.testForm1.BackColor = System.Drawing.Color.DimGray;
            this.testForm1.Location = new System.Drawing.Point(-2, 42);
            this.testForm1.Name = "testForm1";
            this.testForm1.Size = new System.Drawing.Size(583, 519);
            this.testForm1.TabIndex = 2;
            this.testForm1.Visible = false;
            // 
            // userForm1
            // 
            this.userForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userForm1.AutoSize = true;
            this.userForm1.BackColor = System.Drawing.Color.DimGray;
            this.userForm1.Location = new System.Drawing.Point(0, 45);
            this.userForm1.Name = "userForm1";
            this.userForm1.Size = new System.Drawing.Size(584, 663);
            this.userForm1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.testForm1);
            this.Controls.Add(this.userForm1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label closeLBLBTN;
        private UserControls.UserForm userForm1;
        private UserControls.TestForm testForm1;
        private System.Windows.Forms.Label nameFORMLBL;
    }
}

