using System.Drawing;

namespace task_paint
{
    abstract class Figure//абстрактный класс, так как не знаем с какой именно фигурой работаем
    {
        public int x, y;//начальные координаты
        public abstract void Draw(Graphics gr);//абстрактный метод отрисовки, он обязательно должен быть переопределен в потомках

        public abstract void Move(int X, int Y);//абстрактный метод перемещение, он обязательно должен быть переопределен в потомках

        public abstract bool IsPointInside(int X, int Y);//абстрактный метод определения на какую фигуру нажали, он обязательно должен быть переопределен в потомках


    }
}
