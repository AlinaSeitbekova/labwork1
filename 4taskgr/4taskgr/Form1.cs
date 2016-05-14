using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4taskgr
{
    public partial class Form1 : Form
    {

        List<PointF> arr = new List<PointF>();

        Pen pen = new Pen(Color.Red);
        Point p1 = new Point(329, 0);
        Point p2 = new Point(329, 500);
        Point p3 = new Point(0, 260);
        Point p4 = new Point(500, 260);

        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            arr.Add(new PointF((float)20, (float)260));// надо чтобы в массиве уже было 2 точки
            arr.Add(new PointF((float)20, (float)260));
            t.Tick += T_Tick;
            t.Interval = 500;
            t.Start();
        }
        int x = 0;
        private void T_Tick(object sender, EventArgs e)
        {

            // без фора так как каждый тик вызывает заново
            double y = Math.Sin(x++);
            y = y * 20 + 260;


            arr.Add(new PointF((float)x * 20 - 7, (float)y));
            this.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawCurve(pen, arr.ToArray());
            e.Graphics.DrawLine(new Pen(Color.Black), p1, p2);
            e.Graphics.DrawLine(new Pen(Color.Black), p3, p4);
            using (Font font1 = new Font("Times New Roman", 9, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                for (int i = 0; i < 4; i++)
                {
                    PointF pointF1 = new PointF(50 + 180 * i, 260);
                    string s = "";
                    if (i == 0)
                    {
                        s = 0 + "";
                    }
                    else if (i == 1)
                    {
                        s = "3";
                    }
                    else
                    {
                        s = "6";
                    }
                    e.Graphics.DrawString(s, font1, Brushes.Black, pointF1);
                }

            }
        }
    }
}
