using System.Drawing;

namespace task_paint
{
    class TrailCoal : Trail
    {

        int height, width;
        Pen pen;
        public TrailCoal(Pen Pen, int X, int Y, int Height, int Width) : base(Pen, X, Y, Height, Width)
        {


            pen = Pen;
            x = X;
            y = Y;
            height = Height;
            width = Width;
        }

        public override void Draw(Graphics gr)
        {


            base.Draw(gr);
            gr.DrawPolygon(pen, new PointF[] { new PointF(x, y), new PointF(x + (width / 2), y - height / 2), new PointF(x + width, y) });



        }
        public override void Move(int X, int Y)
        {

            x = X;
            y = Y;


        }
        public override Figure IsPointInside(int X, int Y)
        {

            bool IsPointsInside1;
            Figure figure = new MyRectangle(pen, X, Y, height, width);

            if ((X <= x + width) && (X >= x) && ((Y <= (y + height) + height * 1 / 2) && (Y >= y - height * 1 / 2)))
            {
                IsPointsInside1 = true;
            }
            else
            {
                IsPointsInside1 = false;
            }
            if (IsPointsInside1 == true)
            {
                return figure;

            }
            else
            {
                return null;
            }




        }

    }
}
