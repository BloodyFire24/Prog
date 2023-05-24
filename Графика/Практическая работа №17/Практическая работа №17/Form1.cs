namespace Практическая_работа__17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen_bl = new Pen(Color.Blue, 6);
            Pen pen_grey = new Pen(Color.Gray, 5);
            Pen black = new Pen(Color.Black, 5);
            Brush brush = new SolidBrush(Color.SkyBlue);
            Brush red = new SolidBrush(Color.Red);
            Brush ore = new SolidBrush(Color.Orange);
            Brush pu = new SolidBrush(Color.Purple);
            Brush black1 = new SolidBrush(Color.Black);
            Brush wi = new SolidBrush(Color.White);
            Brush ye = new SolidBrush(Color.Yellow);

            g.DrawEllipse(pen_bl, 250, 400, 200, 200);
            g.FillEllipse(brush, 250, 400, 200, 200);
            g.DrawLine(pen_grey, 200, 400, 300, 360);
            g.DrawLine(pen_grey, 500, 400, 350, 360);
            g.DrawEllipse(pen_bl, 270, 300, 150, 150);
            g.FillEllipse(brush, 270, 300, 150, 150);
            g.DrawEllipse(pen_bl, 280, 200, 120, 120);
            g.FillEllipse(brush, 280, 200, 120, 120);
            g.DrawEllipse(black, 345, 350, 20, 20);
            g.FillEllipse(red, 345, 350, 20, 20);
            g.DrawEllipse(black, 345, 390, 20, 20);
            g.FillEllipse(red, 345, 390, 20, 20);
            PointF point1 = new PointF(400, 250);
            PointF point2 = new PointF(400, 270);
            PointF point3 = new PointF(460, 260);
            PointF[] curvePoints = { point1, point2, point3 };

            e.Graphics.DrawPolygon(black, curvePoints);
            g.FillPolygon(ore, curvePoints);
            g.DrawRectangle(black, 290, 130, 100, 100);
            g.FillRectangle(pu, 290, 130, 100, 100);
            g.FillEllipse(black1, 360, 240, 20, 20);
            g.FillEllipse(wi, 365, 240, 10, 10);
            g.FillEllipse(ye, 500, 50, 80, 80);
        }
    }
}