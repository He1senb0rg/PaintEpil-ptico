using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ataqueepileticudiopaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        int lineSize = 4;
        Color clr = Color.Red;
        Random rnd = new Random();
        int contador;
        bool drawPoint = false;
        bool borrraxa = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawPoint = false;

            Pen pen1 = new Pen(clr, lineSize);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(rnd.Next(0, 763), rnd.Next(0, 763));

            g.DrawLine(pen1, p1, p2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            this.DoubleBuffered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (contador = 1; contador <= 10000; contador++)
            {
                Pen pen1 = new Pen(Color.FromArgb(250, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)), lineSize);
                Point p1 = new Point(rnd.Next(0, 763), rnd.Next(0, 763));
                Point p2 = new Point(rnd.Next(0, 763), rnd.Next(0, 763));

                g.DrawLine(pen1, p1, p2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawPoint == true)
            {

                //Brush b1 = new SolidBrush(clr);
                //g.FillEllipse(b1, e.Location.X, e.Location.Y, lineSize, lineSize);
                Pen pen1 = new Pen(Color.FromArgb(200, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), lineSize);
                Point p1 = new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height/2);
                Point p2 = new Point(e.Location.X, e.Location.Y);

                g.DrawLine(pen1, p1, p2);

            }

            if(borrraxa == true)
            {
                Brush b1 = new SolidBrush(Color.White);
                g.FillEllipse(b1, e.Location.X, e.Location.Y, lineSize, lineSize);
            }

            label1.Text = "X: " + e.Location.X.ToString();
            label2.Text = "Y: " + e.Location.Y.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                clr = colorDialog1.Color;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drawPoint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawPoint = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            Brush verde = new SolidBrush(Color.Green);
            g.FillRectangle(verde, 0,0, 330, 470);

            Brush vermelho = new SolidBrush(Color.Red);
            g.FillRectangle(vermelho, 330, 0, 450, 470);

            Brush amarilo = new SolidBrush(Color.Yellow);
            g.FillEllipse(amarilo, 255, 170, 140, 150);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            Brush verde = new SolidBrush(Color.Green);
            g.FillRectangle(verde, 0, 0, 270, 470);

            Brush vermelho = new SolidBrush(Color.Red);
            g.FillRectangle(vermelho, 510, 0, 300, 470);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            Brush verde = new SolidBrush(Color.LimeGreen);
            g.FillRectangle(verde, 0, 0, 770, 470);

            SolidBrush amarilo = new SolidBrush(Color.Yellow);
            
             
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(borrraxa == true)
            {
                borrraxa = false;
            }
            else
            {
                borrraxa = true;
            }
        }
    }
}
