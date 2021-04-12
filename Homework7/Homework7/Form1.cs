using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Graphics != null)Graphics.Clear(Color.Black);
            int n = Convert.ToInt32(this.n.Text);
            double leng = Convert.ToDouble(this.leng.Text);
            if (Graphics == null) Graphics = panel1.CreateGraphics();
            DrawCayleyTree(n, 200, 350, leng , -Math.PI / 2);
        }
        private Graphics Graphics;
        Pen pens = new Pen(Color.Red);
        
        void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, Convert.ToDouble(per1.Text) * leng, th + Convert.ToDouble( th1.Text)*Math.PI/180);
            DrawCayleyTree(n - 1, x1, y1, Convert.ToDouble(per2.Text) * leng, th - Convert.ToDouble(th2.Text) * Math.PI / 180);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            Graphics.DrawLine(pens, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pens.Color = colorDialog1.Color;
            }
        }
    }
}
