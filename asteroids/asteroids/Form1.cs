using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asteroids
{
    public partial class Form1 : Form
    {
       
        Bitmap bmp=new Bitmap(200,200);
        Timer t = new Timer();


        public Form1()
        {
            InitializeComponent();
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.Clear(Color.Green);
            gfx.DrawEllipse(new Pen(Color.Yellow), 0, 0, 10, 10);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                        
            t.Tick += T.Tick;
            t.Interval = 10;
            t.Start();
        }
    }
}
