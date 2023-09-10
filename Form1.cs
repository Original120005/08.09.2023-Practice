using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08._09._2023_practice
{
    public partial class Form1 : Form
    {
        Pen pen;

        public Form1()
        {
            InitializeComponent();

            pen = new Pen(Color.Blue, 20);
            button1.Paint += Button1_Paint;
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, 20);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 20);
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(15, 15, 20, 20);
            path.AddEllipse(35, 35, 20, 20);
            path.AddEllipse(55, 55, 20, 20);
            path.AddEllipse(15, 55, 20, 20);
            path.AddEllipse(55, 15, 20, 20);


            g.DrawEllipse(pen, 15, 15, 20, 20);
            g.DrawEllipse(pen, 35, 35, 20, 20);
            g.DrawEllipse(pen, 55, 55, 20, 20);
            g.DrawEllipse(pen, 55, 15, 20, 20);
            g.DrawEllipse(pen, 15, 55, 20, 20);


            Region region = new Region(path);
            button1.Region = region;
        }
    }
}
