﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();


            //This is the List of type PressureReading I'm supposed to receive from the DATABASE
            List<ServiceReference1.PressureReading> pressure_reading = new List<ServiceReference1.PressureReading>();
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            pressure_reading = obj.GetUserPressureReadings(Form1.User_ID).ToList();
        //use the the list GETTER to copy one list into another
        //pressure_reading = ServiceReference1.PressureReading.getList();

            //Chart Stuff that binds the LIST to the CHART
            chart1.DataSource = pressure_reading;
            Series series1 = new Series();
            chart1.Series.Add("High");
            chart1.Series.Add("Low");
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.Text = "Blood Pressure";
            chart1.Titles.Add(title);

            chart1.Series["High"].XValueMember = "Date";
            chart1.Series["High"].YValueMembers = "High";
            chart1.Series["High"].YValueType = ChartValueType.Auto;
            chart1.Series["High"].Color = Color.DarkRed;
            chart1.Series["High"].BorderColor = Color.Black;
            chart1.Series["High"].BorderWidth = 2;

            chart1.Series["Low"].XValueMember = "Date";
            chart1.Series["Low"].YValueMembers = "Low";
            chart1.Series["Low"].YValueType = ChartValueType.Auto;
            chart1.Series["Low"].BorderColor = Color.Black;
            chart1.Series["Low"].BorderWidth = 2;

            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;

            chart1.DataBind();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
