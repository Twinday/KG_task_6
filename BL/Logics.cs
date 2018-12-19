using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Logics
    {
        private static void Dxy(ref Point[] p1, Point[] p2)
        {
            try
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    if (p1[i].X > p2[i].X)
                        p1[i].X--;
                    else if (p1[i].X < p2[i].X)
                        p1[i].X++;
                    if (p1[i].Y > p2[i].Y)
                        p1[i].Y--;
                    else if (p1[i].Y < p2[i].Y)
                        p1[i].Y++;
                }
            }
            catch
            {
                throw new Exception("Кривые состоят из разного количества точек");
            }
        }

        public static void Transformation(Graphics g, Point[] oldp1, ref Point[] p1, Point[] p2)
        {
            Dxy(ref p1, p2);
            Draw(g, oldp1, ref p1, p2);
        }

        public static void Draw(Graphics g, Point[] oldp1, ref Point[] p1, Point[] p2)
        {
            if (p2 != null)
            {
                g.DrawCurve(Pens.Red, p2);
            }
            if (p1 != null)
            {
                //g.DrawCurve(Pens.Blue, oldp1);
                g.DrawCurve(Pens.Black, p1);
            }
            /*g.DrawCurve(Pens.Blue, oldp1);
            g.DrawCurve(Pens.Red, p2);
            g.DrawCurve(Pens.Black, p1);*/
        }

        public static void DrawDot(Graphics g, List<Point> lp)
        {
            if (lp != null)
            {
                foreach (Point p in lp)
                {
                    g.FillEllipse(Brushes.DarkBlue, p.X, p.Y, 8, 8);
                }
            }
        }

        public static Point[] ListToArrPoint(List<Point> l)
        {
            Point[] arrp = new Point[l.Count];
            for (int i = 0; i < l.Count; i++)
            {
                arrp[i] = l[i];
            }
            return arrp;
        }





    }
}
