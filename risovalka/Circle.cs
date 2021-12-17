using System.Drawing;
namespace task_paint
{
    class Circle : Figure
    {

        int height, width;
        Pen pen;


        public Circle(Pen Pen, int X, int Y, int Height, int Width)
        {
            pen = Pen;
            x = X;
            y = Y;
            height = Height;
            width = Width;

        }

        public override void Draw(Graphics gr)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Height = height;
            rectangle.Width = width;
            gr.DrawEllipse(pen, rectangle);


         


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

            if ((X <= x + width) && (X >= x) && ((Y <= y + height) && (Y >= y)))
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
