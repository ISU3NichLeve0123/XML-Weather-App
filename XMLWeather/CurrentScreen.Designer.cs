namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.condtionNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.cityLabel.Location = new System.Drawing.Point(-13, 12);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(322, 71);
            this.cityLabel.TabIndex = 22;
            this.cityLabel.Text = "Stratford";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.maxLabel.Location = new System.Drawing.Point(241, 100);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(153, 73);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.dateLabel.Location = new System.Drawing.Point(3, 215);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(273, 67);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date:2019-04-08";
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.currentLabel.Location = new System.Drawing.Point(0, 304);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(222, 52);
            this.currentLabel.TabIndex = 40;
            this.currentLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.forecastLabel.Location = new System.Drawing.Point(367, 304);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(201, 71);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.minLabel.Location = new System.Drawing.Point(-3, 100);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(135, 73);
            this.minLabel.TabIndex = 43;
            this.minLabel.Text = "Min";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(398, 132);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(121, 34);
            this.maxOutput.TabIndex = 32;
            // 
            // currentTemp
            // 
            this.currentTemp.BackColor = System.Drawing.Color.White;
            this.currentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.Location = new System.Drawing.Point(413, 42);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(98, 33);
            this.currentTemp.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(247, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 55);
            this.label1.TabIndex = 45;
            this.label1.Text = "Current";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.Location = new System.Drawing.Point(127, 130);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(121, 34);
            this.minOutput.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // condtionNameLabel
            // 
            this.condtionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condtionNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.condtionNameLabel.Location = new System.Drawing.Point(255, 173);
            this.condtionNameLabel.Name = "condtionNameLabel";
            this.condtionNameLabel.Size = new System.Drawing.Size(264, 67);
            this.condtionNameLabel.TabIndex = 49;
            this.condtionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.condtionNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentTemp);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.dateLabel);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(522, 354);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minOutput;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label condtionNameLabel;
    }
}
