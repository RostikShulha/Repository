using System;
using System.Drawing;
using System.Windows.Forms;

namespace Рекурсія
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool flag = false;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація таймера
            timer = new Timer();
            timer.Interval = 300; // Затримка у 0.3 секунди
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            flag = false;
            timer.Stop();
            Invalidate();
        }

        private void MyDraw(Graphics g, int N, double M, double Kut, double centr, int cX, int cY)
        {
            if (N == 0)
                return;
            else
            {
                double angle = Kut * Math.PI / 180;
                int rX = cX + (int)(centr * Math.Sin(angle));
                int rY = cY - (int)(centr * Math.Cos(angle));
                g.DrawEllipse(new Pen(Brushes.SeaGreen, 2), rX, rY, 55, 55);
                N--;
                Kut += M;
                MyDraw(g, N, M, Kut, centr, cX, cY);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            double centr = Math.Min(ClientSize.Width, ClientSize.Height) / 4.0; // Центр уявного кола
            int cX = ClientSize.Width / 2; // Визначення центру по x
            int cY = ClientSize.Height / 2; // Визначення центру по y

            int N = 100; //кількість кіл
            double M = 360.0 / N;
            MyDraw(g, N, M, 0, centr, cX, cY);
        }
    }
}