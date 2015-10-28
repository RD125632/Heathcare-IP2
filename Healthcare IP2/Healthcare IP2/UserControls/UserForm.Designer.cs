namespace Healthcare_IP2.UserControls
{
    partial class UserForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.namePNL = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.ageLBL = new System.Windows.Forms.Label();
            this.agePNL = new System.Windows.Forms.Panel();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.weightLBL = new System.Windows.Forms.Label();
            this.weightPNL = new System.Windows.Forms.Panel();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comLBL = new System.Windows.Forms.Label();
            this.namePNL.SuspendLayout();
            this.agePNL.SuspendLayout();
            this.weightPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // namePNL
            // 
            this.namePNL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.namePNL.BackColor = System.Drawing.Color.Gainsboro;
            this.namePNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePNL.Controls.Add(this.nameBox);
            this.namePNL.Location = new System.Drawing.Point(269, 92);
            this.namePNL.Name = "namePNL";
            this.namePNL.Size = new System.Drawing.Size(413, 48);
            this.namePNL.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Gainsboro;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.nameBox.Location = new System.Drawing.Point(6, 9);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(400, 25);
            this.nameBox.TabIndex = 2;
            // 
            // nameLBL
            // 
            this.nameLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLBL.BackColor = System.Drawing.Color.Transparent;
            this.nameLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameLBL.Location = new System.Drawing.Point(421, 56);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(99, 33);
            this.nameLBL.TabIndex = 1;
            this.nameLBL.Text = "Name";
            this.nameLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ageLBL
            // 
            this.ageLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ageLBL.BackColor = System.Drawing.Color.Transparent;
            this.ageLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.ageLBL.Location = new System.Drawing.Point(426, 197);
            this.ageLBL.Name = "ageLBL";
            this.ageLBL.Size = new System.Drawing.Size(99, 33);
            this.ageLBL.TabIndex = 3;
            this.ageLBL.Text = "Age";
            this.ageLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // agePNL
            // 
            this.agePNL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.agePNL.BackColor = System.Drawing.Color.Gainsboro;
            this.agePNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agePNL.Controls.Add(this.ageBox);
            this.agePNL.Location = new System.Drawing.Point(274, 236);
            this.agePNL.Name = "agePNL";
            this.agePNL.Size = new System.Drawing.Size(408, 48);
            this.agePNL.TabIndex = 2;
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ageBox.Location = new System.Drawing.Point(4, 9);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(397, 25);
            this.ageBox.TabIndex = 2;
            // 
            // weightLBL
            // 
            this.weightLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightLBL.BackColor = System.Drawing.Color.Transparent;
            this.weightLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.weightLBL.Location = new System.Drawing.Point(421, 310);
            this.weightLBL.Name = "weightLBL";
            this.weightLBL.Size = new System.Drawing.Size(125, 33);
            this.weightLBL.TabIndex = 5;
            this.weightLBL.Text = "Weight";
            this.weightLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.weightLBL.Click += new System.EventHandler(this.weightLBL_Click);
            // 
            // weightPNL
            // 
            this.weightPNL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightPNL.BackColor = System.Drawing.Color.Gainsboro;
            this.weightPNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightPNL.Controls.Add(this.weightBox);
            this.weightPNL.Location = new System.Drawing.Point(269, 373);
            this.weightPNL.Name = "weightPNL";
            this.weightPNL.Size = new System.Drawing.Size(408, 48);
            this.weightPNL.TabIndex = 4;
            // 
            // weightBox
            // 
            this.weightBox.BackColor = System.Drawing.Color.Gainsboro;
            this.weightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.weightBox.Location = new System.Drawing.Point(4, 9);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(397, 25);
            this.weightBox.TabIndex = 2;
            // 
            // startBTN
            // 
            this.startBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.startBTN.Location = new System.Drawing.Point(201, 557);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(545, 53);
            this.startBTN.TabIndex = 6;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 500);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(413, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comLBL
            // 
            this.comLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comLBL.BackColor = System.Drawing.Color.Transparent;
            this.comLBL.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comLBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.comLBL.Location = new System.Drawing.Point(421, 445);
            this.comLBL.Name = "comLBL";
            this.comLBL.Size = new System.Drawing.Size(125, 36);
            this.comLBL.TabIndex = 8;
            this.comLBL.Text = "COM";
            this.comLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comLBL);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.weightLBL);
            this.Controls.Add(this.weightPNL);
            this.Controls.Add(this.ageLBL);
            this.Controls.Add(this.agePNL);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.namePNL);
            this.Name = "UserForm";
            this.Size = new System.Drawing.Size(946, 663);
            this.namePNL.ResumeLayout(false);
            this.namePNL.PerformLayout();
            this.agePNL.ResumeLayout(false);
            this.agePNL.PerformLayout();
            this.weightPNL.ResumeLayout(false);
            this.weightPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel namePNL;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label ageLBL;
        private System.Windows.Forms.Panel agePNL;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label weightLBL;
        private System.Windows.Forms.Panel weightPNL;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label comLBL;
    }
}
