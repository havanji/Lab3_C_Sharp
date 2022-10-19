using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Натисніть любу кнопку для того щоб побачити дані про Car");
            Console.ReadKey();

            //Cars
            Car car1 = new Car("Audi", "A6", "Black", 14600);
            Car car2 = new Car("Voltswagen", "Passat B5", "Silver", 12500);
            Car car3 = new Car("BMW", "528", "Blue", 13400);

            car1.Print();
            car1.ChangePrice(10);
            car1.Print();

            car2.Print();
            car2.ChangePrice(10);
            car2.Print();

            car3.Print();
            car3.ChangePrice(10);
            car3.Print();

            Console.WriteLine(car1 == car2);
            Console.WriteLine(car2 == car3);

            Console.WriteLine("Натисніть любу кнопку для того щоб побачити дані про Person");
            Console.ReadKey();

            //Person
            Person p1 = new Person("Andrii", 2004);
            Person p2 = new Person("Denis", 1995);
            Person p3 = new Person("Elizabeth", 1997);
            Person p4 = new Person("John", 2009);
            Person p5 = new Person("Alina", 2005);
            Person p6 = new Person("John", 2000);

            p1.Age();
            p2.Age();
            p3.Age();
            p4.Age();
            p5.Age();
            p6.Age();

            p1.Output();
            p2.Output();
            p3.Output();
            p4.Output();
            p5.Output();
            p6.Output();

            Console.WriteLine(p1 == p6);
            Console.WriteLine(p4 == p6);

            p2.ChangeName("Victor");
            p2.Output();

            Console.WriteLine("Натисніть любу кнопку для того щоб закрити консоль");
            Console.ReadKey();
        }
    }
}
