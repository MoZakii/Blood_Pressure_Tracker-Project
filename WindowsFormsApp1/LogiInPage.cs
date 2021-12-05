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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form frm = new Form1();
            frm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }
    }
}
