﻿using System;
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
        public static int User_ID = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (name_box.Text != "" && age_box.Text != "" && weight_box.Text != "" && comboBox1.Text != "" && textBox1.Text != "")
            {
                if (textBox1.Text.Length > 6)
                {
                    // el esm uniqe
                    if (name_box.Text != "")
                    {
                        //set el id el gded
                        User_ID = 1;
                        Form frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        label7.Visible = true;
                        label7.Text = "This Username is used before";   
                    }
                }
                else
                {
                    label7.Visible = true;
                    label7.Text = "Password is too small"; 
                }
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Please fill all spaces";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form3();
            this.Hide();
            frm.ShowDialog();          
            this.Close();
            
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
