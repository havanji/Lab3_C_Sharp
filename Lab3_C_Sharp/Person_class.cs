using System;
using System.Security.Cryptography;

class Person
{
    private string name;
    private int birthYear;
    private DateTime date = DateTime.Today;

    public string Name
    {
        get { return name; }
    }

    public int BirthYear
    {
        get { return birthYear; }
    }

    //За умовчуванням
    public Person(): this("Andrii", 2004)
    {
    }

    //Конструктор з параметрами
    public Person(string name, int birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
    }

    //Обчислення віку
    public void Age()
    {
        birthYear = date.Year - birthYear;
        Console.WriteLine(birthYear);
    }

    //Введення даних користувачем
    public void Input()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть ім'я:");
        this.name = Console.ReadLine();
        Console.WriteLine("Рік народження:");
        this.birthYear = Convert.ToInt32(Console.ReadLine());
    }

    //Змінення імені користувача
    public void ChangeName(string newName)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        this.name = newName;
        Console.WriteLine($"Ваше ім'я було змінено на: {newName}");
    }

    //Вивід інформації про користувача
    public void Output()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"Ім'я: {this.name}, Вік: {this.birthYear}");
    }

    //Метод ToString для виведення інформації про користувача
    public override string ToString()
    {
        return $"Ім'я: {this.name}, Вік: {this.birthYear}";
    }

    //Перевірка чи є таке саме ім'я в вказаних людей
    public static bool operator == (Person p1, Person p2)
    {
        return (p1.name == p2.name);
    }
    public static bool operator != (Person p1, Person p2)
    {
        return (p1.name != p2.name);
    }

    //Завдання на виведення інфи про осіб з однаковими іменами
    public void Comparison(Person p1, Person p2)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        if (p1 == p2)
        {
            Console.WriteLine($"Особи з однаковими іменами, їх інформація: {p1}; {p2}");
        }
        else
        {
            Console.WriteLine($"В осіб не однакові імена");
        }
    }
}

