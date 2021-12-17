using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected bool IsPressed = false;
        protected Point StartPoint;
        protected Point EndPoint;
        protected Color Color = Color.Black;
        List<Figure> figures = new List<Figure>();


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();

            foreach (Figure figure in figures)
            {
                figure.Draw(gr);
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                IsPressed = true;
                StartPoint = e.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsPressed == true)
            {
                EndPoint = e.Location;

            }
            IsPressed = false;

            if (Rectangle.Checked)

            {

                Figure rectangle = new MyRectangle(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                figures.Add(rectangle);


            }
            if (Cirlce.Checked)
            {

                Figure circle = new Circle(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                figures.Add(circle);


            }
            if (Wagon.Checked)
            {

                Figure trail = new Trail(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                figures.Add(trail);


            }
            if (WagonCoal.Checked)
            {

                Figure trailCoal = new TrailCoal(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                figures.Add(trailCoal);


            }
            if (Move.Checked)
            {
                foreach (Figure figure in figures)
                {
                    if (figure.IsPointInside(StartPoint.X, StartPoint.Y) != null)
                    {
                        figure.Move(e.X, e.Y);
                    }

                }
            }

            if (Train.Checked)
            {

                Figure train = new Train(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                figures.Add(train);


            }

            panel1.Refresh();
        }



        private void FormClear_Click(object sender, EventArgs e)
        {
            figures.Clear();
            panel1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}