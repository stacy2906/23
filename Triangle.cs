using System;

class Triangle<T>
{
    public T SideA { get; set; }
    public T SideB { get; set; }
    public T SideC { get; set; }

    public Triangle(T a, T b, T c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Triangle sides: {SideA}, {SideB}, {SideC}");
    }

    public double CalculateArea()
    {
        double a = Convert.ToDouble(SideA);
        double b = Convert.ToDouble(SideB);
        double c = Convert.ToDouble(SideC);
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }
}

