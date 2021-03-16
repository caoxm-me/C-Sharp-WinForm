using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ManualLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            // Size是整个窗体大小，ClientSize是客户区大小
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            int yoff = 0;
            yoff = 4;
            // 注意要设置multiline=true
            this.textBox1.Location = new System.Drawing.Point(0, yoff);
            this.textBox1.Size = new System.Drawing.Size(width - 80, 30);

            this.button1.Location = new System.Drawing.Point(width - 80, yoff);
            this.button1.Size = new System.Drawing.Size(80, 30);

            yoff += 30;
            yoff += 4;
            this.pictureBox1.Location = new System.Drawing.Point(0, yoff);
            this.pictureBox1.Size = new System.Drawing.Size(width, height - yoff -4);
        }
    }
}
