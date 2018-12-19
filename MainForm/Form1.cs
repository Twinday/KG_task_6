using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }
        Graphics g;
        Bitmap btm;
        Point[] p1, p2, oldp1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static List<Point> lp = new List<Point>();
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            Point p = new Point(e.X, e.Y);
            lp.Add(p);
            Logics.Draw(g, oldp1, ref p1, p2);
            Logics.DrawDot(g, lp);
            pictureBox1.Image = btm;
        }

        static bool flag = false; //можно ли добавлять точки во 2 массив
        private void buttonCreateCurve_Click(object sender, EventArgs e)
        {
            try
            {
                if (!flag)
                {
                    p1 = Logics.ListToArrPoint(lp);
                    oldp1 = Logics.ListToArrPoint(lp);
                    flag = true;
                    lp = new List<Point>();
                }
                else
                {
                    p2 = Logics.ListToArrPoint(lp);
                    //flag = false;
                    lp = new List<Point>();
                }
                btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(btm);
                Logics.Draw(g, oldp1, ref p1, p2);
                pictureBox1.Image = btm;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Не найдено введённых точек");
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            p1 = new Point[oldp1.Length];
            for (int i = 0; i < oldp1.Length; i++)
            {
                p1[i] = oldp1[i];
            }
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            Logics.Draw(g, oldp1, ref p1, p2);
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            p1 = null;
            p2 = null;
            oldp1 = null;
            flag = false;
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRemoveLast_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
        }

        private void buttonTransformation_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (p1.Length != p2.Length)
                    throw new Exception("Кривые состоят из разного количества точек");

                btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(btm);
                Logics.Transformation(g, oldp1, ref p1, p2);
                pictureBox1.Image = btm;
            }
            catch (Exception ex)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
