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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            //Calls DetermineCondtion Method
            DetermineCondtion();
            displayForecast();
        }

        public void displayForecast()
        {
            //Displays City Name, Day and Min and Max of the Next Three Days
            cityLabel.Text = Form1.days[0].location;
            dateLabel1.Text = Convert.ToDateTime(Form1.days[1].date).ToString("dddd");
            minOutput.Text += Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + Form1.days[1].unit;
            maxOutput.Text += Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + Form1.days[1].unit;

            dateLabel2.Text = Convert.ToDateTime(Form1.days[2].date).ToString("dddd");
            minOutput2.Text += Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + Form1.days[1].unit;
            maxOutput2.Text += Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + Form1.days[1].unit;

            dateLabel3.Text = Convert.ToDateTime(Form1.days[3].date).ToString("dddd");
            minOutput3.Text += Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + Form1.days[1].unit; 
            maxOutput3.Text += Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + Form1.days[1].unit;
        }

        //Goes to Current Screen When Click on Current Label
        private void label3_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
        private void DetermineCondtion()
        {
            //Determines What Condtion it is and which label to display it to
            for (int i = 0; i < Form1.days.Count; i++)
            {
                if (Convert.ToDouble(Form1.days[i].condition) < 899 && Convert.ToDouble(Form1.days[i].condition) >= 801)
                {
                    if(i == 1)
                    {
                        weatherCondtionLabel.Text = "Cloudy";
                        condtionLabel1.Image = (Properties.Resources.Clouds);
                    }
                    if( i == 2)
                    {
                        weatherCondtionLabel2.Text = "Cloudy";
                        condtionLabel2.Image = (Properties.Resources.Clouds);
                    }
                    if(i == 3)
                    {
                        weatherCondtionLabel3.Text = "Cloudy";
                        condtionLabel3.Image = (Properties.Resources.Clouds);
                    }
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 799 && Convert.ToDouble(Form1.days[i].condition) >= 700)
                {
                    if (i == 1)
                    {
                        weatherCondtionLabel.Text = "Misty";
                        condtionLabel1.Image = (Properties.Resources.Mist);
                    }
                    if (i == 2)
                    {
                        weatherCondtionLabel2.Text = "Misty";
                        condtionLabel2.Image = (Properties.Resources.Mist);
                    }
                    if (i == 3)
                    {
                        weatherCondtionLabel3.Text = "Misty";
                        condtionLabel3.Image = (Properties.Resources.Mist);
                    }
                    
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 699 && Convert.ToDouble(Form1.days[i].condition) >= 600)
                {
                    if (i == 1)
                    {
                        weatherCondtionLabel.Text = "Snow";
                        condtionLabel1.Image = (Properties.Resources.Snow);
                    }
                    if (i == 2)
                    {
                        weatherCondtionLabel2.Text = "Snow";
                        condtionLabel2.Image = (Properties.Resources.Snow);
                    }
                    if (i == 3)
                    {
                        weatherCondtionLabel3.Text = "Snow";
                        condtionLabel3.Image = (Properties.Resources.Snow);
                    }
                   
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 599 && Convert.ToDouble(Form1.days[i].condition) >= 500)
                {
                    if (i == 1)
                    {
                        weatherCondtionLabel.Text = "Rain";
                        condtionLabel1.Image = (Properties.Resources.Rain);
                    }
                    if (i == 2)
                    {
                        weatherCondtionLabel2.Text = "Rain";
                        condtionLabel2.Image = (Properties.Resources.Rain);
                    }
                    if (i == 3)
                    {
                        weatherCondtionLabel3.Text = "Rain";
                        condtionLabel3.Image = (Properties.Resources.Rain);
                    }                   
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 399 && Convert.ToDouble(Form1.days[i].condition) >= 300)
                {
                    if (i == 1)
                    {
                        weatherCondtionLabel.Text = "Drizzle";
                        condtionLabel1.Image = (Properties.Resources.Drizzle);
                    }
                    if (i == 2)
                    {
                        weatherCondtionLabel2.Text = "Drizzle";
                        condtionLabel2.Image = (Properties.Resources.Drizzle);
                    }
                    if (i == 3)
                    {
                        weatherCondtionLabel3.Text = "Drizzle";
                        condtionLabel3.Image = (Properties.Resources.Drizzle);
                    }
                }
                if (Convert.ToDouble(Form1.days[i].condition) < 299 && Convert.ToDouble(Form1.days[i].condition) >= 200)
                {
                    if (i == 1)
                    {
                        weatherCondtionLabel.Text = "Thunder Storm";
                        condtionLabel1.Image = (Properties.Resources.Thunder_Storm);
                    }
                    if (i == 2)
                    {
                        weatherCondtionLabel2.Text = "Thunder Storm";
                        condtionLabel2.Image = (Properties.Resources.Thunder_Storm);
                    }
                    if (i == 3)
                    {
                        weatherCondtionLabel3.Text = "Thunder Storm";
                        condtionLabel3.Image = (Properties.Resources.Thunder_Storm);
                    }
                }
                if (Convert.ToDouble(Form1.days[i].condition) == 800)
                {
                    if (i == 1)
                    {
                        weatherCondtionLabel.Text = "Sunny";
                        condtionLabel1.Image = (Properties.Resources.Sunny);
                    }
                    if (i == 2)
                    {
                        weatherCondtionLabel2.Text = "Sunny";
                        condtionLabel2.Image = (Properties.Resources.Sunny);
                    }
                    if (i == 3)
                    {
                        weatherCondtionLabel3.Text = "Sunny";
                        condtionLabel3.Image = (Properties.Resources.Sunny);
                    }
                }
            }

        }
    }
}
