using System.Numerics;

class Program
{
    static double Func(double x1, double y1, double x2, double y2)
    {
        double d = Math.Sqrt(Math.Pow(x1 * x2, 2) + Math.Pow(y2 - y1, 2));
        return d;
    }
    static double min(double a, double b)
    {
        return (a > b) ? a : b;
    }
    static void Main()
    {
        Console.WriteLine("Программа запущена");
        Console.WriteLine("Введите значение x1");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение y1");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение x2");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение y2");
        double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение x3");
        double x3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение y3");
        double y3 = double.Parse(Console.ReadLine());
        double len1 = Func(x1, y1, x2, y2);
        Console.WriteLine("Длина между первой и второй точкой равна: {0:f3}",len1);
        double len2 = Func(x1, y1, x3, y3);
        Console.WriteLine("Длина между первой и третьей точкой равна: {0:f3}",len2);
        double len3 = Func(x2, y2, x3, y3);
        Console.WriteLine("Длина между второй и третьей точкой равна: {0:f3}",len3);
        double d = min(min(len1, len3), len2);
        Console.WriteLine("Минимальное расстояние: {0:f3}",d);
        Console.WriteLine("Программа завершена");
    }
}

