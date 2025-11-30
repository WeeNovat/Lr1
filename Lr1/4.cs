using System;

public class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime questionnaireDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.questionnaireDate = DateTime.Now; 
    }

    public string Login
    {
        get { return login; }
        set { login = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public DateTime QuestionnaireDate
    {
        get { return questionnaireDate; }
    }

    public void DisplayInfo()
    {
  Console.WriteLine("\nІнформація про користувача:");
  Console.WriteLine($"Логін: {login}");
  Console.WriteLine($"Ім'я: {firstName}");
  Console.WriteLine($"Прізвище: {lastName}");
  Console.WriteLine($"Вік: {age}");
  Console.WriteLine($"Дата заповнення анкети: {questionnaireDate:dd.MM.yyyy HH:mm:ss}");
    }
}

class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("Заповніть анкету користувача:");

Console.Write("Логін: ");
string login = Console.ReadLine();

Console.Write("Ім'я: ");
string firstName = Console.ReadLine();

Console.Write("Прізвище: ");
string lastName = Console.ReadLine();

Console.Write("Вік: ");
int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);

        user.DisplayInfo();
    }

}
