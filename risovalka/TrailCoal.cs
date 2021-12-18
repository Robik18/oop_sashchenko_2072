using System.Drawing;

namespace task_paint
{
    class TrailCoal : Trail//наследуются от вагона
    {

        int height, width;//координаты высоты и ширины
        Pen pen;//координаты пера
        public TrailCoal(Pen Pen, int X, int Y, int Height, int Width): base(Pen, X, Y, Height, Width)//конструктор, для передачи параметров из класса Form1 
        {


            pen = Pen;//переменная из формы записывается в нашу объявленную переменную
            x = X;//переменная из формы записывается в нашу объявленную переменную
            y = Y;//переменная из формы записывается в нашу объявленную переменную
            height = Height;//переменная из формы записывается в нашу объявленную переменную
            width = Width;//переменная из формы записывается в нашу объявленную переменную
        }

        public override void Draw(Graphics gr)//переопределенный метод отрисовки
        {


            base.Draw(gr);//отрисуем нашего родителя-вагончика
            gr.DrawPolygon(pen, new PointF[] { new PointF(x, y), new PointF(x + (width / 2), y - height / 2), new PointF(x + width, y) });//отрисовка треутольника сверху



        }
        public override void Move(int X, int Y)//метод перемещения
        {

            x = X;//записыаем в начальные координаты, координаты, где опустили мышь
            y = Y;


        }
        public override bool IsPointInside(int X, int Y)//проверка на какую фигуру тыкнули
        {

            
            if ((X <= x + width) && (X >= x) && ((Y <= (y + height) + height * 1 / 2) && (Y >= y - height * 1 / 2)))//проверка наши координаты лежат в нашей области вагона
            {
                return true;//да
            }
            else
            {
                return false;//нет
            }
            




        }

    }
}
