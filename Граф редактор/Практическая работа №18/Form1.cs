using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Файлы изображений(*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Image(*.jpg) | *.jpg | (*.*) | *.*";
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 1;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        SolidBrush c = new SolidBrush(Color.White);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog1.FileName);
                this.pictureBox1.Size = img.Size;
                pictureBox1.Image = img;
                pictureBox1.Invalidate();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
                btm.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изображение?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (save == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
                    btm.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index ==3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index ==5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if (index == 6)
            {
                g.FillEllipse(c, cX, cY, sX, sY);
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 7)
            {
                g.FillRectangle(c, cX, cY, sX, sY);
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                c.Color = colorDialog2.Color;
                ((Button)sender).BackColor = colorDialog2.Color;
            }
        }

        private void toolStrip_Click(object sender, EventArgs e)
        {
            ToolStripButton tsmi = sender as ToolStripButton;
            if (tsmi == toolStripButton6) index = 1;
            if (tsmi == toolStripButton7) index = 2;
            if (tsmi == toolStripButton4) index = 3;
            if (tsmi == toolStripButton2) index = 4;
            if (tsmi == toolStripButton1) index = 5;
            if (tsmi == toolStripButton5) index = 6;
            if (tsmi == toolStripButton3) index = 7;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
                if (index == 6)
                {
                    g.FillEllipse(c, cX, cY, sX, sY);
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 7)
                {
                    g.FillRectangle(c, cX, cY, sX, sY);
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
            }
        }
    }
}
