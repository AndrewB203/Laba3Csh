class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota Camry", "V6", 220);
        Car car2 = new Car("Hounda", "V4", 200);
        Car car3 = new Car("Lada", "V3", 180);

        CarsCatalog catalog = new CarsCatalog();
        catalog.AddCar(car1);
        catalog.AddCar(car2);
        catalog.AddCar(car3);

        Console.WriteLine(catalog[0]);
        Console.WriteLine(catalog[1]);
        Console.WriteLine(catalog[2]);

        Console.WriteLine(car1.Equals(car2));
        Console.WriteLine(car1.Equals(new Car("Toyota Camry", "V6", 220)));
    }
}