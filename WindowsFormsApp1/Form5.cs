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

        String[] low_bp_diet = { "Fuck off Once", "Fuck off Twice", "Fuck off Thrice" };
        String[] med_bp_diet = { "Fuck off Once", "Fuck off Twice", "Fuck off Thrice" };
        String[] high_bp_diet = {"Fuck off Once", "Fuck off Twice", "Fuck off Thrice" };


        int bp = 0;
        public Form5()
        {
            InitializeComponent();

            //bp = 1 --> BP is low,  bp = 2 --> BP is med, bp = 3 --> is high

            if (bp == 1)
            {
                richTextBox1.Text = low_bp_diet[0];
                richTextBox2.Text = low_bp_diet[1];
                richTextBox3.Text = low_bp_diet[2];
            }
            else if (bp == 2)
            {
                richTextBox1.Text = med_bp_diet[0];
                richTextBox2.Text = med_bp_diet[1];
                richTextBox3.Text = med_bp_diet[2];
            }
            else //bp == 3
            {
                richTextBox1.Text = high_bp_diet[0];
                richTextBox2.Text = high_bp_diet[1];
                richTextBox3.Text = high_bp_diet[2];
            }
        }
    }
}
