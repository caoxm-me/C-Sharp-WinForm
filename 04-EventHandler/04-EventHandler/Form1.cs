﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void On_Click(object sender, EventArgs e)
        {
            MessageBox.Show("鼠标单击事件");
            //Console.WriteLine("控制台输出在窗体应用程序中无效");
        }
    }
}
