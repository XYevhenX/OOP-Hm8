using System;

/*Порушено принцип підстановки Лісков (Liskov Substitution Principle). Квадрат не може 
 *бути спадкоємцем прямокутника, оскільки зміна однієї сторони в квадраті змінює іншу, 
 *що ламає очікувану поведінку прямокутника. Потрібно виділити загальний інтерфейс.*/
/*class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
    public override int Height
    {
        get { return base.Height; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetRectangleArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}*/
interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine(rect.GetArea());

        Square square = new Square();
        square.Side = 5;
        Console.WriteLine(square.GetArea());

        Console.ReadKey();
    }
}