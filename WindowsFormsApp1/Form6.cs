using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        String BP = "low";
        String[] High_Rec = { "High recommendation"};
        String[] Low_Rec = { "Low Recommendation"};

        public Form6()
        {
            InitializeComponent();
            
            List<ServiceReference1.PressureReading> readings = new List<ServiceReference1.PressureReading>();
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            readings = obj.GetUserPressureReadings(Form1.User_ID).ToList();
            int low=0, high=0;
            if (readings.Count != 0) {
                low = readings[readings.Count - 1].Low;
                high = readings[readings.Count - 1].High;
            }
            if (low < 60 || high < 90)
            {
                BP = "low";
            }
            else if (low > 90 || high > 120)
            {
                BP = "high";
            }

            richTextBox1.Text = "  You have " + BP.ToString() + " Blood Pressure  ";

            if (BP.ToLower() == "high")
            {
                richTextBox2.Text = High_Rec[0];
            }
            else 
            {
                richTextBox2.Text = Low_Rec[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
