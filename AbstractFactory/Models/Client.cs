using AbstractFactory.Models.Core;

namespace AbstractFactory.Models
{
    class Client
    {
        private readonly AbstractWater water;
        private readonly AbstractBottle bottle;
        private readonly AbstractCover cover;
        private readonly AbstractLabel label;

        public Client(Models.Core.AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
            label = factory.CreateLabel();
        }

        public void Run()
        {
            bottle.Interact(water);
            bottle.Interact(cover);
            bottle.Interact(label);
        }
    }
}
