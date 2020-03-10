using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите а");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите в");
        double b = double.Parse(Console.ReadLine());
        double c = a / b;
        Console.WriteLine("Результат с = " + c);
        Console.ReadKey();

    }
}
