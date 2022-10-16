using System;

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

    //deafult
    public Car() : this("Name", "Model", "White", 10000)
    {
    }

    //parametrs
    public Car(string name, string model, string color, int price)
    {
        this.name = name;
        this.model = model;
        this.Color = color;
        this.price = price;
    }

    //input
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

    //print
    public void Print()
    {
        Console.WriteLine($"Company name: {Car.CompanyName} Name: {this.name} " +
            $"Model: {this.model} Color: {this.Color} Price: {this.price}");
    }

    //+ x% to price
    public void ChangePrice(double x)
    {
        price += price * x / 100;
    }
}

