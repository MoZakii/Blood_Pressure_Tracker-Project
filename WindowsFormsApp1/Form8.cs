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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient sc = new ServiceReference1.WebService1SoapClient();
            List<ServiceReference1.PressureReading> readings = new List<ServiceReference1.PressureReading>();
            readings = sc.GetUserPressureReadings(Form1.User_ID).ToList();
            DateTime dt = DateTime.Now;
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                label3.Visible = true;
            }
            else 
            {
                sc.insertPressureData(Form1.User_ID, readings.Count+1,int.Parse(textBox1.Text),int.Parse(textBox2.Text),dt.ToString("dd/MM/yyyy"));
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }

        }
    }
}
