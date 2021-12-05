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
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetValueForText1 = "1";
            this.Hide();
            Form frm = new Form3();
            frm.Show();
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
