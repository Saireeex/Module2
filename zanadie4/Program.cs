using System;

interface IDrawable
{
    void Draw();
}

class Circle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Рисуем круг");
    }
}

class Rectangle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Рисуем прямоугольник");
    }
}

class Triangle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Рисуем треугольник");
    }
}

class Program
{
    static void Main()
    {
        IDrawable[] shapes = new IDrawable[] { new Circle(), new Rectangle(), new Triangle() };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
