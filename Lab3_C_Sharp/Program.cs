using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_C_Sharp
{
    internal class classCar
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", "A6", "Black", 14600);
            Car car2 = new Car("Voltswagen", "Passat B5", "Silver", 12500);
            Car car3 = new Car("BMW", "528", "Blue", 13400);
            Car car4 = new Car();

            car1.Print();
            car1.ChangePrice(10);
            car1.Print();

            car2.Print();
            car2.ChangePrice(10);
            car2.Print();

            car3.Print();
            car3.ChangePrice(10);
            car3.Print();

            car4.Input();
            car4.Print();
            car4.ChangePrice(25);
            car4.Print();


            Console.ReadKey();
        }
    }
}
