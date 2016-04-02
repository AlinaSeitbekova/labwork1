using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartinka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Blue);// zapolnyaem vse golybim cvetom
            e.Graphics.FillPolygon(new SolidBrush(Color.DarkOrange), Spaceship(350, 220)); // верхняя точка ракеты с кораблем
            e.Graphics.FillPolygon(new SolidBrush(Color.DarkGreen), Arrow(350, 220)); // верхняя точка корабля с ракетой
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.FillPolygon(new SolidBrush(Color.DarkRed), Asteroids(i + 1));//4 raza risuet asteroidi
            }
            e.Graphics.FillPolygon(new SolidBrush(Color.Green), Bullet(350, 220)); // верхняя точка корабля(пуля)

            for (int i = 0; i < 8; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.White), Stars(i + 1));// risuet zvezdi
            }
   
            using (Font font1 = new Font("Times New Roman", 11, FontStyle.Italic, GraphicsUnit.Pixel))
            {
                Pen pen = new Pen(Brushes.Orange, 3);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                RectangleF rectF1 = new RectangleF(400, 30, 220, 40);// верхний угол и ширина высота
                e.Graphics.FillRectangle(Brushes.White, Rectangle.Round(rectF1));
                e.Graphics.DrawRectangle(pen, Rectangle.Round(rectF1));
                e.Graphics.DrawString("Level: 1 Score: 200 Live: ***** ", font1, Brushes.Black, rectF1, stringFormat);
            }
        }

        private PointF[] Arrow(int x, int y)//стрелочка
        {
            Point arrowPoint1 = new Point(x, y + 15);//первая точка верхняя,потом по часовой стрелке
            Point arrowPoint2 = new Point(x + 20, y + 50);
            Point arrowPoint3 = new Point(x + 10, y + 50);
            Point arrowPoint4 = new Point(x + 10, y + 80);
            Point arrowPoint5 = new Point(x - 10, y + 80);
            Point arrowPoint6 = new Point(x - 10, y + 50);
            Point arrowPoint7 = new Point(x - 20, y + 50);
            PointF[] spaceshipPoints = { arrowPoint1, arrowPoint2, arrowPoint3, arrowPoint4, arrowPoint5, arrowPoint6, arrowPoint7 };
            return spaceshipPoints;
        }
                private PointF[] Spaceship(int x, int y)// korablik
        {
            Point spaseshipPoint1 = new Point(x, y);
            Point spaseshipPoint2 = new Point(x + 50, y + 20);
            Point spaseshipPoint3 = new Point(x + 50, y + 80);
            Point spaseshipPoint4 = new Point(x, y + 100);
            Point spaseshipPoint5 = new Point(x - 50, y + 80);
            Point spaseshipPoint6 = new Point(x - 50, y + 20);
            PointF[] spaceshipPoints = { spaseshipPoint1, spaseshipPoint2, spaseshipPoint3, spaseshipPoint4, spaseshipPoint5, spaseshipPoint6 };
            return spaceshipPoints;
        }

        private PointF[] Bullet(int x, int y)//pulya
        {
            Point bulletPoint1 = new Point(x, y);
            Point bulletPoint2 = new Point(Convert.ToInt32(x - 2.5), y - 5);
            Point bulletPoint3 = new Point(Convert.ToInt32(x - 7.5), Convert.ToInt32(y - 7.5));
            Point bulletPoint4 = new Point(Convert.ToInt32(x - 2.5), y - 10);
            Point bulletPoint5 = new Point(x, y - 15);
            Point bulletPoint6 = new Point(Convert.ToInt32(x + 2.5), y - 10);
            Point bulletPoint7 = new Point(Convert.ToInt32(x + 7.5), Convert.ToInt32(y - 7.5));
            Point bulletPoint8 = new Point(Convert.ToInt32(x + 2.5), y - 5);
            PointF[] bulletPoints = { bulletPoint1, bulletPoint2, bulletPoint3, bulletPoint4, bulletPoint5, bulletPoint6, bulletPoint7, bulletPoint8 };
            return bulletPoints;
        }


        private PointF[] Asteroids(int n)
        {
            int x = 0, y = 0;
            switch (n)
            {
                case 1:
                    x = 100;
                    y = 200;
                    break;
                case 2:
                    x = 690;
                    y = 50;
                    break;
                case 3:
                    x = 40;
                    y = 300;
                    break;
                case 4:
                    x = 120;
                    y = 400;
                    break;
            }
            Point asteroidPoint1 = new Point(x, y);// звездочки из 12 точек
            Point asteroidPoint2 = new Point(x + 5, y + 10);
            Point asteroidPoint3 = new Point(x + 15, y + 10);
            Point asteroidPoint4 = new Point(x + 5, y + 20);
            Point asteroidPoint5 = new Point(x + 15, y + 30);
            Point asteroidPoint6 = new Point(x + 5, y + 30);
            Point asteroidPoint7 = new Point(x, y + 40);
            Point asteroidPoint8 = new Point(x - 5, y + 30);
            Point asteroidPoint9 = new Point(x - 15, y + 30);
            Point asteroidPoint10 = new Point(x - 5, y + 20);
            Point asteroidPoint11 = new Point(x - 15, y + 10);
            Point asteroidPoint12 = new Point(x - 5, y + 10);
            PointF[] asteroidPoints = { asteroidPoint1, asteroidPoint2, asteroidPoint3, asteroidPoint4, asteroidPoint5, asteroidPoint6, asteroidPoint7, asteroidPoint8, asteroidPoint9, asteroidPoint10, asteroidPoint11, asteroidPoint12 };
            return asteroidPoints;
        }

        private RectangleF Stars(int n)
        {
            int x = 0, y = 0;
            switch (n)
            {
                case 1:
                    x = 70;
                    y = 100;
                    break;
                case 2:
                    x = 210;
                    y = 70;
                    break;
                case 3:
                    x = 430;
                    y = 140;
                    break;
                case 4:
                    x = 700;
                    y = 230;
                    break;
                case 5:
                    x = 85;
                    y = 300;
                    break;
                case 6:
                    x = 200;
                    y = 550;
                    break;
                case 7:
                    x = 500;
                    y = 270;
                    break;
                case 8:
                    x = 750;
                    y = 440;
                    break;
            }
           
            RectangleF r = new RectangleF(x, y, 20, 20);
            return r;
        }
    }
}