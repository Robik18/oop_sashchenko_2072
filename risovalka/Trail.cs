using System.Drawing;

namespace task_paint
{
    class Trail : Figure//наследуются от Figure
    {
        Figure myRectangle1;//переменная класса фигру
        Figure myCircle1;//переменная класса фигру
        Figure myCircle2;//переменная класса фигру
        int height, width;//координаты высоты и ширины
        Pen pen;//координаты пера

        public Trail(Pen Pen, int X, int Y, int Height, int Width)//конструктор, для передачи параметров из класса Form1
        {
            pen = Pen;//переменная из формы записывается в нашу объявленную переменную
            x = X;//переменная из формы записывается в нашу объявленную переменную
            y = Y;//переменная из формы записывается в нашу объявленную переменную
            height = Height;//переменная из формы записывается в нашу объявленную переменную
            width = Width;//переменная из формы записывается в нашу объявленную переменную


        }

        public override void Draw(Graphics gr)//переопределенный метод отрисовки
        {

            myRectangle1 = new MyRectangle(pen, x, y, height, width);//создаем эклемпляр класса нашего прямоугольника
            myCircle1 = new Circle(pen, x, y + height, height / 2, width / 2);//создаем эклемпляр класса круга
            myCircle2 = new Circle(pen, x + width / 2, y + height, height / 2, width / 2);//создаем эклемпляр класса круга
            myRectangle1.Draw(gr);//рисуем прямоугольник
            myCircle1.Draw(gr);//рисуем круг
            myCircle2.Draw(gr);//рисуем круг





        }
        public override void Move(int X, int Y)//метод перемещения
        {
            x = X;//записыаем в начальные координаты, координаты, где опустили мышь
            y = Y;


        }
        public override bool IsPointInside(int X, int Y)//проверка на какую фигуру тыкнули
        {

            

            if ((X <= x + width) && (X >= x) && ((Y <= (y + height) + height * 1 / 2) && (Y >= y)))//проверка наши координаты лежат в нашей области вагона
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
