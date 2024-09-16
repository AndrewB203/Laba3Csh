class Program
{
    static void Main()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);
        Console.WriteLine($"Вектор 1:{v1}");
        Console.WriteLine($"Вектор 2:{v2}");

        Vector sum = v1 + v2;
        Console.WriteLine($"Сумма векторов: {sum}");

        double dotProduct = v1 * v2;
        Console.WriteLine($"Скалярное произведение: {dotProduct}");

        Vector scaled = v1 * 2;
        Console.WriteLine($"Умножение вектора на число: {scaled}");

        Console.WriteLine($"v1 < v2: {v1 < v2}");
        Console.WriteLine($"v1 > v2: {v1 > v2}");
        Console.WriteLine($"v1 == v2: {v1 == v2}");
    }
}