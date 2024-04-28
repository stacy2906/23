class Program
{
    static void Main()
    {
        // Пример работы с классом Triangle
        Triangle<int> triangleInt = new Triangle<int>(3, 4, 5);
        triangleInt.PrintInfo();
        Console.WriteLine($"Area: {triangleInt.CalculateArea()}");

        // Пример работы с классом Segment
        Segment<double> segmentDouble = new Segment<double>(1.5, 2.5, 4.5, 7.8);
        segmentDouble.PrintInfo();
        Console.WriteLine($"Length: {segmentDouble.CalculateLength()}");
    }
}
