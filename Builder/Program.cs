using System;
using Builder.Models;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.Builder builder = null;
            Director director = new Director();

            builder = new CocaColaBuilder();
            director.Construct(builder);
            builder.GetProduct().Show();

            Console.WriteLine(Environment.NewLine);

            builder = new PepsiBuilder();
            director.Construct(builder);
            builder.GetProduct().Show();

            Console.WriteLine(Environment.NewLine);

            builder = new ShwepsBuilder();
            director.Construct(builder);
            builder.GetProduct().Show();

            Console.ReadLine();
        }
    }
}
