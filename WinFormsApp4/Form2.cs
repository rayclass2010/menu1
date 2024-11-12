using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        string[] m = new string[] { "漢堡", "漢堡2", "更多漢堡" };
        double[] money = new double[] { 50, 100, 200 };
        string[] d = new string[] { "冰淇淋", "餅乾", "糖果" };
        double[] money2 = new double[] { 50, 90, 98 };
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(m);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(d);
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += comboBox1.Text + " " + money[comboBox1.SelectedIndex] + Environment.NewLine;
            Form1.msg += comboBox2.Text + " " + money2[comboBox2.SelectedIndex] + Environment.NewLine;
            Form1.mon = money[comboBox1.SelectedIndex] + money2[comboBox2.SelectedIndex];
            Form1.msg += Form1.mon + Environment.NewLine;
            this.Dispose();
            Form3 d = new Form3();
            d.ShowDialog();



        }
    }
}
