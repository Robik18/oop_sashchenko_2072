using System.Drawing;

namespace task_paint
{
    class Train : Figure
    {
        Trail trail1;
        Trail trail2;
        Trail trail3;
        int height, width;
        Pen pen;
        public Train(Pen Pen, int X, int Y, int Height, int Width)
        {
            pen = Pen;
            x = X;
            y = Y;
            height = Height;
            width = Width;

        }
        public override void Draw(Graphics gr)
        {
            trail1 = new Trail(pen, x, y, height, width);
            trail2 = new Trail(pen, x + width, y, height, width);
            trail3 = new Trail(pen, x + width * 2, y, height, width);
            trail1.Draw(gr);
            trail2.Draw(gr);
            trail3.Draw(gr);
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

            if ((X <= x + width * 3) && (X >= x) && ((Y <= (y + height) + height * 1 / 2) && (Y >= y)))
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
