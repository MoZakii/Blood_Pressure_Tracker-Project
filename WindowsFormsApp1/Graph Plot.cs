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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            //this is an example of how to use the database
            /*
             * conn.Open();
                        mydatareader = territorycommand.ExecuteReader();
                        while (mydatareader.Read())
                        {
                            chart1.Series["TotalAchievment"].Points.AddXY(mydatareader.GetString(0), mydatareader.GetInt32(1));
                            chart1.Series["Forecast"].Points.AddY(mydatareader.GetInt32(2));
                            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.DataSource = ;

            */

            chart1.DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
