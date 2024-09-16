class Program
{
    static void Main(string[] args)
    {
        // Ввод обменных курсов пользователем
        Console.WriteLine("Введите обменный курс USD к EUR:");
        CurrencyUSD.ExchangeRateUSDToEUR = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите обменный курс USD к RUB:");
        CurrencyUSD.ExchangeRateUSDToRUB = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите обменный курс EUR к USD:");
        CurrencyEUR.ExchangeRateEURToUSD = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите обменный курс EUR к RUB:");
        CurrencyEUR.ExchangeRateEURToRUB = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите обменный курс RUB к USD:");
        CurrencyRUB.ExchangeRateRUBToUSD = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите обменный курс RUB к EUR:");
        CurrencyRUB.ExchangeRateRUBToEUR = double.Parse(Console.ReadLine());

        // Пример использования
        CurrencyUSD usd = new CurrencyUSD(100);
        CurrencyEUR eur = usd; // Неявное преобразование USD в EUR
        CurrencyRUB rub = (CurrencyRUB)usd; // Явное преобразование USD в RUB

        Console.WriteLine($"100 USD в EUR: {eur.Value}");
        Console.WriteLine($"100 USD в RUB: {rub.Value}");

        CurrencyEUR eur2 = new CurrencyEUR(100);
        CurrencyUSD usd2 = eur2; // Неявное преобразование EUR в USD
        CurrencyRUB rub2 = (CurrencyRUB)eur2; // Явное преобразование EUR в RUB

        Console.WriteLine($"100 EUR в USD: {usd2.Value}");
        Console.WriteLine($"100 EUR в RUB: {rub2.Value}");

        CurrencyRUB rub3 = new CurrencyRUB(100);
        CurrencyUSD usd3 = rub3; // Неявное преобразование RUB в USD
        CurrencyEUR eur3 = (CurrencyEUR)rub3; // Явное преобразование RUB в EUR

        Console.WriteLine($"100 RUB в USD: {usd3.Value}");
        Console.WriteLine($"100 RUB в EUR: {eur3.Value}");
    }
}