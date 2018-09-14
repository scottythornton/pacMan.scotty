using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace pacMan.scotty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            Pen drawPen2 = new Pen(Color.Yellow, 10);
            g.DrawPie(drawPen2, 32, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 32, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 62, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 62, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 92, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 92, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 122, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 122, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 122, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 122, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 152, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 152, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 182, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 182, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 202, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 202, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 32, 55, 55, 30, 300);
            g.FillPie(drawBrush, 212, 32, 55, 55, 30, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 32, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 32, 55, 55, 120, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 62, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 62, 55, 55, 120, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 92, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 92, 55, 55, 120, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 112, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 112, 55, 55, 120, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 142, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 142, 55, 55, 120, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 172, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 172, 55, 55, 120, 300);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            g.DrawLine(drawPen, 20, 20, 300, 20);
            g.DrawLine(drawPen, 20, 100, 200, 100);
            g.DrawLine(drawPen, 300, 15, 300, 300);
            g.DrawLine(drawPen, 200, 95, 200, 300);

            g.DrawPie(drawPen2, 212, 172, 55, 55, 120, 300);
            g.FillPie(drawBrush, 212, 172, 55, 55, 120, 300);
            Thread.Sleep(500);

        }
    }
}
