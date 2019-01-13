using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw_direct
{
    public partial class Form1 : Form
    {
        private int pageNo = 0;
        private bool drawed = false;
        private bool saved = false;
        private string path;
        private string root;
        private bool working = false;
        


        private Point p1, p2;//定义两个点（启点，终点）

        //private static bool drawing = false;//设置一个启动标志

        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            root = Application.StartupPath;
            Thread t = new Thread(Draw);
            t.Start();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            //p1 = new Point(e.X, e.Y);
            //p2 = new Point(e.X, e.Y);
            //drawing = true;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //drawing = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (drawed && !saved) {
                var fileName = root + @"\" + path + @"\" + pageNo + ".png";
                pictureBox1.BackgroundImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                drawed = false;
                saved = false;
                pageNo = 0;                
            }
            path = System.Guid.NewGuid().ToString();
            g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            working = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (drawed && !saved)
            {
                var fileName = root + @"\" + path + @"\" + pageNo + ".png";
                pictureBox1.BackgroundImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                drawed = false;
                saved = false;
                pageNo++;
            }

            g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)

        {

            //if (e.Button == MouseButtons.Left)
            //{
            //    if (drawing)
            //    {
            //        //drawing = true;
            //        Point currentPoint = new Point(e.X, e.Y);
            //        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//消除锯齿
            //        g.DrawLine(new Pen(Color.Blue, 2), p2, currentPoint);

            //        p2.X = currentPoint.X;
            //        p2.Y = currentPoint.Y;
            //    }

            //}
        }

        private void Draw()
        {
            
            //Point currentPoint = new Point(e.X, e.Y);
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//消除锯齿
            //g.DrawLine(new Pen(Color.Blue, 2), p2, currentPoint);

            //p2.X = currentPoint.X;
            //p2.Y = currentPoint.Y;
        }
    }   
}
