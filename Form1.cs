﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("telefon :" + maskedTextBox1.Text);
            listBox1.Items.Add("TC :" + maskedTextBox2.Text);
            listBox1.Items.Add("Tarih :" + maskedTextBox3.Text);
        }
    }
}
