using AbstractFactory.Models.Core;

namespace AbstractFactory.Models.Pepsi
{
    class PepsiFactory : Core.AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new PepsiLabel();
        }
    }
}
