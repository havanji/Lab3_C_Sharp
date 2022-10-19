using System;
using System.Security.Cryptography;

class Car
{
    public const string CompanyName = "Havi-Motors";
    private string name;
    private string model;
    private string color;
    private double price;

    //Властивість доступу до поля колір
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    //За умовчуванням
    public Car() : this("Name", "Model", "White", 10000)
    {
    }

    //Конструктор з параметрами
    public Car(string name, string model, string color, int price)
    {
        this.name = name;
        this.model = model;
        this.Color = color;
        this.price = price;
    }

    //Ввід даних про авто
    public void Input()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть марку машини:");
        this.name = Console.ReadLine();
        Console.WriteLine("Введіть модель машини:");
        this.model = Console.ReadLine();
        Console.WriteLine("Введіть колір машини:");
        this.Color = Console.ReadLine();
        Console.WriteLine("Введіть ціну машини:");
        this.price = Convert.ToDouble(Console.ReadLine());
    }

    //Вивід даних про авто
    public void Print()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"Company name: {Car.CompanyName} Name: {this.name} " +
            $"Model: {this.model} Color: {this.Color} Price: {this.price}");
    }

    //Перевірка чи збігається марка та колір вказаних автомобілів
    public static bool operator ==(Car car1, Car car2)
    {
        return (car1.name == car2.name) && (car1.price == car2.price);
    }
    public static bool operator !=(Car car1, Car car2)
    {
        return (car1.name != car2.name) && (car1.price != car2.price);
    }

    //Вивід данних про авто за допомогою ToString
    public override string ToString()
    {
        return $"Company name: {Car.CompanyName} Name: {this.name} " +
            $"Model: {this.model} Color: {this.Color} Price: {this.price}";
    }

    //додає x% до ціни автомобіля
    public void ChangePrice(double x)
    {
        price += price * x / 100;
    }
}

