using System.Drawing;
namespace task_paint
{
    class Circle : Figure//наследуются от Figure
    {

        int height, width;//координаты высоты и ширины
        Pen pen;//координаты пера


        public Circle(Pen Pen, int X, int Y, int Height, int Width)//конструктор, для передачи параметров из класса Form1
        {
            pen = Pen;//переменная из формы записывается в нашу объявленную переменную
            x = X;//переменная из формы записывается в нашу объявленную переменную
            y = Y;//переменная из формы записывается в нашу объявленную переменную
            height = Height;//переменная из формы записывается в нашу объявленную переменную
            width = Width;//переменная из формы записывается в нашу объявленную переменную

        }

        public override void Draw(Graphics gr)//переопределенный метод отрисовки
        {
            Rectangle rectangle = new Rectangle();//создаем эклемпляр класса Rectangle
            rectangle.X = x;//определяем в нем координату начальную х
            rectangle.Y = y;//определяем в нем координату начальную у
            rectangle.Height = height;//определяем в нем высоту
            rectangle.Width = width;//определяем в нем ширину
            gr.DrawEllipse(pen, rectangle);//отрисовыаем круг





        }
        public override void Move(int X, int Y)//метод перемещения
        {
            x = X;//записыаем в начальные координаты, координаты, где опустили мышь
            y = Y;
        }
        public override bool IsPointInside(int X, int Y)//проверка на какую фигуру тыкнули
        {

           
            if ((X <= x + width) && (X >= x) && ((Y <= y + height) && (Y >= y)))//провека наши координаты лежат в нашей области круга
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
