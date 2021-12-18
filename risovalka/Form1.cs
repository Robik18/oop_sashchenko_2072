using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected bool IsPressed = false; //логическая переменная:зажали мышку или нет
        protected Point StartPoint;// начальная координата отрисовки
        protected Point EndPoint;//конечная координа отрисовки
        protected Color Color = Color.Black;//исходный цвет
        List<Figure> figures = new List<Figure>();//список фигур(контейнер) для сохранения их


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();//создали панель для рисования и добавили ссылку на нее в переменную

            foreach (Figure figure in figures)//перебор всех фигур для отрисовки их на панели
            {
                figure.Draw(gr);//отрисовка фигур на панели
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//метод срабатывающий по нажанию кнопки мыши
        {
            {
                IsPressed = true;//кнопка зажата
                StartPoint = e.Location;//записываем начальные координаты в переменную
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)//метод срабатывающий когда отпускаем кнопку мыши
        {
            if (IsPressed == true)//если кнопка нажата
            {
                EndPoint = e.Location;//записывает конечные координаты в переменную

            }
            IsPressed = false;//кнопку опущена

            if (Rectangle.Checked)//если выбран прямоугольник

            {
                
                    //создаем экземпляр прямоугольника и кидаем ссылку на него в переменную типа Figure
                    Figure rectangle = new MyRectangle(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                    figures.Add(rectangle);//добавляем фигуру, в которой лежит ссылка на прямоугольник, в список фигур


            }
            if (Cirlce.Checked)//если выбран круг
            {
              
                    //создаем экземпляр круга и кидаем ссылку на него в переменную типа Figure
                    Figure circle = new Circle(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                    figures.Add(circle);//добавляем фигуру, в которой лежит ссылка на круг, в список фигур
                
                   
                }
            if (Wagon.Checked)
            {
 
                    //создаем экземпляр вагончика и кидаем ссылку на него в переменную типа Figure
                    Figure trail = new Trail(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                    figures.Add(trail);//добавляем фигуру, в которой лежит ссылка на вагончик, в список фигур
               
                }
            if (WagonCoal.Checked)
            {
                    //создаем экземпляр вагончика с песком и кидаем ссылку на него в переменную типа Figure
                    Figure trailCoal = new TrailCoal(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                    figures.Add(trailCoal);//добавляем фигуру, в которой лежит ссылка на вагончик с песком, в список фигур
                

                }
            if (Move.Checked)
            {
                foreach (Figure figure in figures)//перебираем все фигуры из списка
                {
                    if (figure.IsPointInside(StartPoint.X, StartPoint.Y) == true)//если тыкнули по фигуре
                    {
                        figure.Move(e.X, e.Y);//перемещение фигур, используя переданные методу координаты
                    }

                }
            }

            if (Train.Checked)//если выбран поезд
            {
                
                    //создаем экземпляр поезда и кидаем ссылку на него в переменную типа Figure
                    Figure train = new Train(new Pen(Color, 5), StartPoint.X, StartPoint.Y, int.Parse(Height.Text), int.Parse(Width.Text));
                    figures.Add(train);//добавляем фигуру, в которой лежит ссылка на поезд , в список фигур
                

                }

            panel1.Refresh();//обновляем панель
        }



        private void FormClear_Click(object sender, EventArgs e)//происходит когда клием на кнопку "Очистить"
        {
            figures.Clear();//удаляем все фигуры из списка
            panel1.Refresh();//обновляем панель
        }
    }
}