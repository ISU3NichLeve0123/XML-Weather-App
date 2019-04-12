using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //Displays info on Labels and Formats them appropriately
            cityLabel.Text = Form1.days[0].location;
            currentTemp.Text += Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + Form1.days[0].unit;
            minOutput.Text += Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + Form1.days[0].unit; 
            maxOutput.Text += Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + Form1.days[0].unit;  
            dateLabel.Text = Convert.ToDateTime(Form1.days[0].date).ToString("dddd");
            //Calls Determine Condtion
            DetermineCondtion();

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //Switches to ForecastScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
        private void DetermineCondtion()
        {
            //Logic to Determine the Condtion and which Image to show
            for( int i = 0; i < Form1.days.Count;i++)
            {
                if (Convert.ToDouble(Form1.days[i].condition) < 899 && Convert.ToDouble(Form1.days[i].condition) >= 801)
                {
                    condtionNameLabel.Text = "Cloudy";
                    pictureBox1.Image = (Properties.Resources.Clouds);
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 799 && Convert.ToDouble(Form1.days[i].condition) >= 700)
                {
                    condtionNameLabel.Text = "Misty";
                    pictureBox1.Image = (Properties.Resources.Mist);
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 699 && Convert.ToDouble(Form1.days[i].condition) >=600)
                {
                    condtionNameLabel.Text = "Snow";
                    pictureBox1.Image = (Properties.Resources.Snow);
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 599 && Convert.ToDouble(Form1.days[i].condition) >= 500)
                {
                    condtionNameLabel.Text = "Rain";
                    pictureBox1.Image = (Properties.Resources.Rain);
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 399 && Convert.ToDouble(Form1.days[i].condition) >= 300)
                {
                    condtionNameLabel.Text = "Drizzle";
                    pictureBox1.Image = (Properties.Resources.Drizzle);
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 299 && Convert.ToDouble(Form1.days[i].condition) >= 200)
                {
                    condtionNameLabel.Text = "Thunder Storm";
                    pictureBox1.Image = (Properties.Resources.Thunder_Storm);
                }
                if (Convert.ToDouble(Form1.days[i].condition) == 800)
                {
                    condtionNameLabel.Text = "Sunny";
                    pictureBox1.Image = (Properties.Resources.Sunny);
                }
            }
            
        }
    }
}
