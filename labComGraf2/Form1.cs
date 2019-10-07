using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labComGraf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
            Process();
        }

        void Init()
        {
            InitPictureBox();
        }

        void InitPictureBox()
        {
            fractalPictureBox.SetBounds(Width / 2 - fractalPictureBox.Width / 2, fractalPictureBox.Location.Y, fractalPictureBox.Width, fractalPictureBox.Height);
        }

        void Process()
        {
            int maxOperation = (int)maxOperationNumericUpDown.Value;
            var fractalInfo = CalculatePattern(maxOperation);
            var points = CalculatePoints(fractalInfo.Pattern, fractalInfo.Iterations);
            DrawFractal(points);
        }

        string axiom = "FXF--FF--FF";
        string fRule = "FF";
        string xRule = "--FXF++FXF++FXF--";


        (string Pattern, int Iterations) CalculatePattern(int maxOperations)
        {
            string pattern = axiom;
            int iterations = 0;
            for (; ;iterations++)
            {
                StringBuilder next = new StringBuilder();
                foreach ( char c in pattern)
                {
                    switch (c)
                    {
                        case '-':                           
                        case '+':
                            next.Append(c);
                            break;
                        case 'F':
                            next.Append(fRule);
                            break;
                        case 'X':
                            next.Append(xRule);
                            break;                        
                    }
                }
                if (next.Length > maxOperations)
                {
                    break;
                }
                else
                {

                    pattern = next.ToString();
                }
            }
            return (pattern, iterations);
        }

        int padd = 5;
        double rotateAngle = Math.PI / 3;

        List<PointF> CalculatePoints(string pattern, int iterations)
        {
            List<PointF> points = new List<PointF>();
            float h = fractalPictureBox.Width / 2 - padd;
            for (int i = 0; i < iterations; i++)
            {
                h /= 2;
            }
            float x = padd, y =fractalPictureBox.Height - padd;
            double angle = 0;
            foreach (char c in pattern)
            {
                points.Add(new PointF(x, y));
                switch (c)
                {
                    case '-':
                        angle -= rotateAngle;
                        break;
                    case '+':
                        angle += rotateAngle;
                        break;
                    case 'F':
                        float nextX = (float)(x + h * Math.Cos(angle));
                        float nextY = (float)(y + h * Math.Sin(angle));
                        x = nextX;
                        y = nextY;
                        break;
                }
            }
            points.Add(new PointF(x, y));
            return points;
        }

        void DrawFractal(List<PointF> points)
        {
            Bitmap bmp = new Bitmap(fractalPictureBox.Width, fractalPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Brush brush = new SolidBrush(Color.White))
                    g.FillRectangle(brush, 0, 0, fractalPictureBox.Width, fractalPictureBox.Height);
                using (Pen pen = new Pen(Color.Black))
                {
                    for (int i = 1; i < points.Count; i++)
                    {
                        PointF p1 = points[i - 1];
                        PointF p2 = points[i];
                        g.DrawLine(pen, p1, p2);
                    }
                }
            }
            fractalPictureBox.Image = bmp;
        }

        private void DrawFractalButton_Click(object sender, EventArgs e)
        {
            Process();
        }
    }
}
