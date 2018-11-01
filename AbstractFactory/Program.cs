using System;
using AbstractFactory.Models;
using AbstractFactory.Models.CocaCola;
using AbstractFactory.Models.Pepsi;
using AbstractFactory.Models.Shweps;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();

            Console.WriteLine(Environment.NewLine);

            client = new Client(new PepsiFactory());
            client.Run();

            Console.WriteLine(Environment.NewLine);

            client = new Client(new ShwepsFactory());
            client.Run();

            Console.ReadKey();
        }
    }
}
