using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int lineLength = 300;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Graphics g = this.CreateGraphics();
                int x1 = random.Next(ClientSize.Width);
                int y1 = random.Next(ClientSize.Height);
                double angle = random.NextDouble() * 2 * Math.PI;
                int x2 = x1 + (int)(lineLength * Math.Cos(angle));
                int y2 = y1 + (int)(lineLength * Math.Sin(angle));
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    g.DrawLine(pen, x1, y1, x2, y2);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = random.Next(ClientSize.Width);
            int y = random.Next(ClientSize.Height);
            int w = 70;
            int h = 70;
            using (Brush brush = new SolidBrush(Color.Green))
            {
                g.FillRectangle(brush, x, y, w, h);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = random.Next(ClientSize.Width);
            int y = random.Next(ClientSize.Height);
            int w = 60;
            int h = 60;

            using (Brush brush = new SolidBrush(Color.Blue))
            {
                g.FillEllipse(brush, x, y, w, h);
            }
        }
    }
}