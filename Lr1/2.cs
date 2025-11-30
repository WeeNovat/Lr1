using System;

public class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertFromUah(double a, string b)
    {
        switch (b.ToLower())
        {
            case "usd":
                return a / usd;
            case "eur":
                return a / eur;
            case "pln":
                return a / pln;
            default:
                throw new ArgumentException("Невідома валюта");
        }
    }

    public double ConvertToUah(double a, string b)
    {
        switch (b.ToLower())
        {
            case "usd":
                return a * usd;
            case "eur":
                return a * eur;
            case "pln":
                return a * pln;
            default:
                throw new ArgumentException("Невідома валюта");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter b = new Converter(39.5, 42.0, 9.8);

        Console.WriteLine("Конвертер валют");
        Console.WriteLine("Оберіть тип операції:");
        Console.WriteLine("1 - З гривні в іноземну валюту");
        Console.WriteLine("2 - З іноземної валюти в гривню");

        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть суму:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть валюту (USD, EUR, PLN):");
        string d = Console.ReadLine();

        double result = 0;

        switch (c)
        {
            case 1:
                result = b.ConvertFromUah(a, d);
                Console.WriteLine($"{a} UAH = {result:F2} {d.ToUpper()}");
                break;
            case 2:
                result = b.ConvertToUah(a, d);
                Console.WriteLine($"{a} {d.ToUpper()} = {result:F2} UAH");
                break;
            default:
                Console.WriteLine("Невірний вибір операції");
                break;
        }
    }
}