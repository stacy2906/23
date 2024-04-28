class Segment<T>
{
    public T X1 { get; set; }
    public T Y1 { get; set; }
    public T X2 { get; set; }
    public T Y2 { get; set; }

    public Segment(T x1, T y1, T x2, T y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Segment: ({X1}, {Y1}), ({X2}, {Y2})");
    }

    public double CalculateLength()
    {
        double x1 = Convert.ToDouble(X1);
        double y1 = Convert.ToDouble(Y1);
        double x2 = Convert.ToDouble(X2);
        double y2 = Convert.ToDouble(Y2);
        double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return length;
    }
}
