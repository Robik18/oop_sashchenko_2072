using System.Drawing;

namespace task_paint
{
    class Trail : Figure
    {
        Figure myRectangle1;
        Figure myCircle1;
        Figure myCircle2;
        int height, width;
        Pen pen;

        public Trail(Pen Pen, int X, int Y, int Height, int Width)
        {
            pen = Pen;
            x = X;
            y = Y;
            height = Height;
            width = Width;


        }

        public override void Draw(Graphics gr)
        {

            myRectangle1 = new MyRectangle(pen, x, y, height, width);
            myCircle1 = new Circle(pen, x, y + height, height / 2, width / 2);
            myCircle2 = new Circle(pen, x + width / 2, y + height, height / 2, width / 2);
            myRectangle1.Draw(gr);
            myCircle1.Draw(gr);
            myCircle2.Draw(gr);





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

            if ((X <= x + width) && (X >= x) && ((Y <= (y + height) + height * 1 / 2) && (Y >= y)))
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
