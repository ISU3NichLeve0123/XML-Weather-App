using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();
           //Extract Forecast and Current from the Internet
            ExtractForecast();
            ExtractCurrent();

            // Open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //Day Object
                Day D = new Day();
                //Read to time, then day
                reader.ReadToFollowing("time");
                D.date = reader.GetAttribute("day");
                reader.ReadToFollowing("symbol");
                D.condition = reader.GetAttribute("number");              
                reader.ReadToFollowing("temperature");
                D.tempLow = reader.GetAttribute("max");
                D.tempHigh = reader.GetAttribute("min");
                D.unit = "℃";
                //Add to list
                if (D.date != null)
                {
                    days.Add(D);
                }                
            }
            //Close Reader
            reader.Close();
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //Gathering The Current City and Tempature and Unit
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            reader.ReadToFollowing("temperature");
            days[0].tempHigh = reader.GetAttribute("max");
            days[0].tempHigh = reader.GetAttribute("min");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].unit = "℃";
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("number");           
            reader.Close();
        }
    }
}
