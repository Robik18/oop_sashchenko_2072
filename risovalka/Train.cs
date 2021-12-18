using System.Collections.Generic;
using System.Drawing;

namespace task_paint
{
    class Train : Figure//наследуются от Figure
    {
        Trail trail1, trail2, trail3;
        int height, width;//координаты высоты и ширины
        Pen pen;//координаты пера
 
        public Train(Pen Pen, int X, int Y, int Height, int Width)//конструктор, для передачи параметров из класса Form1
        {
            pen = Pen;//переменная из формы записывается в нашу объявленную переменную
            x = X;//переменная из формы записывается в нашу объявленную переменную
            y = Y;//переменная из формы записывается в нашу объявленную переменную
            height = Height;//переменная из формы записывается в нашу объявленную переменную
            width = Width;//переменная из формы записывается в нашу объявленную переменную
            }
        public override void Draw(Graphics gr)//переопределенный метод отрисовки
        {
            trail1=new Trail(pen, x, y, height, width);//добавляем экземпляр класса вагона в список вагончиков
            trail2=new Trail(pen, x + width, y, height, width);//добавляем экземпляр класса вагона в список вагончиков
            trail3=new Trail(pen, x + width * 2, y, height, width);//добавляем экземпляр класса вагона в список вагончиков
            trail1.Draw(gr);//отрисовка 1го вагона
            trail2.Draw(gr);//отрисовка 2-го вагона
            trail3.Draw(gr);//отрисовка 3го вагона
        }
        public override void Move(int X, int Y)//метод перемещения
        {
            x = X;//записыаем в начальные координаты, координаты, где опустили мышь
            y = Y;
            

        }
        public override bool IsPointInside(int X, int Y)//проверка на какую фигуру тыкнули
        {
            
            if ((X <= x + width * 3) && (X >= x) && ((Y <= (y + height) + height * 1 / 2) && (Y >= y)))//проверка наши координаты лежат в нашей области поезда
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
