using System;

public class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public Employee(string lN, string fN)
    {
        this.lastName = lN;
        this.firstName = fN;
    }

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }

    public double CalculateSalary()
    {
        double baseSalary = GetBaseSalaryByPosition();
        double experienceBonus = CalculateExperienceBonus(baseSalary);
        return baseSalary + experienceBonus;
    }

    public double CalculateTax()
    {
        return CalculateSalary() * 0.18;
    }

    public void DisplayInfo()
    {
        double salary = CalculateSalary();
        double tax = CalculateTax();

        Console.WriteLine("\nІнформація про співробітника:");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Стаж: {experience} років");
        Console.WriteLine($"Оклад: {salary:F2} грн");
        Console.WriteLine($"Податковий збір: {tax:F2} грн");
        Console.WriteLine($"Чистий дохід: {salary - tax:F2} грн");
    }

    private double GetBaseSalaryByPosition()
    {
        switch (position.ToLower())
        {
            case "директор":
                return 50000;
            case "менеджер":
                return 30000;
            case "розробник":
                return 40000;
            case "аналітик":
                return 35000;
            case "тестувальник":
                return 25000;
            default:
                return 20000;
        }
    }

    private double CalculateExperienceBonus(double bS)
    {
        if (experience >= 10)
            return bS * 0.3;
        else if (experience >= 5)
            return bS * 0.2;
        else if (experience >= 3)
            return bS * 0.1;
        else if (experience >= 1)
            return bS * 0.05;
        else
            return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть інформацію про співробітника:");

        Console.Write("Прізвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Ім'я: ");
        string firstName = Console.ReadLine();

        Employee employee = new Employee(lastName, firstName);

        Console.Write("Посада: ");
        employee.Position = Console.ReadLine();

        Console.Write("Стаж (років): ");
        employee.Experience = int.Parse(Console.ReadLine());
        employee.DisplayInfo();
    }
}