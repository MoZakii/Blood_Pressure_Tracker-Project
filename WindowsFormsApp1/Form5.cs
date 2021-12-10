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
        String breakfast_rec = "Fuck off Once", lunch_rec = "Fuck off Twice", dinner_rec = "Fuck off Thrice";

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        //Labels to display the recommended Diets

        int bp = 0;
        public Form5()
        {
            InitializeComponent();

            //bp = 1 --> BP is low,  bp = 2 --> BP is med, bp = 3 --> is high

            if (bp == 1)
            {
                richTextBox1.Text = breakfast_rec;
                richTextBox2.Text = lunch_rec;
                richTextBox3.Text = dinner_rec;
            }
            else if (bp == 2)
            {
                richTextBox1.Text = breakfast_rec;
                richTextBox2.Text = lunch_rec;
                richTextBox3.Text = dinner_rec;
            }
            else //bp == 3
            {
                richTextBox1.Text = breakfast_rec;
                richTextBox2.Text = lunch_rec;
                richTextBox3.Text = dinner_rec;
            }
        }
    }
}
