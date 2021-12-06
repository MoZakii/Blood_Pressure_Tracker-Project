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

            
            Form frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox2.Text.Length > 6)
                {
                    // bashof el user name dah mawgod w dah el password bta3u wlaa laa , aw bakhod data wana at3aml
                    if (true)
                    {
                        ///Form1.SetValueForText1 = "1";
                        
                        Form frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                    // feh haga 3'lt
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "Invalid Username or Password";
                    }
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Password is too small";
                }
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Please fill all spaces";
            }
        }
    }
}
