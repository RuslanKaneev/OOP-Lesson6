
/*(*) Создать класс Figure для работы с геометрическими фигурами. В
качестве полей класса задаются цвет фигуры, состояние
«видимое/невидимое». Реализовать операции: передвижение
геометрической фигуры по горизонтали, по вертикали, изменение
цвета, опрос состояния (видимый/невидимый). Метод вывода на
экран должен выводить состояние всех полей объекта. Создать класс
Point (точка) как потомок геометрической фигуры. Создать класс Circle
(окружность) как потомок точки. В класс Circle добавить метод,
который вычисляет площадь окружности. Создать класс Rectangle
(прямоугольник) как потомок точки, реализовать метод вычисления
площади прямоугольника. Точка, окружность, прямоугольник должны
поддерживать методы передвижения по горизонтали и вертикали,
изменения цвета.*/


namespace Lesson6_2
{
    internal class Figure
    {
        public string ColorFigure { get; set; }
        public VisibilityStatus VisibilityFigure { get; set; }


        public int X { get; set; }
        public int Y { get; set; }

        public virtual Figure MoveFigure(int x, int y)

        {
            X += x;
            Y += y;
            return this;
        }
        public string СhangingСolor(string colorFig)
        {
            ColorFigure = colorFig;
            return ColorFigure;
        }

        public VisibilityStatus СhangingVisibilityFigure(VisibilityStatus vis)
        {
            VisibilityFigure = vis;
            return VisibilityFigure;
        }

        public virtual string ToString()
        {
            return "Параметры фигуры: " + " Цвет " + ColorFigure + " Состояние " + VisibilityFigure;

        }

    }
}
