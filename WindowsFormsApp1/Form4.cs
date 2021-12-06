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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Update")
            {
                button2.Text = "Save";
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
            }
            else if (button2.Text == "Save")
            {

                    button2.Text = "Update";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    comboBox1.Enabled = false;

                  if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
                  {
                        //msh mawgod abl keda
                        if (textBox1.Text == "")
                        {
                            //ya5od el data w yb3tha le function el database
                        }
                        else {
                            label5.Visible = true;
                            label5.Text = "This Username is used before";
                        }
                 }
                else {
                        label5.Visible = true;
                        label5.Text = "Please fill all spaces";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Save")
            {
                DialogResult dialog = MessageBox.Show("Do you want to save changes ?", "Warning", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    //ya5od el data w yb3tha le function el database
                }
                else if (dialog == DialogResult.Cancel)
                {

                }
            }
            
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
