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
    public partial class Form5 : Form
    {
        //Diet strings that will be displayed


        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        //Labels to display the recommended Diets

        String[] low_diet = { "Fruits and Vegetables", "Salmon", "Cucumber" };
        String[] med_diet = { "Sandwich", "Fried Chicken", "Cereal" };
        String[] high_diet = {"Yoghurt", "Chicken Breasts", "English Muffins" };


        
        public Form5()
        {
            InitializeComponent();


            List<ServiceReference1.PressureReading> readings = new List<ServiceReference1.PressureReading>();
            int low = 0, high = 0;
            if (readings.Count != 0)
            {
                low = readings[readings.Count - 1].Low;
                high = readings[readings.Count - 1].High;
            }

            if (low < 60 || high < 90)
            {
                richTextBox1.Text = low_diet[0];
                richTextBox2.Text = low_diet[1];
                richTextBox3.Text = low_diet[2];
            }
            else if (low > 90 || high > 120)
            {
                richTextBox1.Text = high_diet[0];
                richTextBox2.Text = high_diet[1];
                richTextBox3.Text = high_diet[2];
            }
            else 
            {
                richTextBox1.Text = med_diet[0];
                richTextBox2.Text = med_diet[1];
                richTextBox3.Text = med_diet[2];
            }
        }
    }
}
