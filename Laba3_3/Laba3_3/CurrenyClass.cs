using System;

public class Currency
{
	public double Value { get; set; }
	public Currency(double value)
	{
		Value = value;
	}
}

public class CurrencyUSD : Currency
{
    public CurrencyUSD(double value) : base(value) { }
    public static double ExchangeRateUSDToEUR { get; set; }
	public static double ExchangeRateUSDToRUB { get; set; }


	public static implicit operator CurrencyEUR(CurrencyUSD usd)
	{
		return new CurrencyEUR(usd.Value * ExchangeRateUSDToEUR);
	}
	public static explicit operator CurrencyRUB(CurrencyUSD usd)
	{
		return new CurrencyRUB(usd.Value * ExchangeRateUSDToRUB);
	}

}

public class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value) { }
    public static double ExchangeRateEURToUSD { get; set; }
	public static double ExchangeRateEURToRUB { get; set; }

	public static implicit operator CurrencyUSD(CurrencyEUR eur)
	{
		return new CurrencyUSD(eur.Value * ExchangeRateEURToUSD);
	}

	public static explicit operator CurrencyRUB(CurrencyEUR eur)
	{
		return new CurrencyRUB(eur.Value * ExchangeRateEURToRUB);
	}
}

public class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) : base(value) { }
    public static double ExchangeRateRUBToUSD { get; set; }
	public static double ExchangeRateRUBToEUR { get; set; }
	
	public static implicit operator CurrencyUSD(CurrencyRUB rub)
	{
		return new CurrencyUSD(rub.Value * ExchangeRateRUBToUSD);
	}

	public static explicit operator CurrencyEUR(CurrencyRUB rub)
	{
		return new CurrencyEUR(rub.Value * ExchangeRateRUBToEUR);
	}
}

