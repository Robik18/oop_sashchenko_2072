using System.Drawing;

namespace task_paint
{
    abstract class Figure
    {
        public int x, y;
        public virtual void Draw(Graphics gr)
        {

        }
        public virtual void Move(int X, int Y)
        {


        }
        public virtual Figure IsPointInside(int X, int Y)
        {
            return null;

        }

    }
}
