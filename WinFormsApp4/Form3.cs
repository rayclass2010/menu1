﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "================" + Environment.NewLine;
            if (checkBox1.Checked) 
            {
                Form1.mon = Form1.mon * 0.95;
                Form1.msg += "會員95折" + Environment.NewLine;
            }
            if (checkBox2.Checked)
            {
                Form1.mon = Form1.mon - 20;
                Form1.msg += "折20" + Environment.NewLine;
            }
            Form1.msg += "賣收" + Math.Round(Form1.mon, 0).ToString() + Environment.NewLine;
            this.Dispose();
        }
    }
}
