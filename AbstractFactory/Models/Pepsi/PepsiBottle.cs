using System;
using AbstractFactory.Models.Core;

namespace AbstractFactory.Models.Pepsi
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        } 

        public override void Interact(AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + cover);
        }

        public override void Interact(AbstractLabel label)
        {
            Console.WriteLine(this + " interacts with " + label);
        }
    }
}
