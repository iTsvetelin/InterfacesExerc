using System;

class Program
{
    static void Main(string[] args)
    {
        Ferrari myFerrari = new Ferrari();

        var driverName = Console.ReadLine();

        Console.WriteLine($"{myFerrari.Model}/{myFerrari.PushBrakes()}/{myFerrari.PushGas()}/{driverName}");

    }
}
